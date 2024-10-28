using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI
{
    public partial class CustomTextField : UserControl
    {
        private Color borderColor = Color.MediumBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private string hintText = "Enter text...";
        private bool isHintVisible = true;

        public CustomTextField()
        {
            InitializeComponent();
            ShowHint();
            customTextbox.Enter += RemoveHint;
            customTextbox.Leave += ShowHint;
        }

        // Border color property with redrawing logic
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        public bool UnderlinedStyle
        {
            get => underlinedStyle;
            set { underlinedStyle = value; Invalidate(); }
        }

        [Category("Custom Properties")]
        [Description("Hint text displayed when the textbox is empty.")]
        public string HintText
        {
            get => hintText;
            set
            {
                hintText = value;
                customHint.Text = hintText;
                ShowHint();
            }
        }

        public bool PasswordChar
        {
            get => customTextbox.UseSystemPasswordChar;
            set => customTextbox.UseSystemPasswordChar = value;
        }

        public bool Multiline
        {
            get => customTextbox.Multiline;
            set
            {
                customTextbox.Multiline = value;
                UpdateControlHeight();
            }
        }

        public override Color BackColor
        {
            get => base.BackColor;
            set
            {
                base.BackColor = value;
                customTextbox.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                customTextbox.ForeColor = value;
                customHint.ForeColor = value;
            }
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                customTextbox.Font = value;
                UpdateControlHeight();
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Texts
        {
            get => customTextbox.Text;
            set => customTextbox.Text = value;
        }

        private void ShowHint()
        {
            if (string.IsNullOrWhiteSpace(customTextbox.Text))
            {
                isHintVisible = true;
                customHint.Visible = true;
            }
        }

        private void RemoveHint(object sender, EventArgs e)
        {
            if (isHintVisible)
            {
                isHintVisible = false;
                customHint.Visible = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (underlinedStyle)
                    e.Graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }
        private void ShowHint(object sender, EventArgs e)
        {
            ShowHint(); // Re-checks if hint should be displayed
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode) UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (!customTextbox.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                customTextbox.MinimumSize = new Size(0, txtHeight);
                this.Height = customTextbox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void customTextbox_Enter(object sender, EventArgs e)
        {
            RemoveHint(sender, e);
            this.Invalidate();
        }

        private void customTextbox_Leave(object sender, EventArgs e)
        {
            this.ShowHint(sender, e);
            this.Invalidate();
        }
    }
}
