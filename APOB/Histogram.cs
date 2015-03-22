using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace APOB
{
    class Histogram
    {
        private long[] hist = new long[256];
        private int width;
        private int heigth;
        private Bitmap img;

        public Histogram(System.Drawing.Bitmap inputimage)
        {
            img = inputimage;
            width = inputimage.Width;
            heigth = inputimage.Height;

            for (int x = 0; x < heigth; x += 1)
            {

                for (int y = 0; y < width; y += 1)
                {

                    System.Drawing.Color color = inputimage.GetPixel(y, x);

                    hist[convertPixel(color)] += 1;
                }
            }
        }
        public Bitmap redo(Bitmap inputimage)
        {
            int width = inputimage.Width;
            int heigth = inputimage.Height;
            int c = 0;
            Bitmap red = new Bitmap(width, heigth);
            for (int x = 0; x < width; x += 1)
            {

                for (int y = 0; y < heigth; y += 1)
                {

                    System.Drawing.Color color = inputimage.GetPixel(x, y);
                    c = convertPixel(color);
                    red.SetPixel(x, y, grayPixel(c));
                }
            }

            return red;
        }
        private int convertPixel(System.Drawing.Color c)
        {
            int lol = (int)(c.A + c.B + c.G) / 3;
            return lol;
        }

        private Color grayPixel(int scale)
        {
            int graycol = scale;
            Color gray = Color.FromArgb(graycol, graycol, graycol);

            return gray;

        }

        private long[] cdfHist()
        {
            long[] t = new long[256];
            t[0] = hist[0];
            for (int i = 1; i < 256; i += 1)
            {

                t[i] = t[i - 1] + hist[i];

            }
            return t;
        }

        public Bitmap EqRnd()
        {
            Bitmap EqImage = new Bitmap(img.Width, img.Height);
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
            long[] cdf = cdfHist();
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(hist.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += hist[i];

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
                for (int y = 0; y < heigth; y += 1)
                {
                    c = img.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, grayPixel(Lz[r]));
                    }
                    int rn = rnd.Next(Convert.ToInt32(LUT[r]));
                    EqImage.SetPixel(x, y, grayPixel(rn+Lz[r]));
                }

            return EqImage;
        }

        // equalize2()
        // Used Variables:
        // hist - (long) histogram for image in Histogram class
        // havg - avrage value in histogram
        // Z - old grayscale levels 
        // R - new grayscale Levels
        // hint - integral of histogram
        // Notes: TODO: first i have to translate old graylevels to new, and then recreate new image

        public Bitmap EqAvg()
        {
            Bitmap EqImage = new Bitmap(img.Width, img.Height);
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
            long[] cdf = cdfHist();
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(hist.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += hist[i];

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
                for (int y = 0; y < heigth; y += 1)
                {
                    c = img.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, grayPixel(Lz[r]));
                    }

                    EqImage.SetPixel(x, y, grayPixel((int)LUT[r]));
                }

            return EqImage;
        }
        public Bitmap NeighAvg()
        {
            Bitmap EqImage = new Bitmap(img.Width, img.Height);
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
            long[] cdf = cdfHist();
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(hist.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += hist[i];

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
            for (int x = 1; x < width -1; x += 1)
                for (int y = 1; y < heigth -1; y += 1)
                {
                    c = img.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, grayPixel(Lz[r]));
                    }
                    l = img.GetPixel(x - 1, y - 1).R;
                    d = img.GetPixel(x + 1, y - 1).R;
                    f = img.GetPixel(x + 1, y + 1).R;
                    u = img.GetPixel(x - 1, y + 1).R;
                    avg = (l + d + f + u) / 4;
                    if (avg > Rz[r])
                    {
                        EqImage.SetPixel(x, y, grayPixel((int)Rz[r]));
                    }
                    else if (avg < Lz[r])
                    {
                        EqImage.SetPixel(x, y, grayPixel((int)Lz[r]));
                    }
                    else
                    {
                        EqImage.SetPixel(x, y, grayPixel(avg));
                    }
                }

            return EqImage;
        }
        // Wlasna metoda eqalizacji
        public Bitmap EqMy()
        {
            Bitmap EqImage = new Bitmap(img.Width, img.Height);
            int R = 0;
            int[] Lz = new int[256];
            int[] Rz = new int[256];
            Color c;
            int r;
            long hint = 0;
           
            double[] LUT = new double[256];
            //get lowest non zero value

            long havg = Convert.ToInt64(hist.Average());
            for (int i = 0; i < 255; i += 1)
            {
                Lz[i] = R;
                hint += hist[i];

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
                for (int y = 0; y < heigth; y += 1)
                {
                    c = img.GetPixel(x, y);
                    r = (int)c.R;
                    if (Lz[r] == Rz[r])
                    {
                        EqImage.SetPixel(x, y, grayPixel(Lz[r]));
                    }
                    th = (int)LUT[r];
                    if (th > 200)
                    {
                        th = 10;
                    } else if(th < 10)
                    {
                        th = 10;
                   }
                    EqImage.SetPixel(x, y, grayPixel(th));
                }

            return EqImage;
        }

        public long[] returnArray()
        {
            return this.hist;
        }

    }
}
