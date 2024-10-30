namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    partial class SalesListingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchbox = new System.Windows.Forms.GroupBox();
            this.salesSearchBox = new System.Windows.Forms.TextBox();
            this.salesTable = new System.Windows.Forms.DataGridView();
            this.SalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewSalesButton = new System.Windows.Forms.Button();
            this.editSalesButton = new System.Windows.Forms.Button();
            this.addSalesButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Transparent;
            this.searchbox.Controls.Add(this.salesSearchBox);
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.searchbox.Location = new System.Drawing.Point(0, 0);
            this.searchbox.Margin = new System.Windows.Forms.Padding(0);
            this.searchbox.Name = "searchbox";
            this.searchbox.Padding = new System.Windows.Forms.Padding(10);
            this.searchbox.Size = new System.Drawing.Size(800, 58);
            this.searchbox.TabIndex = 12;
            this.searchbox.TabStop = false;
            this.searchbox.Text = "Search";
            // 
            // salesSearchBox
            // 
            this.salesSearchBox.BackColor = System.Drawing.Color.White;
            this.salesSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesSearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.salesSearchBox.Location = new System.Drawing.Point(9, 26);
            this.salesSearchBox.Name = "salesSearchBox";
            this.salesSearchBox.Size = new System.Drawing.Size(778, 22);
            this.salesSearchBox.TabIndex = 0;
            this.salesSearchBox.TextChanged += new System.EventHandler(this.salesSearchBox_TextChanged);
            // 
            // salesTable
            // 
            this.salesTable.AllowUserToAddRows = false;
            this.salesTable.AllowUserToDeleteRows = false;
            this.salesTable.AllowUserToResizeColumns = false;
            this.salesTable.AllowUserToResizeRows = false;
            this.salesTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.salesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.salesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.salesTable.ColumnHeadersHeight = 40;
            this.salesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.salesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesId,
            this.User,
            this.Creation,
            this.Customer,
            this.Total});
            this.salesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesTable.EnableHeadersVisualStyles = false;
            this.salesTable.GridColor = System.Drawing.Color.White;
            this.salesTable.Location = new System.Drawing.Point(5, 5);
            this.salesTable.MultiSelect = false;
            this.salesTable.Name = "salesTable";
            this.salesTable.ReadOnly = true;
            this.salesTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.salesTable.RowHeadersVisible = false;
            this.salesTable.RowHeadersWidth = 25;
            this.salesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.salesTable.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.salesTable.RowTemplate.Height = 25;
            this.salesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesTable.Size = new System.Drawing.Size(790, 597);
            this.salesTable.TabIndex = 11;
            // 
            // SalesId
            // 
            this.SalesId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesId.FillWeight = 50F;
            this.SalesId.HeaderText = "Id";
            this.SalesId.Name = "SalesId";
            this.SalesId.ReadOnly = true;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.User.FillWeight = 150F;
            this.User.HeaderText = "Processed By";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            // 
            // Creation
            // 
            this.Creation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Creation.FillWeight = 150F;
            this.Creation.HeaderText = "Date Created";
            this.Creation.Name = "Creation";
            this.Creation.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.FillWeight = 150F;
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewSalesButton);
            this.panel2.Controls.Add(this.editSalesButton);
            this.panel2.Controls.Add(this.addSalesButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 665);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 79);
            this.panel2.TabIndex = 13;
            // 
            // viewSalesButton
            // 
            this.viewSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.viewSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewSalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.viewSalesButton.Location = new System.Drawing.Point(529, 12);
            this.viewSalesButton.Name = "viewSalesButton";
            this.viewSalesButton.Size = new System.Drawing.Size(128, 55);
            this.viewSalesButton.TabIndex = 9;
            this.viewSalesButton.Text = "View";
            this.viewSalesButton.UseVisualStyleBackColor = false;
            this.viewSalesButton.Click += new System.EventHandler(this.viewSalesButton_Click);
            // 
            // editSalesButton
            // 
            this.editSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.editSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.editSalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.editSalesButton.Location = new System.Drawing.Point(395, 12);
            this.editSalesButton.Name = "editSalesButton";
            this.editSalesButton.Size = new System.Drawing.Size(128, 55);
            this.editSalesButton.TabIndex = 8;
            this.editSalesButton.Text = "Edit";
            this.editSalesButton.UseVisualStyleBackColor = false;
            this.editSalesButton.Click += new System.EventHandler(this.editSalesButton_Click);
            // 
            // addSalesButton
            // 
            this.addSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSalesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addSalesButton.Location = new System.Drawing.Point(663, 12);
            this.addSalesButton.Name = "addSalesButton";
            this.addSalesButton.Size = new System.Drawing.Size(128, 55);
            this.addSalesButton.TabIndex = 7;
            this.addSalesButton.Text = "Add";
            this.addSalesButton.UseVisualStyleBackColor = false;
            this.addSalesButton.Click += new System.EventHandler(this.addSalesButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salesTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(800, 607);
            this.panel1.TabIndex = 14;
            // 
            // SalesListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesListingForm";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesListing_Load);
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox searchbox;
        private System.Windows.Forms.TextBox salesSearchBox;
        private System.Windows.Forms.DataGridView salesTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editSalesButton;
        private System.Windows.Forms.Button addSalesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button viewSalesButton;
    }
}