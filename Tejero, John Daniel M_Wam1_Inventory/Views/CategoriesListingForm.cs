using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class CategoriesListingForm : Form
    {
        private Action<object> parentFormAction;
        private Timer debounceTimer;
        private const int debounceInterval = 300;

        public CategoriesListingForm(Action<object> loadForm)
        {
            InitializeComponent();
            parentFormAction = loadForm;

            if (AppHelper.auth.getUser().Role.RoleName != "Admin" && AppHelper.auth.getUser().Role.RoleName != "Manager")
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
            loadCategory();
        }

        private void loadCategory()
        {
            this.categoryTable.Rows.Clear();
            string searchInput = this.categorySearchBox.Text.Trim();
            var query = AppHelper.db.Categories.AsQueryable();
            if (!string.IsNullOrEmpty(searchInput))
            {
                query = query.Where(c => c.CategoryName.Contains(searchInput));
            }

            var categories = query.ToList();
            foreach (var category in categories)
            {
                this.categoryTable.Rows.Add(new object[] { category.CategoryID, category.CategoryName, category.Description });
            }
        }

        private void categoryListFormButton_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new CategoriesForm(this.parentFormAction, "Add", null));
        }
        private void CategoriesListingForm_Load(object sender, EventArgs e)
        {
            loadCategory();
        }
        private void categorySearchBox_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void viewCategoryListButton_Click(object sender, EventArgs e)
        {
            if (categoryTable.SelectedRows.Count > 0)
            {
                var selectedRow = categoryTable.SelectedRows[0];

                if (selectedRow.Cells["CategoryId"] != null)
                {
                    int categoryId = (int)selectedRow.Cells["CategoryId"].Value;
                    parentFormAction(new CategoriesForm(parentFormAction, "View", AppHelper.db.Categories.FirstOrDefault(c => c.CategoryID == categoryId)));
                }
            }
        }

        private void editCategoryListButton_Click(object sender, EventArgs e)
        {
            if (categoryTable.SelectedRows.Count > 0)
            {
                var selectedRow = categoryTable.SelectedRows[0];

                if (selectedRow.Cells["CategoryId"] != null)
                {
                    int categoryId = (int)selectedRow.Cells["CategoryId"].Value;
                    parentFormAction(new CategoriesForm(parentFormAction, "Edit", AppHelper.db.Categories.FirstOrDefault(c => c.CategoryID == categoryId)));
                }
            }
        }

        private void deleteCategoryListButton_Click(object sender, EventArgs e)
        {
            if (categoryTable.SelectedRows.Count > 0)
            {
                var selectedRow = categoryTable.SelectedRows[0];

                if (selectedRow.Cells["CategoryId"] != null)
                {
                    int categoryId = (int)selectedRow.Cells["CategoryId"].Value;
                    try
                    {
                        AppHelper.db.Categories.Remove(AppHelper.db.Categories.FirstOrDefault(c => c.CategoryID == categoryId));
                        AppHelper.db.SaveChanges();
                        loadCategory();
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
