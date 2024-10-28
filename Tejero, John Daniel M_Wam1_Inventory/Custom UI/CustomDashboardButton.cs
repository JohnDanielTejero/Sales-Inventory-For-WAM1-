
using System.Drawing;
using System.Windows.Forms;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Custom_UI
{
    public partial class CustomDashboardButton : UserControl
    {
        private Bitmap originalImage;
        private Color foregroundColor = Color.Black;  
        private Color backgroundColor = Color.White;  
        private bool isActivated = false;

        public CustomDashboardButton()
        {
            InitializeComponent();
            UpdateButtonAppearance();
        }

        // Expose the Label text as a public property
        public string LabelText
        {
            get => buttonText.Text; // Access the text of the label
            set => buttonText.Text = value; // Set the text of the label
        }

        #region Appearance Properties

        public Bitmap Image
        {
            get => originalImage;
            set
            {
                originalImage = value;
                UpdateImageColor(isActivated ? backgroundColor : foregroundColor); // Set initial image color
            }
        }

        public override Font Font
        {
            get => buttonText.Font; // Access the font of the label
            set => buttonText.Font = value; // Set the font of the label
        }

        public Color ForegroundColor
        {
            get => foregroundColor;
            set
            {
                foregroundColor = value;
                UpdateButtonAppearance();
            }
        }

        public Color BackgroundColor
        {
            get => backgroundColor;
            set
            {
                backgroundColor = value;
                UpdateButtonAppearance();
            }
        }

        public bool IsActivated
        {
            get => isActivated;
            set
            {
                isActivated = value;
                UpdateButtonAppearance(); // Update appearance on activation state change
            }
        }

        #endregion

        private void UpdateButtonAppearance()
        {
            // Determine colors based on the activation state
            Color currentForegroundColor = isActivated ? backgroundColor : foregroundColor;
            Color currentBackgroundColor = isActivated ? foregroundColor : backgroundColor;

            // Set the colors of the button and label
            this.BackColor = currentBackgroundColor;
            buttonText.ForeColor = currentForegroundColor;

            // Update the image color to match the current foreground color
            UpdateImageColor(currentForegroundColor);
        }

        private void UpdateImageColor(Color newColor)
        {
            if (originalImage != null)
            {
                Bitmap coloredBitmap = ChangeBlackOutlineColor(originalImage, newColor);
                buttonPicture.Image = coloredBitmap;
            }
        }

        private Bitmap ChangeBlackOutlineColor(Bitmap originalBitmap, Color newColor)
        {
            Bitmap newBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int x = 0; x < originalBitmap.Width; x++)
            {
                for (int y = 0; y < originalBitmap.Height; y++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    if (originalColor.A > 0 && originalColor.R == 0 && originalColor.G == 0 && originalColor.B == 0)
                    {
                        newBitmap.SetPixel(x, y, newColor);
                    }
                    else
                    {
                        newBitmap.SetPixel(x, y, originalColor);
                    }
                }
            }

            return newBitmap;
        }
    }
}
