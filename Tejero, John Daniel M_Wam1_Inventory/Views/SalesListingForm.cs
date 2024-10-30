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
    public partial class SalesListingForm : Form
    {
        private Action<object> parentFormAction;
        private Timer debounceTimer;
        private const int debounceInterval = 300;
        public SalesListingForm(Action<object> loadform)
        {
            InitializeComponent();
            this.parentFormAction = loadform;
            debounceTimer = new Timer();
            debounceTimer.Interval = debounceInterval;
            debounceTimer.Tick += DebounceTimer_Tick;
            User user = AppHelper.auth.getUser();
            if (user.Role.RoleName != "Admin" && user.Role.RoleName != "Manager")
            {
                this.editSalesButton.Visible = false;
            }
            loadSales();
        }

        private void SalesListing_Load(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            loadSales();
        }


        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            loadSales();
        }

        private void loadSales()
        {
            this.salesTable.Rows.Clear();
            string searchInput = salesSearchBox.Text.Trim();

            var query = AppHelper.db.Sales.Include("User").AsQueryable();

            if (!string.IsNullOrEmpty(searchInput))
            {
                query = query.Where(s => s.User.Username.Contains(searchInput)
                    || s.CustomerName.Contains(searchInput)
                );
            }

            var sales = query.OrderByDescending(s => s.Date_Creation).ToList();
            foreach (var sale in sales)
            {
                this.salesTable.Rows.Add(new object[] { sale.SaleID, sale.User.Username, sale.Date_Creation, sale.CustomerName, $"Php {sale.Total}" });
            }
        }

        private void addSalesButton_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new AddSalesForm(this.parentFormAction, "Add", null));
        }

        private void salesSearchBox_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void viewSalesButton_Click(object sender, EventArgs e)
        {
            if (salesTable.SelectedRows.Count > 0)
            {
                var selectedRow = salesTable.SelectedRows[0];

                if (selectedRow.Cells["SalesId"] != null)
                {
                    int salesId = (int)selectedRow.Cells["SalesId"].Value;
                    parentFormAction(new AddSalesForm(parentFormAction, "View", AppHelper.db.Sales
                        .Include("SalesItems")
                        .Include("SalesItems.Product")
                        .Include("SalesItems.Product.Category")
                        .FirstOrDefault(s => s.SaleID == salesId)));
                }
            }
        }

        private void editSalesButton_Click(object sender, EventArgs e)
        {
            if (salesTable.SelectedRows.Count > 0)
            {
                var selectedRow = salesTable.SelectedRows[0];

                if (selectedRow.Cells["SalesId"] != null)
                {
                    int salesId = (int)selectedRow.Cells["SalesId"].Value;
                    parentFormAction(new AddSalesForm(parentFormAction, "Edit", AppHelper.db.Sales
                        .Include("SalesItems")
                        .Include("SalesItems.Product")
                        .Include("SalesItems.Product.Category")
                        .FirstOrDefault(s => s.SaleID == salesId)));
                }
            }
        }
    }
}
