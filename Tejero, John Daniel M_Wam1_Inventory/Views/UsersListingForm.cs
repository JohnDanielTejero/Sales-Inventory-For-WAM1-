using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Context;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class UsersListingForm : Form
    {
        private Action<object> parentFormAction;
        private Timer debounceTimer;
        private const int debounceInterval = 300;

        public UsersListingForm(Action<object> loadForm)
        {
            InitializeComponent();
            parentFormAction = loadForm;
            if (AppHelper.auth.getUser().Role.RoleName != "Admin")
            {
                parentFormAction(new Dashboard());
            }

            debounceTimer = new Timer();
            debounceTimer.Interval = debounceInterval;
            debounceTimer.Tick += DebounceTimer_Tick;
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            loadUsers();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void loadUsers()
        {
            this.userTable.Rows.Clear();
            string searchInput = userSearchTextbox.Text.Trim();
            User currentLog = AppHelper.auth.getUser();
            var query = AppHelper.db.Users.Include("Role")
                .Where(u => u.Role.RoleName != "Admin" && u.UserID != currentLog.UserID);
            if (!string.IsNullOrEmpty(searchInput))
            {
                query = query.Where(u => u.Username.Contains(searchInput)
                    || u.Firstname.Contains(searchInput)
                    || u.Lastname.Contains(searchInput)
                    || u.Role.RoleName.Contains(searchInput)
                );
            }

            var users = query.ToList();
            foreach (var user in users)
            {
                this.userTable.Rows.Add(new object[] { user.UserID, user.Username, user.Firstname, user.Lastname, user.Role.RoleName });
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            loadUsers();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            parentFormAction(new UserForm(parentFormAction, "Add", null));
        }

        private void userSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void viewUserButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                var selectedRow = userTable.SelectedRows[0];

                if (selectedRow.Cells["UserId"] != null)
                {
                    int userId = (int)selectedRow.Cells["UserId"].Value;
                    parentFormAction(new UserForm(parentFormAction, "View", AppHelper.db.Users.FirstOrDefault(u => u.UserID == userId)));
                }
            }
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                var selectedRow = userTable.SelectedRows[0];

                if (selectedRow.Cells["UserId"] != null)
                {
                    int userId = (int)selectedRow.Cells["UserId"].Value;
                    parentFormAction(new UserForm(parentFormAction, "Edit", AppHelper.db.Users.FirstOrDefault(u => u.UserID == userId)));
                }
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (userTable.SelectedRows.Count > 0)
            {
                var selectedRow = userTable.SelectedRows[0];

                if (selectedRow.Cells["UserId"] != null)
                {
                    int userId = (int)selectedRow.Cells["UserId"].Value;
                    try
                    {
                        AppHelper.db.Users.Remove(AppHelper.db.Users.FirstOrDefault(u => u.UserID == userId));
                        AppHelper.db.SaveChanges();
                        loadUsers();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
