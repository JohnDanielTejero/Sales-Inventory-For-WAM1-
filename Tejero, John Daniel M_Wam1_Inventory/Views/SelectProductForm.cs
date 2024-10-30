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

    public partial class SelectProductForm : Form
    {
       
        private Action<object[]> addSalesItem;
        private Func<object, bool> existingSalesItem;
        public SelectProductForm(Action<object[]> addSalesItem, Func<object, bool> existingSalesItem)
        {
            InitializeComponent();
            this.addSalesItem = addSalesItem;
            this.existingSalesItem = existingSalesItem;

            var products = AppHelper.db.Products
                .Include("Category")
                .Include("Stock")
                .Where(p => p.Stock.Quantity > 0)
                .ToList();

            foreach (Product product in products)
            {
                productsTable.Rows.Add(new object[] { product.ProductID, product.ProductName, product.Description, product.Price, product.Category.CategoryName, product.Stock.Quantity });
            }

        }

        private void cancelProductButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            //check field
            if (productsTable.SelectedRows.Count > 0)
            {
                var selectedRow = productsTable.SelectedRows[0];

                if (selectedRow.Cells["ProductId"] == null || productFormQuantity.Value <= 0)
                {
                    MessageBox.Show("All fields are required!", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                  
                }
                if(this.productFormQuantity.Value > (int)selectedRow.Cells["Quantity"].Value)
                {
                    MessageBox.Show("Product quantity cannot exceed the current stock in the inventory!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.existingSalesItem(selectedRow.Cells["ProductId"].Value))
                {
                    MessageBox.Show("Product already exists in the sales item, please remove the entry!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.addSalesItem(new object[] { 
                    selectedRow.Cells["ProductId"].Value,
                    selectedRow.Cells["ProductName"].Value,
                    selectedRow.Cells["Price"].Value,
                    selectedRow.Cells["Category"].Value,
                    this.productFormQuantity.Value
                });
                this.Close();

            }
            
          
        }
    }
}
