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
    public partial class MainWindow : Form
    {
        public List<WImage> WIList = new List<WImage>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Wczytanie obrazu
        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileChoose = new OpenFileDialog();
            FileChoose.Filter = "Bitmapa (*.bmp)|*.bmp";
            if (FileChoose.ShowDialog() == DialogResult.OK)
            {
                WImage pom = new WImage(this);
                pom.Text = FileChoose.FileName;
                pom.pictureBox1.Image = Image.FromFile(FileChoose.FileName);
                pom.MdiParent = this;
                WIList.Add(pom);
                pom.Show();
            }
        }

        // wyswietla informacje o programie i tworcach
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about informacja = new about();
            informacja.ShowDialog();
        }

        // utworzenie histogramu dla aktywnego okna z obrazem
        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                WImage a = (WImage)this.ActiveMdiChild;
                hist H = new hist(this,a);
                H.MdiParent = this;
                H.Show();
            }


        }

        // ustawia czy dane opcje sa w aktualnej chwili dostepne
        private void obrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                this.histogramToolStripMenuItem.Enabled = true;
            }
            else this.histogramToolStripMenuItem.Enabled = false;
        }

        private void operacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                this.histogramToolStripMenuItem.Enabled = true;
            }
            else this.histogramToolStripMenuItem.Enabled = false;
        }

        private void skalaSzarościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                WImage a = (WImage)this.ActiveMdiChild;
                a.toGrayscale();
            }
        }
        // Wyrównywanie 
        private void wyrównajtestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is hist)
            {
                hist a = (hist)this.ActiveMdiChild;
               
                a.EqAvg();
            }

        }

        private void wyrównajLosowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is hist)
            {
                hist a = (hist)this.ActiveMdiChild;
               
                
                a.EqRnd();
            }

        }

        private void wyrównajSąsiadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is hist)
            {
                hist a = (hist)this.ActiveMdiChild;

                a.NeighAvg();
            }

        }

        private void wrównajWłasnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is hist)
            {
                hist a = (hist)this.ActiveMdiChild;

                a.EqMy();
            }

        }

        private void progowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                Slider f = new Slider((WImage)this.ActiveMdiChild);
                f.Show();
               // WImage a = (WImage)this.ActiveMdiChild;
               // a.progowanie();
            }

        }

        private void redukcjaPoziomówSzarościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
               
                Posterize a = new Posterize( (WImage)this.ActiveMdiChild);
                a.Show();
                
            }

        }

        private void duplikujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                WImage a = (WImage)this.ActiveMdiChild,
                    b = new WImage(this);

                b.Text = a.Text + " - Kopia";
                b.pictureBox1.Image = new Bitmap(a.pictureBox1.Image);            
                b.MdiParent = this;
                WIList.Add(b);
                b.Show();
            }
        }

        private void operacjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Operations2point w = new Operations2point(this);
            w.ShowDialog();
        }

        private void negacjaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                WImage a = (WImage)this.ActiveMdiChild;
                a.negaion();
            }
        }
    }
}

