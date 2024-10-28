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
    public partial class CategoriesForm : Form
    {
        private Action<object> parentActionForm;
        public CategoriesForm(Action<object> loadForm)
        {
            InitializeComponent();
            this.parentActionForm = loadForm;
        }

        private void categoryFormCancel_Click(object sender, EventArgs e)
        {
            this.parentActionForm(new CategoriesListingForm(parentActionForm));
        }
    }
}
