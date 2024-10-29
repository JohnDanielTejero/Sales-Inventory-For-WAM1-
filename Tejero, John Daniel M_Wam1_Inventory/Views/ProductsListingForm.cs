using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class ProductsListingForm : Form
    {
        private Action<object> parentFormAction;
        private Timer debounceTimer;
        private const int debounceInterval = 300;
        public ProductsListingForm(Action<object> loadform)
        {
            InitializeComponent();
            this.parentFormAction = loadform;
            User user = AppHelper.auth.getUser();
            if (user.Role.RoleName != "Admin" && user.Role.RoleName != "Manager")
            {
                this.deleteProductButton.Visible = false;
            }
            debounceTimer = new Timer();
            debounceTimer.Interval = debounceInterval;
            debounceTimer.Tick += DebounceTimer_Tick;
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            loadProducts();
        }

        private void ProductListing_Load(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            loadProducts();
        }

        private void loadProducts()
        {
            this.productsTable.Rows.Clear();
            string searchInput = productSearchBox.Text.Trim();

            var query = AppHelper.db.Products.Include("Category").Include("Stock").AsQueryable();
                
            if (!string.IsNullOrEmpty(searchInput))
            {
                query = query.Where(p => p.ProductName.Contains(searchInput)
                    || p.Category.CategoryName.Contains(searchInput)
                );
            }

            var products = query.ToList();
            foreach (var product in products)
            {
                this.productsTable.Rows.Add(new object[] { product.ProductID, product.ProductName, product.Description, product.Price, product.Category.CategoryName, product.Stock.Quantity, product.Stock.Last_Updated });
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new ProductsForm(this.parentFormAction, "Add", null));
        }

        private void productSearchBox_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void editProductButton_Click(object sender, EventArgs e)
        {
            if (this.productsTable.SelectedRows.Count > 0)
            {
                var selectedRow = productsTable.SelectedRows[0];

                if (selectedRow.Cells["ProductId"] != null)
                {
                    int productId = (int)selectedRow.Cells["ProductId"].Value;
                    parentFormAction(new ProductsForm(parentFormAction, "Edit", AppHelper.db.Products.Include("Stock").Include("Category").FirstOrDefault(p => p.ProductID == productId)));
                }
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (this.productsTable.SelectedRows.Count > 0)
            {
                var selectedRow = this.productsTable.SelectedRows[0];

                if (selectedRow.Cells["ProductId"] != null)
                {
                    int productId = (int)selectedRow.Cells["ProductId"].Value;
                    try
                    {
                        AppHelper.db.Products.Remove(AppHelper.db.Products.FirstOrDefault(p => p.ProductID == productId));
                        AppHelper.db.SaveChanges();
                        loadProducts();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void viewProductButton_Click(object sender, EventArgs e)
        {
            if(this.productsTable.SelectedRows.Count > 0)
            {
                var selectedRow = productsTable.SelectedRows[0];

                if (selectedRow.Cells["ProductId"] != null)
                {
                    int productId = (int)selectedRow.Cells["ProductId"].Value;
                    parentFormAction(new ProductsForm(parentFormAction, "View", AppHelper.db.Products.Include("Stock").Include("Category").FirstOrDefault(p => p.ProductID == productId)));
                }
            }
        }
    }
}
