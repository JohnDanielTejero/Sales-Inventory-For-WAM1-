using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class AddSalesForm : Form
    {
        private Action<object> parentActionForm;
        public AddSalesForm(Action<object> parentActionForm)
        {
            InitializeComponent();
            this.parentActionForm = parentActionForm;
        }

        private void addSalesItem(object salesItem)
        {
            //TODO: logic for adding sales product

        }
        private void addSalesAddProduct_Click(object sender, EventArgs e)
        {
            SelectProductForm selectProduct = new SelectProductForm(addSalesItem);
            selectProduct.Show();
        }
    }
}
