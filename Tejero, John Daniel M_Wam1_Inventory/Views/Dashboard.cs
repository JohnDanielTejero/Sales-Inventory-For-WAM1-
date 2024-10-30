using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Context;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var thirtyDaysAgo = DateTime.Now.AddDays(-30);
            var salesTotal = AppHelper.db.Sales
                .Where(s => s.Date_Creation >= thirtyDaysAgo)
                .Sum(s => s.Total);
            this.salesCount.Text = $"Php {salesTotal}";

            var emptyStock = AppHelper.db.Stocks
                .Where(s => s.Quantity == 0)
                .Count();
            this.emptyStockCount.Text = $"{emptyStock}";
        }
    }
}
