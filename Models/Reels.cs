using slotMachine.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SlotMachine.Models
{
    public class Reel
    {
        private int SymbolIndex;
        private Image symbol;
        private readonly PictureBox pictureBox;
        private readonly Theme theme;
        private readonly Random random = new Random();

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.pictureBox = pictureBox;
            this.theme = theme;
            this.pictureBox.Paint += Reel_Paint;
            this.Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];
        }

        public Image Symbol
        {
            get => symbol;
            set
            {
                symbol = value;
                pictureBox.Invalidate(); // Trigger repaint to update the display
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            if (symbol != null)
            {
                // Resize the image to fit within the PictureBox dimensions
                int imageWidth = pictureBox.Width;
                int imageHeight = pictureBox.Height;

                // Draw the image resized to fit the PictureBox
                e.Graphics.DrawImage(symbol, new Rectangle(0, 0, imageWidth, imageHeight));
            }
        }

        public void Spin()
        {
            Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];

        }
    }
}