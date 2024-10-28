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
    public partial class CategoriesListingForm : Form
    {
        private Action<object> parentFormAction;
        public CategoriesListingForm(Action<object> loadForm)
        {
            InitializeComponent();
            this.parentFormAction = loadForm;
        }

        private void categoryListFormButton_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new CategoriesForm(this.parentFormAction));
        }
    }
}
