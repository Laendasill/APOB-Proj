namespace APOB
{
    partial class about
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
            this.Nazwa = new System.Windows.Forms.Label();
            this.Wersja = new System.Windows.Forms.Label();
            this.autorzy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwa.Location = new System.Drawing.Point(2, 3);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(186, 40);
            this.Nazwa.TabIndex = 0;
            this.Nazwa.Text = "ImageEditor";
            // 
            // Wersja
            // 
            this.Wersja.AutoSize = true;
            this.Wersja.Location = new System.Drawing.Point(3, 36);
            this.Wersja.Name = "Wersja";
            this.Wersja.Size = new System.Drawing.Size(138, 17);
            this.Wersja.TabIndex = 1;
            this.Wersja.Text = "Wersja: 0.1 [@2015]";
            // 
            // autorzy
            // 
            this.autorzy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.autorzy.Location = new System.Drawing.Point(170, 75);
            this.autorzy.Name = "autorzy";
            this.autorzy.Size = new System.Drawing.Size(70, 23);
            this.autorzy.TabIndex = 2;
            this.autorzy.Text = "Autorzy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paweł Ptaszkiewicz\r\nWojciech Bińka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 132);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autorzy);
            this.Controls.Add(this.Wersja);
            this.Controls.Add(this.Nazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "about";
            this.Text = "about";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Label Wersja;
        private System.Windows.Forms.Label autorzy;
        private System.Windows.Forms.Label label1;
    }
}