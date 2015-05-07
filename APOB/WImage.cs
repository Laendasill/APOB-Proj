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

        public void negaion() // NOTE - function moved from hist.cs
        {
            Bitmap image = new Bitmap(this.pictureBox1.Image);
         
            Color c;

            for (int x = 0; x < this.pictureBox1.Width - 1; x += 1)
                for (int y = 0; y < this.pictureBox1.Height - 1; y += 1)
                {
                    c = image.GetPixel(x, y);

                    image.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.R, 255 - c.R));
                }
            this.pictureBox1.Image = image;
        }

        public void progowanie(int prog)
        {
            Bitmap image = new Bitmap(this.pictureBox1.Image);

            if (prog < 0)
            {
                prog = 0;
            }
            if (prog > 255)
            {
                prog = 255;
            }
            Color c;
            for (int x = 0; x < this.pictureBox1.Width - 1; x += 1)
                for (int y = 0; y < this.pictureBox1.Height - 1; y += 1)
                {
                    c = image.GetPixel(x, y);
                    if (c.R > prog)
                    {
                        image.SetPixel(x, y, Color.FromArgb(1, 1, 1));
                    }
                    if (c.R < prog)
                    {
                        image.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
            this.pictureBox1.Image = image;
        }

        public void reductGrayScale(int progs)
        {
            Bitmap image = new Bitmap(this.pictureBox1.Image);

            Color c;
            int col;
            double[] prog = new double[progs+1];
            double tmp = 255.0/progs;
            prog[0] = 0;
            for (int i = 1; i < prog.Length; i++)
                prog[i] = prog[i - 1] + tmp;
            
            for (int x = 0; x < this.pictureBox1.Width - 1; x += 1)
                for (int y = 0; y < this.pictureBox1.Height - 1; y += 1)
                {
                    c = image.GetPixel(x, y);
                    for (int i = 1; i < prog.Length; i += 1)
                    {
                        if (c.G > prog[i])
                        {
                           // col = (int)prog[i - 1];
                           // image.SetPixel(x, y, Color.FromArgb(col, col, col));
                            continue;
                        }
                        else if (c.G == 255)
                        {
                            col = c.R;
                            image.SetPixel(x, y, Color.FromArgb(col, col, col));
                            break;
                        }else 
                        {
                            col = (int)prog[i - 1];
                            image.SetPixel(x, y, Color.FromArgb(col, col, col));
                            break;
                        }
                       
                        
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
