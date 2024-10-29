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

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{

    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            this.loadform(new Dashboard());
            User user = AppHelper.auth.getUser();

            if(user.Role.RoleName != "Admin")
            {
                this.usersButton.Visible = false;
            }

            if (user.Role.RoleName != "Admin" && user.Role.RoleName != "Manager")
            {
                this.categoryButton.Visible = false;
            }
        }
        public void loadform(object form)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.Clear();
            }

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        private void dashboardButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.loadform(new Dashboard());
        }
        private void dashboardButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new Dashboard());
        }

        private void dashboardButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new Dashboard());
        }

        private void inventoryButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.loadform(new ProductsListingForm(this.loadform));
        }

        private void inventoryButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new ProductsListingForm(this.loadform));
        }

        private void inventoryButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new ProductsListingForm(this.loadform));
        }

        private void logoutButton_MouseClick(object sender, MouseEventArgs e)
        {
            AppHelper.auth.logout(this);
        }


        private void logoutButtonIcon_Click(object sender, EventArgs e)
        {
            AppHelper.auth.logout(this);
        }

        private void logoutButtonLabel_Click(object sender, EventArgs e)
        {
            AppHelper.auth.logout(this);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.loadform(new UsersListingForm(this.loadform));
        }

        private void usersButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new UsersListingForm(this.loadform));
        }

        private void usersButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new UsersListingForm(this.loadform));
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            this.loadform(new CategoriesListingForm((this.loadform)));
        }

        private void categoryButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new CategoriesListingForm((this.loadform)));
        }

        private void categoryButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new CategoriesListingForm((this.loadform)));
        }

        private void salesButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new SalesListingForm(this.loadform));
        }

        private void salesButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new SalesListingForm(this.loadform));
        }   

        private void salesButton_Click(object sender, EventArgs e)
        {
            this.loadform(new SalesListingForm(this.loadform));
        }
    }
}
