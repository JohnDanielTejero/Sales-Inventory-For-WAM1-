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
            this.mainLogin = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomPanel();
            this.usernamefield = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomTextField();
            this.passwordfield = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomTextField();
            this.loginbtn = new Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomButtonPrimary();
            this.mainLogin.SuspendLayout();
            this.SuspendLayout();
            //// 
            //// mainLogin
            //// 
            this.mainLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.mainLogin.BorderColor = System.Drawing.Color.Black;
            this.mainLogin.BorderRadius = 10;
            this.mainLogin.BorderSize = 0;
            this.mainLogin.Controls.Add(this.loginbtn);
            this.mainLogin.Controls.Add(this.passwordfield);
            this.mainLogin.Controls.Add(this.usernamefield);
            this.mainLogin.ForeColor = System.Drawing.Color.CadetBlue;
            this.mainLogin.Location = new System.Drawing.Point(378, 101);
            this.mainLogin.Name = "mainLogin";
            this.mainLogin.Size = new System.Drawing.Size(359, 421);
            this.mainLogin.TabIndex = 0;
            //// 
            //// usernamefield
            //// 
            this.usernamefield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.usernamefield.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.usernamefield.BorderSize = 2;
            this.usernamefield.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamefield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.usernamefield.HintText = "Username";
            this.usernamefield.Location = new System.Drawing.Point(17, 155);
            this.usernamefield.Margin = new System.Windows.Forms.Padding(0);
            this.usernamefield.Multiline = false;
            this.usernamefield.Name = "usernamefield";
            this.usernamefield.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.usernamefield.PasswordChar = false;
            this.usernamefield.Size = new System.Drawing.Size(325, 29);
            this.usernamefield.TabIndex = 1;
            this.usernamefield.Texts = "";
            this.usernamefield.UnderlinedStyle = true;
            //// 
            //// passwordfield
            //// 
            this.passwordfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(193)))), ((int)(((byte)(255)))));
            this.passwordfield.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.passwordfield.BorderSize = 2;
            this.passwordfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordfield.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.passwordfield.HintText = "Password";
            this.passwordfield.Location = new System.Drawing.Point(17, 228);
            this.passwordfield.Margin = new System.Windows.Forms.Padding(0);
            this.passwordfield.Multiline = false;
            this.passwordfield.Name = "passwordfield";
            this.passwordfield.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.passwordfield.PasswordChar = true;
            this.passwordfield.Size = new System.Drawing.Size(325, 29);
            this.passwordfield.TabIndex = 2;
            this.passwordfield.Texts = "";
            this.passwordfield.UnderlinedStyle = true;
            //// 
            //// loginbtn
            //// 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.loginbtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(148)))), ((int)(((byte)(249)))));
            this.loginbtn.BorderRadius = 5;
            this.loginbtn.BorderSize = 2;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.loginbtn.Location = new System.Drawing.Point(17, 315);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(325, 56);
            this.loginbtn.TabIndex = 3;
            this.loginbtn.Text = "LOGIN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tejero__John_Daniel_M_Wam1_Inventory.Properties.Resources.Base_Background;
            this.ClientSize = new System.Drawing.Size(1105, 645);
            this.Controls.Add(this.mainLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.mainLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_UI.CustomPanel mainLogin;
        private Custom_UI.CustomTextField usernamefield;
        private Custom_UI.CustomTextField passwordfield;
        private Custom_UI.Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI.CustomButtonPrimary loginbtn;
    }
}