namespace Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI
{
    partial class CustomTextField
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customTextbox = new System.Windows.Forms.TextBox();
            this.customHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customTextbox
            // 
            this.customTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.customTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customTextbox.Location = new System.Drawing.Point(6, 5);
            this.customTextbox.Margin = new System.Windows.Forms.Padding(0);
            this.customTextbox.Name = "customTextbox";
            this.customTextbox.Size = new System.Drawing.Size(240, 13);
            this.customTextbox.TabIndex = 0;
            this.customTextbox.Enter += new System.EventHandler(this.customTextbox_Enter);
            this.customTextbox.Leave += new System.EventHandler(this.customTextbox_Leave);
            // 
            // customHint
            // 
            this.customHint.AutoSize = true;
            this.customHint.BackColor = System.Drawing.Color.Transparent;
            this.customHint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customHint.Location = new System.Drawing.Point(13, 5);
            this.customHint.Margin = new System.Windows.Forms.Padding(0);
            this.customHint.Name = "customHint";
            this.customHint.Size = new System.Drawing.Size(24, 13);
            this.customHint.TabIndex = 1;
            this.customHint.Text = "hint";
            // 
            // CustomTextField
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.customHint);
            this.Controls.Add(this.customTextbox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CustomTextField";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customTextbox;
        private System.Windows.Forms.Label customHint;
    }
}
