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
        int IWidth, IHeight;

        public WImage(MainWindow par, string name, Image obraz)
        {
            InitializeComponent();
            IBox.Image= new Bitmap(obraz);
            IWidth = IBox.Width;
            IHeight = IBox.Height;
            Text = name.ToString();
            MdiParent = par;
            parent = par;
            par.WIList.Add(this);  
        }

        // konwersja do grayscale
        public void toGrayscale()
        {
            Bitmap image = new Bitmap(this.IBox.Image);
            for (int i = 0; i < this.IBox.Width; ++i)
            {
                for (int j = 0; j < this.IBox.Height; ++j)
                {
                    System.Drawing.Color c = image.GetPixel(i, j);

                    double Temp = 0.0;
                    Temp += c.R * 0.2126;
                    Temp += c.G * 0.7152;
                    Temp += c.B * 0.0722;

                    image.SetPixel(i, j, Color.FromArgb((int)Temp, (int)Temp, (int)Temp));
                }
            }
<<<<<<< HEAD
            this.pictureBox1.Image = image;
        }

        public void negaion() // NOTE - function moved from hist.cs
        {
            this.IBox.Image = image;
         
            Color c;

            for (int x = 0; x < IWidth - 1; x += 1)
                for (int y = 0; y < this.pictureBox1.Height - 1; y += 1)
                {
                    c = image.GetPixel(x, y);

                    image.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.R, 255 - c.R));
                }
            this.pictureBox1.Image = image;
        }

        public void progowanie(int prog)
        {
            this.IBox.Image = image;

            if (prog < 0)
            {
                prog = 0;
            }
            if (prog > 255)
            {
                prog = 255;
            }
            Color c;
            for (int x = 0; x < IWidth - 1; x += 1)
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
            Bitmap img = new Bitmap(IBox.Image);

            Color c;
            int col;
            double[] prog = new double[progs+1];
            double tmp = 255.0/progs;
            prog[0] = 0;
            for (int i = 1; i < prog.Length; i++)
                prog[i] = prog[i - 1] + tmp;
            
            for (int x = 0; x < IWidth - 1; x += 1)
                for (int y = 0; y < IWidth - 1; y += 1)
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

=======
            this.IBox.Image = image;
>>>>>>> FETCH_HEAD
        }

        // wlaczenei opcji w menu przy focusie
        private void WImage_Enter(object sender, EventArgs e)
        {
            parent.MObraz.Enabled = true;
            parent.MOperacje.Enabled = true;
        }

        // wylaczenie odpowiednich opcji w menu przy zmianie focusu
        private void WImage_Leave(object sender, EventArgs e)
        {
            parent.MObraz.Enabled = false;
            parent.MOperacje.Enabled = false;
        }

        // usuniecie obrazu z listy otwartych obrazow po zamknieciu okna
        private void WImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.WIList.Remove(this);
            this.Dispose(true);
        }

        public void erozja(bool sasiad8 = true)
        {
            Bitmap img = new Bitmap(IBox.Image);

            int[,] timg = new int[IWidth, IHeight];
            for (int i = 0; i < IWidth; i++)
            {
                for (int j = 0; j < IHeight; j++)
                {
                    Color cpom = img.GetPixel(i, j);
                    timg[i, j] = (cpom.R + cpom.G + cpom.B) / 3;
                }
            }

            for (int i = 1; i < IWidth - 1; i++)
            {
                for (int j = 1; j < IHeight - 1; j++)
                {
                    int min = timg[i, j];
                    if (min > timg[i - 1, j]) min = timg[i - 1, j];
                    if (min > timg[i, j - 1]) min = timg[i, j - 1];
                    if (min > timg[i, j + 1]) min = timg[i, j + 1];
                    if (min > timg[i + 1, j]) min = timg[i + 1, j];

                    if (sasiad8)
                    {
                        if (min > timg[i - 1, j - 1]) min = timg[i - 1, j - 1];
                        if (min > timg[i - 1, j + 1]) min = timg[i - 1, j + 1];
                        if (min > timg[i + 1, j - 1]) min = timg[i + 1, j - 1];
                        if (min > timg[i + 1, j + 1]) min = timg[i + 1, j + 1];
                    }

                    img.SetPixel(i, j, Color.FromArgb(min, min, min));
                }
            }
            IBox.Image = img;
        }

        public void dylatacja(bool sasiad8 = true)
        {
            Bitmap img = new Bitmap(IBox.Image);

            int[,] timg = new int[IWidth, IHeight];
            for (int i = 0; i < IWidth; i++)
            {
                for (int j = 0; j < IHeight; j++)
                {
                    Color cpom = img.GetPixel(i, j);
                    timg[i, j] = (cpom.R + cpom.G + cpom.B) / 3;
                }
            }

            for (int i = 1; i < IWidth - 1; i++)
            {
                for (int j = 1; j < IHeight - 1; j++)
                {
                    int max = timg[i, j];
                    if (max < timg[i - 1, j]) max = timg[i - 1, j];
                    if (max < timg[i, j - 1]) max = timg[i, j - 1];
                    if (max < timg[i, j + 1]) max = timg[i, j + 1];
                    if (max < timg[i + 1, j]) max = timg[i + 1, j];

                    if (sasiad8)
                    {
                        if (max < timg[i - 1, j - 1]) max = timg[i - 1, j - 1];
                        if (max < timg[i - 1, j + 1]) max = timg[i - 1, j + 1];
                        if (max < timg[i + 1, j - 1]) max = timg[i + 1, j - 1];
                        if (max < timg[i + 1, j + 1]) max = timg[i + 1, j + 1];
                    }

                    img.SetPixel(i, j, Color.FromArgb(max, max, max));
                }
            }
            IBox.Image = img;
        }

        public void otwarcie(bool sasiad8 = true)
        {
            erozja(sasiad8);
            dylatacja(sasiad8);
        }

        public void zamkniecie(bool sasiad8 = true)
        {
            dylatacja(sasiad8);
            erozja(sasiad8);
        }

        public void negacja()
        {
            Bitmap pom = new Bitmap(IBox.Image);

            for (int i = 0; i < IWidth; i++)
            {
                for (int j = 0; j < IWidth; j++)
                {
                    Color cpom = pom.GetPixel(i, j);
                    pom.SetPixel(i, j, Color.FromArgb(255 - cpom.R, 255 - cpom.G, 255 - cpom.B));
                }
            }

            IBox.Image = pom;
        }

        public void HistogramWyrownaj(int mode)
        {
            //Bitmap OpeImage = new Bitmap(IWidth, IHeight);
            //Bitmap Obraz = new Bitmap(ImageBox.Image);
            
            //int[] Lz = new int[256],
            //      Rz = new int[256];
            //Color c;
            //int r,R = 0;
            //long hint = 0;        
            //double[] LUT = new double[256];

            //long havg = Convert.ToInt64(Histogram.Average());

            //for (int i = 0; i < 255; i += 1)
            //{
            //    Lz[i] = R;
            //    hint += Histogram[i];

            //    while (hint > havg)
            //    {

            //        hint -= havg;
            //        R += 1;
            //    }
            //    if (R >= 256) { R = 255; }
            //    Rz[i] = R;

            //}
            //int u, d, l, f, avg;
            //for (int x = 1; x < IWidth - 1; x += 1)
            //    for (int y = 1; y < IHeight - 1; y += 1)
            //    {
            //        c = Obraz.GetPixel(x, y);
            //        r = (int)c.R;
            //        if (Lz[r] == Rz[r])
            //        {
            //            OpeImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
            //        }
            //        l = Obraz.GetPixel(x - 1, y - 1).R;
            //        d = Obraz.GetPixel(x + 1, y - 1).R;
            //        f = Obraz.GetPixel(x + 1, y + 1).R;
            //        u = Obraz.GetPixel(x - 1, y + 1).R;
            //        avg = (l + d + f + u) / 4;
            //        if (avg > Rz[r])
            //        {
            //            OpeImage.SetPixel(x, y, Color.FromArgb(Rz[r], Rz[r], Rz[r]));
            //        }
            //        else if (avg < Lz[r])
            //        {
            //            OpeImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
            //        }
            //        else
            //        {
            //            OpeImage.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
            //        }
            //    }
            //target.pictureBox1.Image = OpeImage;
        }
    }
}
