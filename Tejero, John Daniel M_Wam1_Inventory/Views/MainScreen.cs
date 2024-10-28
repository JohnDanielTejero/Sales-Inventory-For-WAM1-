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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            this.loadform(new Dashboard());
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

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
            this.loadform(new ProductsForm());
        }

        private void inventoryButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new ProductsForm());
        }

        private void inventoryButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new ProductsForm());
        }

        private void logoutButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.logout();
        }

        private void logout()
        {
            Entry entry = new Entry();
            entry.Show();
            this.Close();
        }

        private void logoutButtonIcon_Click(object sender, EventArgs e)
        {
            this.logout();
        }

        private void logoutButtonLabel_Click(object sender, EventArgs e)
        {
            this.logout();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            this.loadform(new UsersForm());
        }

        private void usersButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new UsersForm());
        }

        private void usersButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new UsersForm());
        }

        private void categoryButton_Paint(object sender, PaintEventArgs e)
        {
            this.loadform(new CategoriesForm());
        }

        private void categoryButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new CategoriesForm());
        }

        private void categoryButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new CategoriesForm());
        }

        private void salesButton_Paint(object sender, PaintEventArgs e)
        {
            this.loadform(new SalesForm());
        }

        private void salesButtonLabel_Click(object sender, EventArgs e)
        {
            this.loadform(new SalesForm());
        }

        private void salesButtonIcon_Click(object sender, EventArgs e)
        {
            this.loadform(new SalesForm());
        }
    }
}
