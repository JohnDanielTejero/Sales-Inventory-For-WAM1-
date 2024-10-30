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

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class AddSalesForm : Form
    {
        private Action<object> parentActionForm;
        private string mode;
        private decimal total = 0;
        //contain all list item
        private List<object[]> salesItemProducts = new List<object[]>();
        public AddSalesForm(Action<object> parentActionForm, string mode)
        {
            InitializeComponent();
            this.parentActionForm = parentActionForm;
            this.mode = mode;

            switch (this.mode)
            {
                case "Edit":
                    //load sales item

                    this.addSalesLabel.Text = "Edit Sales";
                    this.addSalesCheckoutButton.Text = "Save Changes";
                    break;

                case "Add":
                    this.addSalesLabel.Text = "Add Sales";
 
                    break;

                default:
                    //load sales item

                    this.addSalesLabel.Text = "View Sales";
                    this.addSalesCancelButton.Text = "Back";
                    this.addSalesCheckoutButton.Visible = false;
                    this.customerName.Enabled = false;
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
                total = total + ((decimal)salesItemProduct[4] * (decimal)salesItemProduct[2]);
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

            switch (this.mode)
            {
                case "Edit":
                   //delete all sales item with current salesId, 
                    break;
                case "Add":
                    Sale sale = new Sale
                    {
                        CustomerName = productFormName.Text,
                        Total = (float)this.total,
                        Date_Creation = DateTime.Now,
                        UserID = logged.UserID
                    };
                    AppHelper.db.Sales.AddOrUpdate(sale);

                    foreach (object[] salesItemProduct in salesItemProducts)
                    {
                        int targetProduct = Convert.ToInt32(salesItemProduct[0]);

                        AppHelper.db.SalesItems.AddOrUpdate(new SalesItem
                        {
                            ProductId = targetProduct,
                            Price = Convert.ToDecimal(salesItemProduct[2]),
                            Quantity = Convert.ToInt32(salesItemProduct[4]),
                            SalesId = sale.SaleID
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
                    MessageBox.Show("Submit should not be possible");
                    break;
            }


        }
    }
}
