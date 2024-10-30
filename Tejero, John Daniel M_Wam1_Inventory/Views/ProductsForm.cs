using Org.BouncyCastle.Asn1.X509;
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
    public partial class ProductsForm : Form
    {
        private Action<object> parentFormAction;
        private string mode;
        private Product product;

        public ProductsForm(Action<object> parentFormAction, string mode, Product product)
        {
            InitializeComponent();
            this.parentFormAction = parentFormAction;
            this.mode = mode;
            this.product = product;
            var categories = AppHelper.db.Categories.ToList();

            foreach (var category in categories)
            {
                this.productFormCategory.Items.Add(category.CategoryName);
            }

            this.productFormCategory.Text = "";
            switch (this.mode)
            {
                case "Edit":
                    this.productFormLabel.Text = "Edit Product";
                    this.productFormPrice.Value = this.product.Price;
                    this.productFormName.Text = this.product.ProductName;
                    this.productFormQuantity.Value = this.product.Stock.Quantity;
                    this.productFormDesc.Text = this.product.Description;
                    this.productFormCategory.Text = this.product.Category.CategoryName;
                    this.productFormSubmitButton.Text = "Save Changes";
                    break;
                case "Add":
                    this.productFormLabel.Text = "Add Product";
                    this.productFormSubmitButton.Text = "Add Product";
                    break;
                default:
                    this.productFormLabel.Text = "View Product";
                    this.productFormSubmitButton.Visible = false;
                    this.productFormDesc.Enabled = false;
                    this.productFormPrice.Enabled = false;
                    this.productFormName.Enabled = false;
                    this.productFormQuantity.Enabled = false;

                    this.productFormPrice.Value = this.product.Price;
                    this.productFormName.Text = this.product.ProductName;
                    this.productFormQuantity.Value = this.product.Stock.Quantity;
                    this.productFormDesc.Text = this.product.Description;
                    this.productFormCategory.Text = this.product.Category.CategoryName;
                    this.productFormCancel.Text = "Back";
                    break;
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void productFormCancel_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new ProductsListingForm(parentFormAction));
        }

        private void productFormSubmitButton_Click(object sender, EventArgs e)
        {
            submitForm();
        }

        private void submitForm()
        {
            // Check for fields
            if (this.productFormPrice.Value <= 0 ||
                string.IsNullOrEmpty(this.productFormName.Text.Trim()) ||
                string.IsNullOrEmpty(this.productFormDesc.Text.Trim()) ||
                string.IsNullOrEmpty(this.productFormCategory.Text.Trim())
            )
            {
                MessageBox.Show("All fields are required!", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //retrieve existing
            Product existing = AppHelper.db.Products
                .FirstOrDefault(p => p.ProductName == this.productFormName.Text.Trim());
            int selectedCategory = AppHelper.db.Categories.FirstOrDefault(c => c.CategoryName == this.productFormCategory.Text).CategoryID;

            switch (mode)
            {
                case "Edit":
                    //check for duplicate
                    if (existing != null && existing.ProductName != product.ProductName)
                    {
                        MessageBox.Show("Product already exists.", "Product Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // update user;
                    this.product.ProductName = this.productFormName.Text.Trim();
                    this.product.Description = this.productFormDesc.Text.Trim();
                    this.product.Price = this.productFormPrice.Value;
                    this.product.Category.CategoryID = selectedCategory;

                    AppHelper.db.Products.AddOrUpdate(this.product);
                    AppHelper.db.Stocks.AddOrUpdate(
                        new Stock { ProductID = this.product.ProductID, Last_Updated = DateTime.Now, Quantity = (int)this.productFormQuantity.Value }
                        );
                    AppHelper.db.SaveChanges();
                    MessageBox.Show("Product successfully updated.", "Product success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Add":
                    //check for duplicate
                    if (existing != null)
                    {
                        MessageBox.Show("Product already exists.", "Product Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

                    //insert user
                    var newProduct = new Product
                    {
                        ProductName = this.productFormName.Text.Trim(),
                        Description = this.productFormDesc.Text.Trim(),
                        CategoryID = selectedCategory,
                        Price = this.productFormPrice.Value,
                    };
                    AppHelper.db.Products.AddOrUpdate(newProduct);

                    AppHelper.db.Stocks.AddOrUpdate(
                       new Stock { ProductID = newProduct.ProductID, Last_Updated = DateTime.Now, Quantity = (int)this.productFormQuantity.Value }
                      );
                    AppHelper.db.SaveChanges();
                    this.productFormPrice.Value = (decimal)0.00;
                    this.productFormName.Text = "";
                    this.productFormDesc.Text = "";
                    this.productFormQuantity.Value = 0;
                    this.productFormCategory.SelectedIndex = -1;

                    MessageBox.Show("Product successfully inserted.", "Product success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Submit should not be possible");
                    break;
            }
        }
    }
}
