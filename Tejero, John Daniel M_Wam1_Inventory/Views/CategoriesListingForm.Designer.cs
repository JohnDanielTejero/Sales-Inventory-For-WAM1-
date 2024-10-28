namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    partial class CategoriesListingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchbox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoryTable = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewCategoryListButton = new System.Windows.Forms.Button();
            this.deleteCategoryListButton = new System.Windows.Forms.Button();
            this.categoryListFormButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Transparent;
            this.searchbox.Controls.Add(this.textBox1);
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.searchbox.Location = new System.Drawing.Point(0, 0);
            this.searchbox.Margin = new System.Windows.Forms.Padding(0);
            this.searchbox.Name = "searchbox";
            this.searchbox.Padding = new System.Windows.Forms.Padding(10);
            this.searchbox.Size = new System.Drawing.Size(794, 58);
            this.searchbox.TabIndex = 12;
            this.searchbox.TabStop = false;
            this.searchbox.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.textBox1.Location = new System.Drawing.Point(9, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(772, 22);
            this.textBox1.TabIndex = 0;
            // 
            // categoryTable
            // 
            this.categoryTable.AllowUserToAddRows = false;
            this.categoryTable.AllowUserToDeleteRows = false;
            this.categoryTable.AllowUserToResizeColumns = false;
            this.categoryTable.AllowUserToResizeRows = false;
            this.categoryTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.categoryTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.categoryTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryTable.ColumnHeadersHeight = 40;
            this.categoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.categoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.Description});
            this.categoryTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryTable.EnableHeadersVisualStyles = false;
            this.categoryTable.GridColor = System.Drawing.Color.White;
            this.categoryTable.Location = new System.Drawing.Point(5, 5);
            this.categoryTable.MultiSelect = false;
            this.categoryTable.Name = "categoryTable";
            this.categoryTable.ReadOnly = true;
            this.categoryTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categoryTable.RowHeadersVisible = false;
            this.categoryTable.RowHeadersWidth = 25;
            this.categoryTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.categoryTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.categoryTable.RowTemplate.Height = 25;
            this.categoryTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.categoryTable.Size = new System.Drawing.Size(784, 581);
            this.categoryTable.TabIndex = 11;
            // 
            // CategoryId
            // 
            this.CategoryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryId.FillWeight = 50F;
            this.CategoryId.HeaderText = "Id";
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CategoryName.FillWeight = 200F;
            this.CategoryName.HeaderText = "Category";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.FillWeight = 500F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewCategoryListButton);
            this.panel2.Controls.Add(this.deleteCategoryListButton);
            this.panel2.Controls.Add(this.categoryListFormButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 649);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 79);
            this.panel2.TabIndex = 13;
            // 
            // viewCategoryListButton
            // 
            this.viewCategoryListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.viewCategoryListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewCategoryListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewCategoryListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.viewCategoryListButton.Location = new System.Drawing.Point(528, 12);
            this.viewCategoryListButton.Name = "viewCategoryListButton";
            this.viewCategoryListButton.Size = new System.Drawing.Size(128, 55);
            this.viewCategoryListButton.TabIndex = 8;
            this.viewCategoryListButton.Text = "View";
            this.viewCategoryListButton.UseVisualStyleBackColor = false;
            // 
            // deleteCategoryListButton
            // 
            this.deleteCategoryListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteCategoryListButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.deleteCategoryListButton.Location = new System.Drawing.Point(12, 13);
            this.deleteCategoryListButton.Name = "deleteCategoryListButton";
            this.deleteCategoryListButton.Size = new System.Drawing.Size(128, 55);
            this.deleteCategoryListButton.TabIndex = 9;
            this.deleteCategoryListButton.Text = "Delete";
            this.deleteCategoryListButton.UseVisualStyleBackColor = true;
            // 
            // categoryListFormButton
            // 
            this.categoryListFormButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.categoryListFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryListFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryListFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.categoryListFormButton.Location = new System.Drawing.Point(662, 12);
            this.categoryListFormButton.Name = "categoryListFormButton";
            this.categoryListFormButton.Size = new System.Drawing.Size(128, 55);
            this.categoryListFormButton.TabIndex = 7;
            this.categoryListFormButton.Text = "Add";
            this.categoryListFormButton.UseVisualStyleBackColor = false;
            this.categoryListFormButton.Click += new System.EventHandler(this.categoryListFormButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.categoryTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(794, 591);
            this.panel1.TabIndex = 14;
            // 
            // CategoriesListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(794, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesListingForm";
            this.Text = "CategoriesForm";
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView categoryTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button viewCategoryListButton;
        private System.Windows.Forms.Button deleteCategoryListButton;
        private System.Windows.Forms.Button categoryListFormButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Panel panel1;
    }
}