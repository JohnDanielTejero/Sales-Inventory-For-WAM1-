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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            this.userTable.Rows.Add(new object[] { 1, "John", "John Daniel", "Tejero", "Admin"});
            this.userTable.Rows.Add(new object[] { 2, "John", "John Daniel", "Tejero", "Admin" });
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            this.userTable.Rows.Clear();
        }
    }
}
