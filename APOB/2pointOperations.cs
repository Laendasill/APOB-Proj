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
    public partial class Operations2point : Form
    {
        MainWindow parent;

        public Operations2point( MainWindow p)
        {
            InitializeComponent();
            parent = p;

            foreach(WImage cw in parent.WIList)
            {
                comboBox1.Items.Add(cw.Text);
                comboBox2.Items.Add(cw.Text);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            operacja.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WImage a = parent.WIList.Find(WImage => WImage.Text==comboBox1.SelectedItem.ToString()),
                   b = parent.WIList.Find(WImage => WImage.Text==comboBox2.SelectedItem.ToString());

            logOP((Bitmap)a.IBox.Image, (Bitmap)b.IBox.Image, operacja.SelectedItem.ToString());
            this.Close();
        }

        void logOP(Bitmap a, Bitmap b, string s)
        {

            int h = a.Height,
                w = a.Width;

            if (h < b.Height) h = b.Height;
            if (w < b.Width) w = b.Width;

            Bitmap pom = new Bitmap(w, h);
        
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    if (x >= a.Width || y>=a.Height) pom.SetPixel(x, y, b.GetPixel(x, y));
                    else if (x >= b.Width || y >= b.Height) pom.SetPixel(x, y, a.GetPixel(x, y));
                    else
                    {
                        Color Ap = a.GetPixel(x, y),
                              Bp = b.GetPixel(x, y);

                        int R=0, G=0, B=0;

                        if(s=="ADD")
                        {
                            R = (Ap.R + Bp.R)%256;
                            G = (Ap.G + Bp.G)%256;
                            B = (Ap.B + Bp.B)%256;
                        }
                        else if (s == "SUB")
                        {
                            R = Ap.R - Bp.R;
                            G = Ap.G - Bp.G;
                            B = Ap.B - Bp.B;

                            if (R < 0) R = 0;
                            if (G < 0) G = 0;
                            if (B < 0) B = 0;
                        } 
                        else if(s == "AND"){
                            R = Ap.R & Bp.R;
                            G = Ap.G & Bp.G;
                            B = Ap.B & Bp.B;
                        } 
                        else if(s == "OR"){
                            R = Ap.R | Bp.R;
                            G = Ap.G | Bp.G;
                            B = Ap.B | Bp.B;
                        } 
                        else if(s == "XOR"){
                            R = Ap.R ^ Bp.R;
                            G = Ap.G ^ Bp.G;
                            B = Ap.B ^ Bp.B;
                        }

                        pom.SetPixel(x, y, Color.FromArgb(R,G,B));
                    }
                }
            }

            new WImage(parent,s,pom).Show();
        
        }
    }
}
