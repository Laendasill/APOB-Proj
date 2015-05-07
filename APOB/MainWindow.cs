﻿using System;
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
        // lista okien z obrazami
        public List<WImage> WIList = new List<WImage>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // pobranie ref. na okno z obrazem
        private WImage GetWImage() 
        {
            if (this.ActiveMdiChild is WImage)
            {
                return (WImage)this.ActiveMdiChild;
            }
            return null;
        }

        // Wczytanie obrazu
        private void MOtworz_click(object sender, EventArgs e)
        {
            OpenFileDialog FileChoose = new OpenFileDialog();
            FileChoose.Filter = "Bitmap (*.bmp)|*.bmp|JPEG (*.jpg)|*.jpg|TIFF(*.tiff)|*.tiff";
            if (FileChoose.ShowDialog() == DialogResult.OK)
            {
                Image im = new Bitmap(Image.FromFile(FileChoose.FileName));
                //string s = FileChoose.FileName;
                new WImage(this, FileChoose.FileName, im).Show();
            }
        }

        // Okienko z informacjami o tworcach
        private void MAbout_click(object sender, EventArgs e)
        {
            new about().ShowDialog();
        }

        // utworzenie histogramu dla aktywnego okna z obrazem
        private void MHistogram_click(object sender, EventArgs e)
        {
            new WHistogram(this,GetWImage().IBox.Image).Show();
        }

        // konwersja na skale szarosci
        private void MGrayscale_Click(object sender, EventArgs e)
        {
            GetWImage().toGrayscale();
        }

        // Wyrównywanie 
        private void wyrównajtestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WHistogram)
            {
                WHistogram a = (WHistogram)this.ActiveMdiChild;
               
                a.EqAvg();
            }

        }

        private void wyrównajLosowoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WHistogram)
            {
                WHistogram a = (WHistogram)this.ActiveMdiChild;
               
                a.EqRnd();
            }

        }

        private void wrównajWłasnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WHistogram)
            {
                WHistogram a = (WHistogram)this.ActiveMdiChild;

                a.EqMy();
            }

        }

        private void progowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WHistogram)
            {
                WHistogram a = (WHistogram)this.ActiveMdiChild;

                a.progowanie();
            }

        }

<<<<<<< HEAD
        private void progowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WImage)
            {
                Slider f = new Slider((WImage)this.ActiveMdiChild);
                f.Show();
               // WImage a = (WImage)this.ActiveMdiChild;
               // a.progowanie();
            }
=======
        private void redukcjaPoziomówSzarościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is WHistogram)
            {
                WHistogram a = (WHistogram)this.ActiveMdiChild;

                a.reductGrayScale();
            }

        }

        // duplikowanie obrazu
        private void MDuplikuj_click(object sender, EventArgs e)
        {
            new WImage(this, GetWImage().Text + "-Kopia", GetWImage().IBox.Image).Show();
        }

        private void operacjeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Operations2point(this).ShowDialog();
        }

>>>>>>> FETCH_HEAD

        // wyrownanie histogramu metoda sasiedztwa
        private void MHistogram_Sasiedztwo_Click(object sender, EventArgs e)
        {
            GetWImage().HistogramWyrownaj(1);
        }

        private void MErozja_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (this.ActiveMdiChild is WImage)
            {
               
                Posterize a = new Posterize( (WImage)this.ActiveMdiChild);
                a.Show();
                
            }
=======
            GetWImage().erozja(true);
        }

        private void MDylatacja_Click(object sender, EventArgs e)
        {
            GetWImage().dylatacja(true);
        }
>>>>>>> FETCH_HEAD

        private void MOtwarcie_Click(object sender, EventArgs e)
        {
            GetWImage().otwarcie(true);
        }

        private void MZakmniecie_Click(object sender, EventArgs e)
        {
            GetWImage().zamkniecie(true);
        }

        private void MNegacja_Click(object sender, EventArgs e)
        {
            GetWImage().negacja();
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

