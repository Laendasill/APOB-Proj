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
    public partial class WHistogram : Form
    {
        static int HIST_HEIGHT = 125, HBUF = 5;
        MainWindow parent;
        public long[,] THistogram = new long[4,256];  // histogram w formie tabeli, indeksy 0-R, 1-G, 2-B, 3-grayscale
        Image ActHistImg; // aktualny obraz histogramu dla wybranego ch
        int ch; // aktualny kanal

        public WHistogram(MainWindow par, Image im)
        {
            InitializeComponent();
            parent = par;
            MdiParent = par;
            this.IHistogram.Image = new Bitmap(265, 130);
            UtworzHistogram(im);
        }

        // tworzy histogram dla aktywnego obrazu
        private void UtworzHistogram(Image im)
        {
            Bitmap obraz = new Bitmap(im);

            for (int i = 0; i < obraz.Size.Width; i++)
            {
                for (int j = 0; j < obraz.Size.Height; j++)
                {
                    System.Drawing.Color c = obraz.GetPixel(i, j);

                    double Temp = 0.0;
                    Temp += c.R * 0.2126;
                    Temp += c.G * 0.7152;
                    Temp += c.B * 0.0722;
                    
                    THistogram[0,c.R]++;
                    THistogram[1,c.G]++;
                    THistogram[2,c.B]++;
                    THistogram[3,(int)Temp]++;
                }
            }
            RysujHistogram();
        }

        // zwraca maks ilosc pikseli jednego z kolorow z akt. wybranego kanalu
        private long GetMaxVal(){
            long max=0;
            for (int i = 0; i < 256; i++)
            {
                if (max < THistogram[ch,i]) max = THistogram[ch,i];
            }

            return max;
        }

        private void RysujHistogram(bool MEvent=false, int Mx=0){
            
            Pen col;

            if (Red.Checked) 
            { 
                ch = 0;
                col = Pens.Red;
            }
            else if (Green.Checked) 
            { 
                ch = 1;
                col = Pens.Green;
            }
            else if (Blue.Checked) 
            { 
                ch = 2;
                col = Pens.Blue;
            }
            else 
            {
                ch = 3;
                col = Pens.Black;
            }

            double max = GetMaxVal();   
            
            Bitmap obraz = new Bitmap(265, HIST_HEIGHT+3*HBUF);
            using (Graphics g = Graphics.FromImage(obraz))
            {
                //g.SetClip(new RectangleF(0, 0, 265, 130), System.Drawing.Drawing2D.CombineMode.Replace);
                int BLine = obraz.Height - 2 * HBUF;
                for (int i = 0; i < THistogram.GetLength(1); i++)
                {
                    double pct = THistogram[ch,i] / max;   // What percentage of the max is this value?

                    g.DrawLine(Pens.Black,
                        new Point(5, BLine),
                        new Point(260, BLine)  // Use that percentage of the height
                        );
                    
                    g.DrawLine(col,
                        new Point(i + 5, BLine),
                        new Point(i + 5, BLine - ((int)(pct * HIST_HEIGHT)))  // Use that percentage of the height
                        );
                }

                //g.DrawImage(obraz, new RectangleF(0, 0, 265, HIST_HEIGHT + 2 * HBUF));
            }
            IHistogram.Image = obraz;
            ActHistImg = new Bitmap(obraz);
        }
        
        
        public void EqRnd()
        {
            //int width = target.ImageBox.Image.Width;
            //int height = target.ImageBox.Image.Height;
            //Bitmap EqImage = new Bitmap(width, height);
            //Bitmap Obraz = new Bitmap(target.ImageBox.Image);
            //int R = 0;
            //int[] Lz = new int[256];
            //int[] Rz = new int[256];
            //Color c;
            //int r;
            //long hint = 0;
            
            //double[] LUT = new double[256];
            ////get lowest non zero value

            //long havg = Convert.ToInt64(THistogram.Average());
            //for (int i = 0; i < 255; i += 1)
            //{
            //    Lz[i] = R;
            //    hint += THistogram[i];

            //    while (hint > havg)
            //    {

            //        hint -= havg;
            //        R += 1;
            //    }
            //    if (R >= 256) { R = 255; }
            //    Rz[i] = R;
            //    LUT[i] = Rz[i] - Lz[i];
            //    //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            //}
            //Random rnd = new Random();
            //for (int x = 0; x < width; x += 1)
            //    for (int y = 0; y < height; y += 1)
            //    {
            //        c = Obraz.GetPixel(x,y);
            //        r = (int)c.R;
            //        if (Lz[r] == Rz[r])
            //        {
            //            EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
            //        }
            //        int rn = rnd.Next(Convert.ToInt32(LUT[r]));
            //        EqImage.SetPixel(x, y, Color.FromArgb(Lz[r] + rn, Lz[r] + rn, Lz[r] + rn));
            //    }

            //target.ImageBox.Image = EqImage;
            //UtworzHistogram();
            
        }
        public void EqAvg()
        {
            //int width = target.ImageBox.Image.Width;
            //int height = target.ImageBox.Image.Height;
            //Bitmap EqImage = new Bitmap(width, height);
            //Bitmap Obraz = new Bitmap(target.ImageBox.Image);
            
            //int R = 0;
            //int[] Lz = new int[256];
            //int[] Rz = new int[256];
            //Color c;
            //int r;
            //long hint = 0;
            
            //double[] LUT = new double[256];
            ////get lowest non zero value

            //long havg = Convert.ToInt64(THistogram.Average());
            //for (int i = 0; i < 255; i += 1)
            //{
            //    Lz[i] = R;
            //    hint += THistogram[i];

            //    while (hint > havg)
            //    {

            //        hint -= havg;
            //        R += 1;
            //    }
            //    if (R >= 256) { R = 255; }
            //    Rz[i] = R;
            //    LUT[i] = (Rz[i] + Lz[i]) / 2;
            //    //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            //}
            //for (int x = 0; x < width; x += 1)
            //    for (int y = 0; y < height; y += 1)
            //    {
            //        c = Obraz.GetPixel(x, y);
            //        r = (int)c.R;
            //        if (Lz[r] == Rz[r])
            //        {
            //            EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
            //        }

            //        EqImage.SetPixel(x, y, Color.FromArgb((int)LUT[r], (int)LUT[r], (int)LUT[r]));
            //    }

            //target.ImageBox.Image = EqImage;
            //UtworzHistogram();
        }
        

        // CW 2 progowania i takie tam sprawy
        public void negaion()
        {
            //int width = target.ImageBox.Image.Width;
            //int height = target.ImageBox.Image.Height;
            //Bitmap EqImage = new Bitmap(width, height);
            //Bitmap Obraz = new Bitmap(target.ImageBox.Image);
            //Color c;
            //for (int x = 0; x < width - 1; x += 1)
            //    for (int y = 0; y < height - 1; y += 1)
            //    {
            //       c = Obraz.GetPixel(x, y);

            //       EqImage.SetPixel(x, y, Color.FromArgb(255 - c.R,255 - c.R,255 - c.R));
            //    }
            //target.ImageBox.Image = EqImage;
            //UtworzHistogram();
        }

        public void progowanie()
        {
            //int width = target.ImageBox.Image.Width;
            //int height = target.ImageBox.Image.Height;
            //Bitmap EqImage = new Bitmap(width, height);
            //Bitmap Obraz = new Bitmap(target.ImageBox.Image);
            //int prog = 150;
            //Color c;
            //for (int x = 0; x < width - 1; x += 1)
            //    for (int y = 0; y < height - 1; y += 1)
            //    {
            //        c = Obraz.GetPixel(x, y);
            //        if(c.R > prog){
            //        EqImage.SetPixel(x, y, Color.FromArgb(1,1,1));
            //        }
            //        if(c.R < prog){
            //            EqImage.SetPixel(x, y, Color.FromArgb(0,0,0));
            //        }
            //    }
            //target.ImageBox.Image = EqImage;
            //UtworzHistogram();
        }
        public void reductGrayScale()
        {
            //int width = target.ImageBox.Image.Width;
            //int height = target.ImageBox.Image.Height;
            //Bitmap EqImage = new Bitmap(width, height);
            //Bitmap Obraz = new Bitmap(target.ImageBox.Image);
            //Color c;
            //int col;
            //int[] prog = { 0, 2, 4, 8, 16, 24, 48, 200, 255 };
            //for (int x = 0; x < width - 1; x += 1)
            //    for (int y = 0; y < height - 1; y += 1)
            //    {
            //        c = Obraz.GetPixel(x, y);
            //        for (int i = 0; i < prog.Length; i += 1)
            //        {
            //            if (c.R < prog[i])
            //            {
            //                col = prog[i - 1];
            //                EqImage.SetPixel(x, y, Color.FromArgb(col, col, col));
            //            }
            //            else
            //            {
            //                col = 0;
            //                EqImage.SetPixel(x, y, Color.FromArgb(col, col, col));
            //            }
            //        }
                        
            //    }
            //target.ImageBox.Image = EqImage;
            //UtworzHistogram();
        }
        public void EqMy()
        {
            //int width = target.ImageBox.Image.Width;
            //int height = target.ImageBox.Image.Height;
            //Bitmap EqImage = new Bitmap(width, height);
            //Bitmap Obraz = new Bitmap(target.ImageBox.Image);
            
            //int R = 0;
            //int[] Lz = new int[256];
            //int[] Rz = new int[256];
            //Color c;
            //int r;
            //long hint = 0;

            //double[] LUT = new double[256];
            ////get lowest non zero value

            //long havg = Convert.ToInt64(THistogram.Average());
            //for (int i = 0; i < 255; i += 1)
            //{
            //    Lz[i] = R;
            //    hint += THistogram[i];

            //    while (hint > havg)
            //    {

            //        hint -= havg;
            //        R += 1;
            //    }
            //    if (R >= 256) { R = 255; }
            //    Rz[i] = R;
            //    LUT[i] = (Rz[i] * Lz[i]) / 2;
            //    //Console.WriteLine("Left[{0}] = {1} || Right[{0}] = {2} || Lut[{0}] = {3} || hist = {4} || havg = {5}", i, Lz[i], Rz[i], LUT[i], hist[i], havg);
            //}
            //int th;
            //for (int x = 0; x < width; x += 1)
            //    for (int y = 0; y < height; y += 1)
            //    {
            //        c = Obraz.GetPixel(x, y);
            //        r = (int)c.R;
            //        if (Lz[r] == Rz[r])
            //        {
            //            EqImage.SetPixel(x, y, Color.FromArgb(Lz[r], Lz[r], Lz[r]));
            //        }
            //        th = (int)LUT[r];
            //        if (th > 200)
            //        {
            //            th = 10;
            //        }
            //        else if (th < 10)
            //        {
            //            th = 10;
            //        }
            //        EqImage.SetPixel(x, y, Color.FromArgb(th, th, th));
            //    }

            // target.ImageBox.Image = EqImage;
            //UtworzHistogram();
        }

        private void ChannelFocusChange(object sender, EventArgs e)
        {
            RysujHistogram();
        }

        private void IHistogram_MouseMove(object sender, MouseEventArgs e)
        {
            int Mx = e.X;
            Bitmap tmp = new Bitmap(ActHistImg);

            if (Mx < 5) Mx = 0;
            else if (Mx > 260) Mx = 255;
            else Mx -= 5;
            
            double max = GetMaxVal();
            int BLine = tmp.Height - 2 * HBUF;
            using (Graphics g = Graphics.FromImage(tmp))
            {
                double pct = THistogram[ch, Mx] / max;   // What percentage of the max is this value?

                g.DrawLine(Pens.Sienna,
                        new Point(Mx + 5, BLine),
                        new Point(Mx + 5, BLine - ((int)(pct * HIST_HEIGHT)))  // Use that percentage of the height
                        );       
            }
            IHistogram.Image = tmp;

            Level.Text = Mx.ToString();
            Value.Text = THistogram[ch, Mx].ToString();
        }

    }
}
