using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.IO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class AddSalesForm : Form
    {
        private Action<object> parentActionForm;
        private string mode;
        private decimal total = 0;

        private Sale sale;
        //contain all list item
        private List<object[]> salesItemProducts = new List<object[]>();
        public AddSalesForm(Action<object> parentActionForm, string mode, Sale sale)
        {
            InitializeComponent();
            this.parentActionForm = parentActionForm;
            this.mode = mode;
            this.sale = sale;

            switch (this.mode)
            {
                case "Edit":
                    //load sales item
                    this.productFormName.Text = this.sale.CustomerName;
                    foreach (SalesItem item in sale.SalesItems)
                    {
                        this.addSalesItem(new object[] {
                            item.ProductId,
                            item.Product.ProductName,
                            Convert.ToDouble(item.Product.Price),
                            item.Product.Category.CategoryName,
                            item.Quantity
                        });
                    }

                    this.addSalesLabel.Text = "Edit Sales";
                    this.addSalesCheckoutButton.Text = "Save Changes";
                    break;

                case "Add":
                    this.addSalesLabel.Text = "Add Sales";

                    break;

                default:
                    //load sales item
                    this.productFormName.Text = this.sale.CustomerName;
                    foreach (SalesItem item in sale.SalesItems)
                    {
                        this.addSalesItem(new object[] {
                            item.ProductId,
                            item.Product.ProductName,
                            Convert.ToDouble(item.Product.Price),
                            item.Product.Category.CategoryName,
                            item.Quantity
                        });
                    }

                    this.addSalesLabel.Text = "View Sales";
                    this.addSalesCancelButton.Text = "Back";
                    this.addSalesAddProduct.Visible = false;
                    this.addSalesDeleteProduct.Visible = false;
                    this.addSalesCheckoutButton.Text = "Print";
                    this.productFormName.Enabled = false;
                    break;
            }

        }

        private void addSalesItem(object[] salesItem)
        {
            salesItemProducts.Add(salesItem);
            updateSales();
        }

        private void updateSales()
        {
            this.total = 0;
            this.productsTable.Rows.Clear();
            foreach (object[] salesItemProduct in salesItemProducts)
            {
                this.productsTable.Rows.Add(salesItemProduct);
                total = total + (Convert.ToDecimal(salesItemProduct[4]) * Convert.ToDecimal(salesItemProduct[2]));
            }
            this.addSalesFormTotalLabel.Text = $"Total: Php: {total}";

        }

        private bool ExistingSalesItem(object productId)
        {
            foreach (object[] salesItem in salesItemProducts)
            {
                if (salesItem[0].Equals(productId))
                {
                    return true; 
                }
            }
            return false;
        }
        private void addSalesAddProduct_Click(object sender, EventArgs e)
        {
            SelectProductForm selectProduct = new SelectProductForm(addSalesItem, ExistingSalesItem);
            selectProduct.Show();
        }

        private void addSalesDeleteProduct_Click(object sender, EventArgs e)
        {
            if (productsTable.SelectedRows.Count > 0)
            {
                var selectedRow = productsTable.SelectedRows[0];

                if (selectedRow.Cells["ProductId"] != null)
                {
                    int selectedProduct = (int)selectedRow.Index;
                    salesItemProducts.RemoveAt(selectedProduct);
                    updateSales();
                }
            }
        }

        private void addSalesCancelButton_Click(object sender, EventArgs e)
        {
            this.parentActionForm(new SalesListingForm(this.parentActionForm));
        }

        private void addSalesCheckoutButton_Click(object sender, EventArgs e)
        {
            User logged = AppHelper.auth.getUser();
            if (productsTable.Rows.Count == 0)
            {
                MessageBox.Show("Products are required!", "No products found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(productFormName.Text))
            {
                MessageBox.Show("Customer name is required!", "No customer name found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mode != "View")
            {
                var result = MessageBox.Show(
                    "Once submitted, sales record can no longer be deleted. Do you want to continue?",
                    "Confirm Submission",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            switch (this.mode)
            {
                case "Edit":
                    var itemsToRemove = this.sale.SalesItems.ToList();
                    //get current stock, add back to product. (update stock)
                    foreach (SalesItem salesItem in itemsToRemove)
                    {
                        int targetProduct = Convert.ToInt32(salesItem.ProductId);
                        Stock stock = AppHelper.db.Stocks.FirstOrDefault(s => s.ProductID == targetProduct);

                        stock.Quantity = stock.Quantity + Convert.ToInt32(salesItem.Quantity);
                        AppHelper.db.Stocks.AddOrUpdate(stock);

                        AppHelper.db.SalesItems.Remove(salesItem);
                    }

                    // Save changes to persist the deletions
                    AppHelper.db.SaveChanges();

                    //update sale
                    sale.CustomerName = this.productFormName.Text;
                    sale.Total = (int)this.total;

                    AppHelper.db.Sales.AddOrUpdate(sale);

                    //insert salesitem again
                    //update stock
                    foreach (object[] salesItemProduct in salesItemProducts)
                    {
                        int targetProduct = Convert.ToInt32(salesItemProduct[0]);

                        var newSalesItem = new SalesItem
                        {
                            ProductId = targetProduct,
                            Price = Convert.ToDecimal(salesItemProduct[2]),
                            Quantity = Convert.ToInt32(salesItemProduct[4]),
                            SalesId = sale.SaleID
                        };

                        AppHelper.db.SalesItems.Add(newSalesItem);

                        Stock stock = AppHelper.db.Stocks.FirstOrDefault(s => s.ProductID == targetProduct);

                        stock.Quantity = stock.Quantity - Convert.ToInt32(salesItemProduct[4]);
                        AppHelper.db.Stocks.AddOrUpdate(stock);
                    }

                    AppHelper.db.SaveChanges();
                    MessageBox.Show("Transaction successfully updated.", "Transaction update success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Add":
                    Sale newSale = new Sale
                    {
                        CustomerName = productFormName.Text,
                        Total = (float)this.total,
                        Date_Creation = DateTime.Now,
                        UserID = logged.UserID
                    };
                    AppHelper.db.Sales.AddOrUpdate(newSale);

                    foreach (object[] salesItemProduct in salesItemProducts)
                    {
                        int targetProduct = Convert.ToInt32(salesItemProduct[0]);

                        AppHelper.db.SalesItems.AddOrUpdate(new SalesItem
                        {
                            ProductId = targetProduct,
                            Price = Convert.ToDecimal(salesItemProduct[2]),
                            Quantity = Convert.ToInt32(salesItemProduct[4]),
                            SalesId = newSale.SaleID
                        });

                        Stock stock = AppHelper.db.Stocks.FirstOrDefault(s => s.ProductID == targetProduct);

                        stock.Quantity = stock.Quantity - Convert.ToInt32(salesItemProduct[4]);
                        AppHelper.db.Stocks.AddOrUpdate(stock);
                    }

                    AppHelper.db.SaveChanges();
                    this.salesItemProducts.Clear();
                    this.productFormName.Text = "";

                    this.updateSales();
                    MessageBox.Show("Transaction successfully inserted.", "Transaction success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                        saveFileDialog.Title = "Save as PDF";
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            SaveFormAsPdf(saveFileDialog.FileName);
                        }
                    }
                    break;
            }

        }
        private Bitmap CaptureFormAsBitmap()
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bitmap, new Rectangle(0, 0, this.Width, this.Height));
            return bitmap;
        }

        private void SaveFormAsPdf(string filePath)
        {
            // Capture the form as a Bitmap
            Bitmap formBitmap = CaptureFormAsBitmap();

            // Convert Bitmap to a MemoryStream
            using (MemoryStream stream = new MemoryStream())
            {
                formBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png); // Save as PNG
                stream.Position = 0;

                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Captured Form as PDF";

                // Create a new PDF page and get its XGraphics object
                PdfPage page = document.AddPage();
                page.Width = formBitmap.Width;
                page.Height = formBitmap.Height;
                XGraphics graphics = XGraphics.FromPdfPage(page);

                // Load XImage from the MemoryStream
                XImage img = XImage.FromStream(stream);

                // Draw the image onto the PDF page
                graphics.DrawImage(img, 0, 0, formBitmap.Width, formBitmap.Height);

                // Save the PDF document
                document.Save(filePath);

                MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


}
