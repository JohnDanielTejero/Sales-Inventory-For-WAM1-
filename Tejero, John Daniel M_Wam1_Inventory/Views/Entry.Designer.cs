using Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    partial class Entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.customPanel1 = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginBtn = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomButtonPrimary();
            this.usernameField = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomTextField();
            this.passwordField = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomTextField();
            this.panel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Location = new System.Drawing.Point(333, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 383);
            this.panel1.TabIndex = 0;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.customPanel1.BorderRadius = 50;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Location = new System.Drawing.Point(112, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.customPanel1.Size = new System.Drawing.Size(100, 100);
            this.customPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Tejero__John_Daniel_M_Wam1_Inventory.Properties.Resources.logo_xD1;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.loginBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.loginBtn.BorderRadius = 15;
            this.loginBtn.BorderSize = 2;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.loginBtn.Location = new System.Drawing.Point(14, 315);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(304, 46);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // usernameField
            // 
            this.usernameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.usernameField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.usernameField.BorderSize = 2;
            this.usernameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.usernameField.HintText = "Username";
            this.usernameField.Location = new System.Drawing.Point(14, 161);
            this.usernameField.Margin = new System.Windows.Forms.Padding(0);
            this.usernameField.Multiline = false;
            this.usernameField.Name = "usernameField";
            this.usernameField.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.usernameField.PasswordChar = false;
            this.usernameField.Size = new System.Drawing.Size(304, 31);
            this.usernameField.TabIndex = 3;
            this.usernameField.Texts = "";
            this.usernameField.UnderlinedStyle = true;
            // 
            // passwordField
            // 
            this.passwordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.passwordField.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.passwordField.BorderSize = 2;
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.passwordField.HintText = "Password";
            this.passwordField.Location = new System.Drawing.Point(14, 229);
            this.passwordField.Margin = new System.Windows.Forms.Padding(0);
            this.passwordField.Multiline = false;
            this.passwordField.Name = "passwordField";
            this.passwordField.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.passwordField.PasswordChar = true;
            this.passwordField.Size = new System.Drawing.Size(304, 31);
            this.passwordField.TabIndex = 4;
            this.passwordField.Texts = "";
            this.passwordField.UnderlinedStyle = true;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tejero__John_Daniel_M_Wam1_Inventory.Properties.Resources.Base_Background;
            this.ClientSize = new System.Drawing.Size(987, 576);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Custom_UI.Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomButtonPrimary loginBtn;
        private CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomTextField usernameField;
        private CustomTextField passwordField;
    }
}