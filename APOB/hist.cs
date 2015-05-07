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
    public partial class hist : Form
    {
        MainWindow parent;
        WImage target;
        private long[] Histogram; // przechowuje tabele histogramu

        public hist(MainWindow par, WImage im)
        {
            InitializeComponent();
            parent = par;
            target = im;
            this.pictureBox2.Image = new Bitmap(265, 130);
            aktualizujHist();
        }

        // tworzy histogram dla aktywnego obrazu
        public void aktualizujHist()
        {
            Bitmap obraz = new Bitmap(target.pictureBox1.Image);
            Histogram = new long[256];
            double max = 0;

            for (int i = 0; i < obraz.Size.Width; i++)
            {
                for (int j = 0; j < obraz.Size.Height; j++)
                {
                    System.Drawing.Color c = obraz.GetPixel(i, j);

                    double Temp = 0.0;
                    Temp += c.R * 0.2126;
                    Temp += c.G * 0.7152;
                    Temp += c.B * 0.0722;

                    
                    Histogram[(int)Temp]++;
                }
            }

            for (int i = 0; i < 256; i++)
            {
                if (max < Histogram[i]) max = Histogram[i];
            }
                obraz = new Bitmap(265, 130);
            using (Graphics g = Graphics.FromImage(obraz))
            {
                g.SetClip(new RectangleF(0, 0, 265, 130), System.Drawing.Drawing2D.CombineMode.Replace);

                for (int i = 0; i < Histogram.Length; i++)
                {
                    double pct = Histogram[i] / max;   // What percentage of the max is this value?
                    g.DrawLine(Pens.Black,
                        new Point(i + 5, obraz.Height - 7),
                        new Point(i + 5, obraz.Height -7- ((int)(pct * 60)))  // Use that percentage of the height
                        );
                }
                
                g.DrawImage(obraz, new RectangleF(0,0,265,130));
            }
            this.pictureBox2.Image = obraz;
        }
        
        
        private void hist_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        public void EqRnd()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
            
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(Histogram.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += Histogram[i];

                while (hint > havg)
                {

                    hint -= havg;
                    R += 1;
                }
                if (R >= 256) { R = 255; }
                Rz[i] = R;
                LUT[i] = Rz[i] - Lz[i];
                //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            }
            Random rnd = new Random();
            for (int x = 0; x < width; x += 1)
                for (int y = 0; y < height; y += 1)
                {
                    c = Obraz.GetPixel(x,y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
                    }
                    int rn = rnd.Next(Convert.ToInt32(LUT[r]));
                    EqImage.SetPixel(x, y, Color.FromArgb(Lz[r] + rn, Lz[r] + rn, Lz[r] + rn));
                }

            target.pictureBox1.Image = EqImage;
            aktualizujHist();
            
        }
        public void EqAvg()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
            
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(Histogram.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += Histogram[i];

                while (hint > havg)
                {

                    hint -= havg;
                    R += 1;
                }
                if (R >= 256) { R = 255; }
                Rz[i] = R;
                LUT[i] = (Rz[i] + Lz[i]) / 2;
                //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            }
            for (int x = 0; x < width; x += 1)
                for (int y = 0; y < height; y += 1)
                {
                    c = Obraz.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
                    }

                    EqImage.SetPixel(x, y, Color.FromArgb((int)LUT[r], (int)LUT[r], (int)LUT[r]));
                }

            target.pictureBox1.Image = EqImage;
            aktualizujHist();
        }
        public void NeighAvg()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
            
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(Histogram.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += Histogram[i];

                while (hint > havg)
                {

                    hint -= havg;
                    R += 1;
                }
                if (R >= 256) { R = 255; }
                Rz[i] = R;

                //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            }
            int u, d, l, f, avg;
            for (int x = 1; x < width - 1; x += 1)
                for (int y = 1; y < height - 1; y += 1)
                {
                    c = Obraz.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
                    }
                    l = Obraz.GetPixel(x - 1, y - 1).R;
                    d = Obraz.GetPixel(x + 1, y - 1).R;
                    f = Obraz.GetPixel(x + 1, y + 1).R;
                    u = Obraz.GetPixel(x - 1, y + 1).R;
                    avg = (l + d + f + u) / 4;
                    if (avg > Rz[r])
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(Rz[r], Rz[r], Rz[r]));
                    }
                    else if (avg < Lz[r])
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
                    }
                    else
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
            target.pictureBox1.Image = EqImage;
            aktualizujHist();
            
        }

        // CW 2 progowania i takie tam sprawy
        /* moved to WImage class
        public void negaion()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            Color c;
            for (int x = 0; x < width - 1; x += 1)
                for (int y = 0; y < height - 1; y += 1)
                {
                   c = Obraz.GetPixel(x, y);

                   EqImage.SetPixel(x, y, Color.FromArgb(255 - c.R,255 - c.R,255 - c.R));
                }
            target.pictureBox1.Image = EqImage;
            aktualizujHist();
        }
       
        public void progowanie()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            int prog = 150;
            Color c;
            for (int x = 0; x < width - 1; x += 1)
                for (int y = 0; y < height - 1; y += 1)
                {
                    c = Obraz.GetPixel(x, y);
                    if(c.R > prog){
                    EqImage.SetPixel(x, y, Color.FromArgb(1,1,1));
                    }
                    if(c.R < prog){
                        EqImage.SetPixel(x, y, Color.FromArgb(0,0,0));
                    }
                }
            target.pictureBox1.Image = EqImage;
            aktualizujHist();
        }
        
        public void reductGrayScale()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            Color c;
            int col;
            int[] prog = { 0, 2, 4, 8, 16, 24, 48, 200, 255 };
            for (int x = 0; x < width - 1; x += 1)
                for (int y = 0; y < height - 1; y += 1)
                {
                    c = Obraz.GetPixel(x, y);
                    for (int i = 0; i < prog.Length; i += 1)
                    {
                        if (c.R < prog[i])
                        {
                            col = prog[i - 1];
                            EqImage.SetPixel(x, y, Color.FromArgb(col, col, col));
                        }
                        else
                        {
                            col = 0;
                            EqImage.SetPixel(x, y, Color.FromArgb(col, col, col));
                        }
                    }
                        
                }
            target.pictureBox1.Image = EqImage;
            aktualizujHist();
        }
          */
        public void EqMy()
        {
            int width = target.pictureBox1.Image.Width;
            int height = target.pictureBox1.Image.Height;
            Bitmap EqImage = new Bitmap(width, height);
            Bitmap Obraz = new Bitmap(target.pictureBox1.Image);
            
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;

            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(Histogram.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += Histogram[i];

                while (hint > havg)
                {

                    hint -= havg;
                    R += 1;
                }
                if (R >= 256) { R = 255; }
                Rz[i] = R;
                LUT[i] = (Rz[i] * Lz[i]) / 2;
                //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            }
            int th;
            for (int x = 0; x < width; x += 1)
                for (int y = 0; y < height; y += 1)
                {
                    c = Obraz.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
                    }
                    th = (int)LUT[r];
                    if (th > 200)
                    {
                        th = 10;
                    }
                    else if (th < 10)
                    {
                        th = 10;
                    }
                    EqImage.SetPixel(x, y, Color.FromArgb(th, th, th));
                }

             target.pictureBox1.Image = EqImage;
            aktualizujHist();
        }

    }
}
