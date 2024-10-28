using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI
{
    public class CustomPanel : Panel
    {
        private int borderRadius = 30; // Default radius for rounded corners
        private Color borderColor = Color.Black; // Default border color
        private int borderSize = 2; // Default border size

        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a rounded rectangle path
            using (GraphicsPath path = GetRoundedRectanglePath(this.ClientRectangle, borderRadius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                // Set the clipping region to the rounded rectangle
                this.Region = new Region(path);

                // Draw the border
                if (borderSize > 0)
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(penBorder, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arcRect = new Rectangle(rect.Location, size);

            // Top left corner
            path.AddArc(arcRect, 180, 90);

            // Top right corner
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // Bottom right corner
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // Bottom left corner
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
