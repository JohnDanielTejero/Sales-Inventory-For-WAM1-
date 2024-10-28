namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    partial class ProductsListingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
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
            this.searchbox.Size = new System.Drawing.Size(798, 58);
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
            this.textBox1.Size = new System.Drawing.Size(776, 22);
            this.textBox1.TabIndex = 0;
            // 
            // productsTable
            // 
            this.productsTable.AllowUserToAddRows = false;
            this.productsTable.AllowUserToDeleteRows = false;
            this.productsTable.AllowUserToResizeColumns = false;
            this.productsTable.AllowUserToResizeRows = false;
            this.productsTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.productsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.productsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsTable.ColumnHeadersHeight = 40;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Description,
            this.Price,
            this.Category});
            this.productsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productsTable.EnableHeadersVisualStyles = false;
            this.productsTable.GridColor = System.Drawing.Color.White;
            this.productsTable.Location = new System.Drawing.Point(0, 12);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.RowHeadersWidth = 25;
            this.productsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.productsTable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.productsTable.RowTemplate.Height = 25;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(798, 630);
            this.productsTable.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editUserButton);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Controls.Add(this.addProductButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 642);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 79);
            this.panel2.TabIndex = 13;
            // 
            // editUserButton
            // 
            this.editUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.editUserButton.Location = new System.Drawing.Point(528, 12);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(128, 55);
            this.editUserButton.TabIndex = 8;
            this.editUserButton.Text = "View";
            this.editUserButton.UseVisualStyleBackColor = false;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.deleteUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.deleteUserButton.Location = new System.Drawing.Point(12, 13);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(128, 55);
            this.deleteUserButton.TabIndex = 9;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addProductButton.Location = new System.Drawing.Point(662, 12);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(128, 55);
            this.addProductButton.TabIndex = 7;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // ProductId
            // 
            this.ProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductId.FillWeight = 50F;
            this.ProductId.Frozen = true;
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Width = 67;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductName.FillWeight = 150F;
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 199;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Description.FillWeight = 300F;
            this.Description.Frozen = true;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 200;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Price.FillWeight = 150F;
            this.Price.Frozen = true;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 199;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // ProductsListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(798, 721);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.productsTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsListingForm";
            this.Text = "ProductsForm";
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox searchbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
    }
}