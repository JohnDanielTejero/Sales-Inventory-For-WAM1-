using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Context;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class UserForm : Form
    {
        private Action<object> parentFormAction;
        private string mode;
        private User target;
        public UserForm(Action<object> loadForm, string mode, User toView)
        {
            InitializeComponent();
            parentFormAction = loadForm;
            this.mode = mode;
            this.target = toView;

            if (AppHelper.auth.getUser().Role.RoleName != "Admin")
            {
                parentFormAction(new Dashboard());
            }

            var roles = AppHelper.db.Roles.Where(r => r.RoleName != "Admin").ToList();

            foreach (var role in roles) { 
                this.userFormRole.Items.Add(role.RoleName);
            }
            this.userFormRole.Text = "";
            switch (this.mode)
            {
                case "Edit":
                    this.userFormLabel.Text = "Edit User";
                    this.userFormRole.Text = this.target.Role.RoleName;
                    this.userFormUsername.Text = this.target.Username;
                    this.userFormFirstName.Text = this.target.Firstname;
                    this.userFormLastName.Text = this.target.Lastname;
                    this.userFormPassword.Text = this.target.Password;
                    this.userFormRole.Text = this.target.Role.RoleName;
                    this.userFormSubmitButton.Text = "Save Changes";
                    break;
                case "Add":
                    this.userFormLabel.Text = "Add User";
                    this.userFormSubmitButton.Text = "Add User";
                    break;
                default:
                    this.userFormLabel.Text = "View User";
                    this.userFormSubmitButton.Visible = false;
                    this.userFormFirstName.Enabled = false;
                    this.userFormLastName.Enabled = false;
                    this.userFormPassword.Enabled = false;
                    this.userFormUsername.Enabled = false;

                    this.userFormUsername.Text = this.target.Username;
                    this.userFormFirstName.Text = this.target.Firstname;
                    this.userFormLastName.Text = this.target.Lastname;
                    this.userFormPassword.Text = this.target.Password;
                    this.userFormRole.Text = this.target.Role.RoleName;
                    this.userFormDelete.Text = "Back";
                    break;
            }
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
            this.submitForm();
        }

        private void submitForm()
        {
            // Check for fields
            if (string.IsNullOrEmpty(this.userFormUsername.Text.Trim()) ||
                string.IsNullOrEmpty(this.userFormPassword.Text.Trim()) ||
                string.IsNullOrEmpty(this.userFormFirstName.Text.Trim()) ||
                string.IsNullOrEmpty(this.userFormLastName.Text.Trim()) ||
                string.IsNullOrEmpty(this.userFormRole.Text.Trim())
            ){
                MessageBox.Show("All fields are required!", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AppHelper.nameIsValid(this.userFormUsername.Text.Trim()) == false || 
                AppHelper.nameIsValid(this.userFormFirstName.Text.Trim()) == false ||
                AppHelper.nameIsValid(this.userFormLastName.Text.Trim()) == false
            ){
                MessageBox.Show("Names are in incorrect format!", "Incorrect format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //retrieve existing
            User existing = AppHelper.db.Users
                .FirstOrDefault(u => u.Username == this.userFormUsername.Text.Trim());
            int selectedRole = AppHelper.db.Roles.FirstOrDefault(r => r.RoleName == this.userFormRole.Text).RoleID;

            switch (mode)
                {
                    case "Edit":
                        //check for duplicate
                        if(existing != null && existing.UserID != target.UserID)
                        {
                            MessageBox.Show("User already exists.", "User Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        // update user;
                        this.target.Username = this.userFormUsername.Text;
                        this.target.Firstname = this.userFormFirstName.Text;
                        this.target.Lastname = this.userFormLastName.Text;
                        this.target.Password = this.userFormPassword.Text;
                        this.target.RoleID = AppHelper.db.Roles.FirstOrDefault(r => r.RoleName == this.userFormRole.Text).RoleID;

                        AppHelper.db.Users.AddOrUpdate(this.target);
                        AppHelper.db.SaveChanges();
                        MessageBox.Show("User successfully updated.", "User success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case "Add":
                        //check for duplicate
                        if(existing != null)
                        {
                            MessageBox.Show("User already exists.", "User Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;

                        }

                        //insert user
                        AppHelper.db.Users.AddOrUpdate(
                              new User { Username = this.userFormUsername.Text, Firstname = this.userFormFirstName.Text, Lastname = this.userFormLastName.Text, RoleID = selectedRole, Password = this.userFormPassword.Text }
                        );
                        AppHelper.db.SaveChanges();

                        this.userFormRole.Text = "";
                        this.userFormRole.SelectedIndex = -1;
                        this.userFormUsername.Text = "";
                        this.userFormFirstName.Text = "";
                        this.userFormLastName.Text = "";
                        this.userFormPassword.Text = "";
                        
                        MessageBox.Show("User successfully inserted.", "User success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                    default:
                        MessageBox.Show("Submit should not be possible");
                        break;
                }
          

        }
    }
}
