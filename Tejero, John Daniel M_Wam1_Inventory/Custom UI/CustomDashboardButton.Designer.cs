namespace Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI
{
    partial class CustomDashboardButton
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
            this.buttonPicture = new System.Windows.Forms.PictureBox();
            this.buttonText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPicture
            // 
            this.buttonPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPicture.Image = global::Tejero__John_Daniel_M_Wam1_Inventory.Properties.Resources.dashboard_svgrepo_com;
            this.buttonPicture.Location = new System.Drawing.Point(35, 15);
            this.buttonPicture.Name = "buttonPicture";
            this.buttonPicture.Size = new System.Drawing.Size(50, 50);
            this.buttonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonPicture.TabIndex = 0;
            this.buttonPicture.TabStop = false;
            // 
            // buttonText
            // 
            this.buttonText.AutoSize = true;
            this.buttonText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonText.Location = new System.Drawing.Point(91, 29);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(66, 24);
            this.buttonText.TabIndex = 1;
            this.buttonText.Text = "label1";
            // 
            // CustomDashboardButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonPicture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CustomDashboardButton";
            this.Size = new System.Drawing.Size(324, 90);
            ((System.ComponentModel.ISupportInitialize)(this.buttonPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonPicture;
        private System.Windows.Forms.Label buttonText;
    }
}
