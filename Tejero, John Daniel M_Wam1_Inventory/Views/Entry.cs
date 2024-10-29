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
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;
using static Mysqlx.Datatypes.Scalar.Types;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class Entry : Form
    {

        public Entry()
        {
            InitializeComponent();
        }

        public void Entry_Load(object sender, EventArgs e)
        {
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            //check for username and password;
            if (string.IsNullOrEmpty(this.usernameField.Texts.Trim()) || string.IsNullOrEmpty(this.passwordField.Texts.Trim()))
            {
                ShowMessage("Field is required", "Field Required", MessageBoxIcon.Error);

                return;   
            }
          
            User user = AppHelper.db.Users
                .Include("Role")
                .FirstOrDefault(u => u.Username == this.usernameField.Texts.Trim());

            if (user == null)
            {
                // Message for null
                ShowMessage("No user found with the username provided.", "No User Found", MessageBoxIcon.Error);
                return;
            }
            if (user.Password != this.passwordField.Texts.Trim())
            {
                // Message for null
                ShowMessage("Incorrect password, please try again", "Invalid Credentials", MessageBoxIcon.Error);
                return;
            }

            AppHelper.auth.login(user);
            MainScreen d = new MainScreen();
            this.Hide();
            d.Show();
        }

        private void ShowMessage(string message, string caption, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, icon);
        }
    }
}
