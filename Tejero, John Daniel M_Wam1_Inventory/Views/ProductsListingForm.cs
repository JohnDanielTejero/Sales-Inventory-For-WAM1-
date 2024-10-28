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
    public partial class ProductsListingForm : Form
    {
        private Action<object> parentFormAction;
        public ProductsListingForm(Action<object> loadform)
        {
            InitializeComponent();
            this.parentFormAction = loadform;
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new ProductsForm(this.parentFormAction));
        }
    }
}
