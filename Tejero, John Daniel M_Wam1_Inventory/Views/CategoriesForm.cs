using Org.BouncyCastle.Asn1.X509;
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
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class CategoriesForm : Form
    {
        private Action<object> parentActionForm;
        private string mode;
        private Category category;

        public CategoriesForm(Action<object> loadForm, string mode, Category category)
        {
            InitializeComponent();
            this.parentActionForm = loadForm;
            this.mode = mode;
            this.category = category;

            if (AppHelper.auth.getUser().Role.RoleName != "Admin" && AppHelper.auth.getUser().Role.RoleName != "Manager")
            {
               this.parentActionForm(new Dashboard());
            }

            switch (this.mode)
            {
                case "Edit":
                    this.categoryFormLabel.Text = "Edit Category";
                    this.categoryFormName.Text = category.CategoryName;
                    this.categoryFormDesc.Text = category.Description;
                    this.categoryFormSubmitButton.Text = "Save Changes";
                    break;
                case "Add":
                    this.categoryFormLabel.Text = "Add Category";
                    this.categoryFormSubmitButton.Text = "Add Category";
                    break;
                default:
                    this.categoryFormLabel.Text = "View User";
                    this.categoryFormSubmitButton.Visible = false;
                    this.categoryFormName.Enabled = false;
                    this.categoryFormDesc.Enabled = false;

                    this.categoryFormName.Text = category.CategoryName;
                    this.categoryFormDesc.Text = category.Description;
                    this.categoryFormCancel.Text = "Back";
                    break;
            }
        }

        private void categoryFormCancel_Click(object sender, EventArgs e)
        {
            this.parentActionForm(new CategoriesListingForm(parentActionForm));
        }

        private void categoryFormSubmitButton_Click(object sender, EventArgs e)
        {
            submitForm();
        }

        private void submitForm()
        {
            // Check for fields
            if (string.IsNullOrEmpty(this.categoryFormName.Text.Trim()) ||
                string.IsNullOrEmpty(this.categoryFormDesc.Text.Trim())
                )
            {
                MessageBox.Show("All fields are required!", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //retrieve existing
            Category existing = AppHelper.db.Categories
                .FirstOrDefault(u => u.CategoryName == this.categoryFormName.Text.Trim());

            switch (mode)
            {
                case "Edit":
                    //check for duplicate
                    if (existing != null && existing.CategoryID != this.category.CategoryID)
                    {
                        MessageBox.Show("Category already exists.", "Category Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // update user;
                    this.category.CategoryName = this.categoryFormName.Text.Trim();
                    this.category.Description = this.categoryFormDesc.Text.Trim();
                   

                    AppHelper.db.Categories.AddOrUpdate(this.category);
                    AppHelper.db.SaveChanges();
                    MessageBox.Show("Category successfully updated.", "Category success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Add":
                    //check for duplicate
                    if (existing != null)
                    {
                        MessageBox.Show("Category already exists.", "Category Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }

                    //insert user
                    AppHelper.db.Categories.AddOrUpdate(
                          new Category { CategoryName = categoryFormName.Text.Trim(), Description = categoryFormDesc.Text.Trim() }
                    );
                    AppHelper.db.SaveChanges();

                    this.categoryFormDesc.Text = "";
                    this.categoryFormName.Text = "";


                    MessageBox.Show("Category successfully inserted.", "Category success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Submit should not be possible");
                    break;
            }
        }
    }
}
