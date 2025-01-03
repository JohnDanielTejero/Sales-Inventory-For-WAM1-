﻿namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    partial class AddSalesForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.customerName = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.productFormName = new System.Windows.Forms.TextBox();
            this.addSalesFormTotalLabel = new System.Windows.Forms.Label();
            this.addSalesCancelButton = new System.Windows.Forms.Button();
            this.addSalesCheckoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addSalesLabel = new System.Windows.Forms.Label();
            this.productsTable = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addSalesDeleteProduct = new System.Windows.Forms.Button();
            this.addSalesAddProduct = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.customerName.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customerName);
            this.panel2.Controls.Add(this.addSalesFormTotalLabel);
            this.panel2.Controls.Add(this.addSalesCancelButton);
            this.panel2.Controls.Add(this.addSalesCheckoutButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 176);
            this.panel2.TabIndex = 16;
            // 
            // customerName
            // 
            this.customerName.Controls.Add(this.label1);
            this.customerName.Controls.Add(this.productFormName);
            this.customerName.Location = new System.Drawing.Point(498, 20);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(290, 45);
            this.customerName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // productFormName
            // 
            this.productFormName.BackColor = System.Drawing.Color.White;
            this.productFormName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productFormName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productFormName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFormName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.productFormName.Location = new System.Drawing.Point(0, 21);
            this.productFormName.Name = "productFormName";
            this.productFormName.Size = new System.Drawing.Size(290, 24);
            this.productFormName.TabIndex = 0;
            // 
            // addSalesFormTotalLabel
            // 
            this.addSalesFormTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addSalesFormTotalLabel.AutoSize = true;
            this.addSalesFormTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSalesFormTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesFormTotalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addSalesFormTotalLabel.Location = new System.Drawing.Point(498, 73);
            this.addSalesFormTotalLabel.Name = "addSalesFormTotalLabel";
            this.addSalesFormTotalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addSalesFormTotalLabel.Size = new System.Drawing.Size(226, 33);
            this.addSalesFormTotalLabel.TabIndex = 10;
            this.addSalesFormTotalLabel.Text = "Total: Php 0.00";
            this.addSalesFormTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addSalesCancelButton
            // 
            this.addSalesCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addSalesCancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesCancelButton.Location = new System.Drawing.Point(498, 109);
            this.addSalesCancelButton.Name = "addSalesCancelButton";
            this.addSalesCancelButton.Size = new System.Drawing.Size(141, 55);
            this.addSalesCancelButton.TabIndex = 9;
            this.addSalesCancelButton.Text = "Cancel";
            this.addSalesCancelButton.UseVisualStyleBackColor = true;
            this.addSalesCancelButton.Click += new System.EventHandler(this.addSalesCancelButton_Click);
            // 
            // addSalesCheckoutButton
            // 
            this.addSalesCheckoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesCheckoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSalesCheckoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSalesCheckoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addSalesCheckoutButton.Location = new System.Drawing.Point(645, 109);
            this.addSalesCheckoutButton.Name = "addSalesCheckoutButton";
            this.addSalesCheckoutButton.Size = new System.Drawing.Size(143, 55);
            this.addSalesCheckoutButton.TabIndex = 7;
            this.addSalesCheckoutButton.Text = "Checkout";
            this.addSalesCheckoutButton.UseVisualStyleBackColor = false;
            this.addSalesCheckoutButton.Click += new System.EventHandler(this.addSalesCheckoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addSalesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 17;
            // 
            // addSalesLabel
            // 
            this.addSalesLabel.AutoSize = true;
            this.addSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSalesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesLabel.Location = new System.Drawing.Point(12, 19);
            this.addSalesLabel.Name = "addSalesLabel";
            this.addSalesLabel.Size = new System.Drawing.Size(172, 37);
            this.addSalesLabel.TabIndex = 4;
            this.addSalesLabel.Text = "Add Sales";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productsTable.ColumnHeadersHeight = 40;
            this.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Price,
            this.Category,
            this.Quantity});
            this.productsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsTable.EnableHeadersVisualStyles = false;
            this.productsTable.GridColor = System.Drawing.Color.White;
            this.productsTable.Location = new System.Drawing.Point(0, 0);
            this.productsTable.MultiSelect = false;
            this.productsTable.Name = "productsTable";
            this.productsTable.ReadOnly = true;
            this.productsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsTable.RowHeadersVisible = false;
            this.productsTable.RowHeadersWidth = 25;
            this.productsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.productsTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.productsTable.RowTemplate.Height = 25;
            this.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsTable.Size = new System.Drawing.Size(800, 418);
            this.productsTable.TabIndex = 14;
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
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Category.Frozen = true;
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 135;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quantity.Frozen = true;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 200;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 494);
            this.panel3.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.productsTable);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 418);
            this.panel6.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addSalesDeleteProduct);
            this.panel4.Controls.Add(this.addSalesAddProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 76);
            this.panel4.TabIndex = 15;
            // 
            // addSalesDeleteProduct
            // 
            this.addSalesDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.addSalesDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesDeleteProduct.Location = new System.Drawing.Point(158, 9);
            this.addSalesDeleteProduct.Name = "addSalesDeleteProduct";
            this.addSalesDeleteProduct.Size = new System.Drawing.Size(141, 55);
            this.addSalesDeleteProduct.TabIndex = 10;
            this.addSalesDeleteProduct.Text = "Delete Product";
            this.addSalesDeleteProduct.UseVisualStyleBackColor = true;
            this.addSalesDeleteProduct.Click += new System.EventHandler(this.addSalesDeleteProduct_Click);
            // 
            // addSalesAddProduct
            // 
            this.addSalesAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addSalesAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSalesAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSalesAddProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addSalesAddProduct.Location = new System.Drawing.Point(9, 9);
            this.addSalesAddProduct.Name = "addSalesAddProduct";
            this.addSalesAddProduct.Size = new System.Drawing.Size(143, 55);
            this.addSalesAddProduct.TabIndex = 8;
            this.addSalesAddProduct.Text = "Add Product";
            this.addSalesAddProduct.UseVisualStyleBackColor = false;
            this.addSalesAddProduct.Click += new System.EventHandler(this.addSalesAddProduct_Click);
            // 
            // AddSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSalesForm";
            this.Text = "Sales";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.customerName.ResumeLayout(false);
            this.customerName.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addSalesCancelButton;
        private System.Windows.Forms.Button addSalesCheckoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView productsTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label addSalesFormTotalLabel;
        private System.Windows.Forms.Panel customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productFormName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addSalesDeleteProduct;
        private System.Windows.Forms.Button addSalesAddProduct;
        private System.Windows.Forms.Label addSalesLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}