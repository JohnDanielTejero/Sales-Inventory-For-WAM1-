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
    public partial class UserForm : Form
    {
        private Action<object> parentFormAction;
        public UserForm(Action<object> loadForm)
        {
            InitializeComponent();
            parentFormAction = loadForm;
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            navigateBack();
        }

        private void navigateBack()
        {
            parentFormAction(new UsersListingForm(parentFormAction));

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            //TODO: Add logic for adding user
        }
    }
}
