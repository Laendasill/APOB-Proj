namespace APOB
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MObraz = new System.Windows.Forms.ToolStripMenuItem();
            this.duplikujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konwersjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skalaSzarościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNegacja = new System.Windows.Forms.ToolStripMenuItem();
            this.progowanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redukcjaPoziomówSzarościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MHistogram_Wyrownaj = new System.Windows.Forms.ToolStripMenuItem();
            this.MHistogram_Sasiedztwo = new System.Windows.Forms.ToolStripMenuItem();
            this.wyrównajtestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wrównajWłasnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyrównajLosowoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MOperacje = new System.Windows.Forms.ToolStripMenuItem();
            this.operacjeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.morfologiczneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MErozja = new System.Windows.Forms.ToolStripMenuItem();
            this.MDylatacja = new System.Windows.Forms.ToolStripMenuItem();
            this.MZakmniecie = new System.Windows.Forms.ToolStripMenuItem();
            this.MOtwarcie = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.MObraz,
            this.MOperacje,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.MOtworz_click);
            // 
            // MObraz
            // 
            this.MObraz.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.duplikujToolStripMenuItem,
            this.konwersjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.histogramToolStripMenuItem,
            this.MHistogram_Wyrownaj});
            this.MObraz.Enabled = false;
            this.MObraz.Name = "MObraz";
            this.MObraz.Size = new System.Drawing.Size(50, 20);
            this.MObraz.Text = "Obraz";
            // 
            // duplikujToolStripMenuItem
            // 
            this.duplikujToolStripMenuItem.Name = "duplikujToolStripMenuItem";
            this.duplikujToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.duplikujToolStripMenuItem.Text = "Duplikuj";
            this.duplikujToolStripMenuItem.Click += new System.EventHandler(this.MDuplikuj_click);
            // 
            // konwersjaToolStripMenuItem
            // 
            this.konwersjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skalaSzarościToolStripMenuItem,
            this.MNegacja,
            this.progowanieToolStripMenuItem,
            this.redukcjaPoziomówSzarościToolStripMenuItem});
            this.konwersjaToolStripMenuItem.Name = "konwersjaToolStripMenuItem";
            this.konwersjaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.konwersjaToolStripMenuItem.Text = "Konwertuj";
            // 
            // skalaSzarościToolStripMenuItem
            // 
            this.skalaSzarościToolStripMenuItem.Name = "skalaSzarościToolStripMenuItem";
            this.skalaSzarościToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.skalaSzarościToolStripMenuItem.Text = "Skala szarości";
            this.skalaSzarościToolStripMenuItem.Click += new System.EventHandler(this.MGrayscale_Click);
            // 
            // MNegacja
            // 
            this.MNegacja.Name = "MNegacja";
            this.MNegacja.Size = new System.Drawing.Size(225, 22);
            this.MNegacja.Text = "Negacja";
            this.MNegacja.Click += new System.EventHandler(this.MNegacja_Click);
            // 
            // progowanieToolStripMenuItem
            // 
            this.progowanieToolStripMenuItem.Name = "progowanieToolStripMenuItem";
            this.progowanieToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.progowanieToolStripMenuItem.Text = "Progowanie";
            this.progowanieToolStripMenuItem.Click += new System.EventHandler(this.progowanieToolStripMenuItem_Click);
            // 
            // redukcjaPoziomówSzarościToolStripMenuItem
            // 
            this.redukcjaPoziomówSzarościToolStripMenuItem.Name = "redukcjaPoziomówSzarościToolStripMenuItem";
            this.redukcjaPoziomówSzarościToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.redukcjaPoziomówSzarościToolStripMenuItem.Text = "Redukcja poziomów szarości";
            this.redukcjaPoziomówSzarościToolStripMenuItem.Click += new System.EventHandler(this.redukcjaPoziomówSzarościToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.MHistogram_click);
            // 
            // MHistogram_Wyrownaj
            // 
            this.MHistogram_Wyrownaj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MHistogram_Sasiedztwo,
            this.wyrównajtestToolStripMenuItem,
            this.wrównajWłasnaToolStripMenuItem,
            this.wyrównajLosowoToolStripMenuItem});
            this.MHistogram_Wyrownaj.Name = "MHistogram_Wyrownaj";
            this.MHistogram_Wyrownaj.Size = new System.Drawing.Size(204, 22);
            this.MHistogram_Wyrownaj.Text = "Wyrównanie histogramu";
            // 
            // MHistogram_Sasiedztwo
            // 
            this.MHistogram_Sasiedztwo.Name = "MHistogram_Sasiedztwo";
            this.MHistogram_Sasiedztwo.Size = new System.Drawing.Size(169, 22);
            this.MHistogram_Sasiedztwo.Text = "Sąsiedztwo";
            this.MHistogram_Sasiedztwo.Click += new System.EventHandler(this.MHistogram_Sasiedztwo_Click);
            // 
            // wyrównajtestToolStripMenuItem
            // 
            this.wyrównajtestToolStripMenuItem.Name = "wyrównajtestToolStripMenuItem";
            this.wyrównajtestToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.wyrównajtestToolStripMenuItem.Text = "Wyrównaj Średnia";
            // 
            // wrównajWłasnaToolStripMenuItem
            // 
            this.wrównajWłasnaToolStripMenuItem.Name = "wrównajWłasnaToolStripMenuItem";
            this.wrównajWłasnaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.wrównajWłasnaToolStripMenuItem.Text = "Wrównaj własna";
            // 
            // wyrównajLosowoToolStripMenuItem
            // 
            this.wyrównajLosowoToolStripMenuItem.Name = "wyrównajLosowoToolStripMenuItem";
            this.wyrównajLosowoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.wyrównajLosowoToolStripMenuItem.Text = "Wyrównaj losowo";
            // 
            // MOperacje
            // 
            this.MOperacje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacjeToolStripMenuItem1,
            this.morfologiczneToolStripMenuItem});
            this.MOperacje.Enabled = false;
            this.MOperacje.Name = "MOperacje";
            this.MOperacje.Size = new System.Drawing.Size(66, 20);
            this.MOperacje.Text = "Operacje";
            // 
            // operacjeToolStripMenuItem1
            // 
            this.operacjeToolStripMenuItem1.Name = "operacjeToolStripMenuItem1";
            this.operacjeToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.operacjeToolStripMenuItem1.Text = "Operacje 2pkt.";
            this.operacjeToolStripMenuItem1.Click += new System.EventHandler(this.operacjeToolStripMenuItem1_Click);
            // 
            // morfologiczneToolStripMenuItem
            // 
            this.morfologiczneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MErozja,
            this.MDylatacja,
            this.MZakmniecie,
            this.MOtwarcie});
            this.morfologiczneToolStripMenuItem.Name = "morfologiczneToolStripMenuItem";
            this.morfologiczneToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.morfologiczneToolStripMenuItem.Text = "Morfologiczne";
            // 
            // MErozja
            // 
            this.MErozja.Name = "MErozja";
            this.MErozja.Size = new System.Drawing.Size(152, 22);
            this.MErozja.Text = "Erozja";
            this.MErozja.Click += new System.EventHandler(this.MErozja_Click);
            // 
            // MDylatacja
            // 
            this.MDylatacja.Name = "MDylatacja";
            this.MDylatacja.Size = new System.Drawing.Size(152, 22);
            this.MDylatacja.Text = "Dylatacja";
            this.MDylatacja.Click += new System.EventHandler(this.MDylatacja_Click);
            // 
            // MZakmniecie
            // 
            this.MZakmniecie.Name = "MZakmniecie";
            this.MZakmniecie.Size = new System.Drawing.Size(152, 22);
            this.MZakmniecie.Text = "Zamkniecie";
            this.MZakmniecie.Click += new System.EventHandler(this.MZakmniecie_Click);
            // 
            // MOtwarcie
            // 
            this.MOtwarcie.Name = "MOtwarcie";
            this.MOtwarcie.Size = new System.Drawing.Size(152, 22);
            this.MOtwarcie.Text = "Otwarcie";
            this.MOtwarcie.Click += new System.EventHandler(this.MOtwarcie_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.MAbout_click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(754, 431);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "ImageEditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MObraz;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konwersjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skalaSzarościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progowanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redukcjaPoziomówSzarościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MHistogram_Wyrownaj;
        private System.Windows.Forms.ToolStripMenuItem MHistogram_Sasiedztwo;
        private System.Windows.Forms.ToolStripMenuItem wyrównajtestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wrównajWłasnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyrównajLosowoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplikujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNegacja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem operacjeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem morfologiczneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MErozja;
        private System.Windows.Forms.ToolStripMenuItem MDylatacja;
        private System.Windows.Forms.ToolStripMenuItem MZakmniecie;
        private System.Windows.Forms.ToolStripMenuItem MOtwarcie;
        public System.Windows.Forms.ToolStripMenuItem MOperacje;
    }
}

