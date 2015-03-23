using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOB
{
    public partial class WImage : Form
    {
        // ref na glowne okno
        MainWindow parent;

        public WImage(MainWindow par)
        {
            InitializeComponent();
            this.parent = par;
        }

        // konwersja do grayscale
        public void toGrayscale()
        {
            Bitmap image = new Bitmap(this.pictureBox1.Image);
            for (int i = 0; i < this.pictureBox1.Width; ++i)
            {
                for (int j = 0; j < this.pictureBox1.Height; ++j)
                {

                    System.Drawing.Color c = image.GetPixel(i, j);

                    double Temp = 0.0;
                    Temp += c.R * 0.2126;
                    Temp += c.G * 0.7152;
                    Temp += c.B * 0.0722;

                    image.SetPixel(i, j, Color.FromArgb((int)Temp, (int)Temp, (int)Temp));
                }
            }
            this.pictureBox1.Image = image;
        }
        private void WImage_Load(object sender, EventArgs e)
        {

        }

        private void WImage_Enter(object sender, EventArgs e)
        {
            parent.obrazToolStripMenuItem.Enabled = true;
        }

        private void WImage_Leave(object sender, EventArgs e)
        {
            parent.obrazToolStripMenuItem.Enabled = false;
        }

        private void WImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.WIList.Remove(this);
        }

    }
}
