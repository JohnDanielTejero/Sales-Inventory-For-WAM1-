﻿namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    partial class UsersListingForm
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
            this.userSearchTextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.viewUserButton = new System.Windows.Forms.Button();
            this.searchbox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.Transparent;
            this.searchbox.Controls.Add(this.userSearchTextbox);
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.searchbox.Location = new System.Drawing.Point(0, 0);
            this.searchbox.Margin = new System.Windows.Forms.Padding(0);
            this.searchbox.Name = "searchbox";
            this.searchbox.Padding = new System.Windows.Forms.Padding(10);
            this.searchbox.Size = new System.Drawing.Size(802, 58);
            this.searchbox.TabIndex = 5;
            this.searchbox.TabStop = false;
            this.searchbox.Text = "Search";
            this.searchbox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // userSearchTextbox
            // 
            this.userSearchTextbox.BackColor = System.Drawing.Color.White;
            this.userSearchTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userSearchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.userSearchTextbox.Location = new System.Drawing.Point(9, 26);
            this.userSearchTextbox.Name = "userSearchTextbox";
            this.userSearchTextbox.Size = new System.Drawing.Size(780, 22);
            this.userSearchTextbox.TabIndex = 0;
            this.userSearchTextbox.TextChanged += new System.EventHandler(this.userSearchTextbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.userTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(802, 544);
            this.panel1.TabIndex = 6;
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AllowUserToResizeColumns = false;
            this.userTable.AllowUserToResizeRows = false;
            this.userTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.userTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userTable.ColumnHeadersHeight = 40;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.Username,
            this.FirstName,
            this.LastName,
            this.Role});
            this.userTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTable.EnableHeadersVisualStyles = false;
            this.userTable.GridColor = System.Drawing.Color.White;
            this.userTable.Location = new System.Drawing.Point(5, 5);
            this.userTable.MultiSelect = false;
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(217)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.userTable.RowHeadersVisible = false;
            this.userTable.RowHeadersWidth = 25;
            this.userTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.userTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.userTable.RowTemplate.Height = 25;
            this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userTable.Size = new System.Drawing.Size(792, 534);
            this.userTable.TabIndex = 0;
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.FillWeight = 50F;
            this.UserId.HeaderText = "Id";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Username.FillWeight = 150F;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.FillWeight = 150F;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.FillWeight = 150F;
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.addUserButton.Location = new System.Drawing.Point(662, 12);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(128, 55);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.editUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.editUserButton.Location = new System.Drawing.Point(394, 13);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(128, 55);
            this.editUserButton.TabIndex = 8;
            this.editUserButton.Text = "Edit";
            this.editUserButton.UseVisualStyleBackColor = false;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
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
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.viewUserButton);
            this.panel2.Controls.Add(this.editUserButton);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Controls.Add(this.addUserButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 608);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 79);
            this.panel2.TabIndex = 10;
            // 
            // viewUserButton
            // 
            this.viewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.viewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.viewUserButton.Location = new System.Drawing.Point(528, 13);
            this.viewUserButton.Name = "viewUserButton";
            this.viewUserButton.Size = new System.Drawing.Size(128, 55);
            this.viewUserButton.TabIndex = 10;
            this.viewUserButton.Text = "View";
            this.viewUserButton.UseVisualStyleBackColor = false;
            this.viewUserButton.Click += new System.EventHandler(this.viewUserButton_Click);
            // 
            // UsersListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.searchbox.ResumeLayout(false);
            this.searchbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox searchbox;
        private System.Windows.Forms.TextBox userSearchTextbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Button viewUserButton;
    }
}