namespace APOB
{
    partial class WImage
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
            this.IBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IBox)).BeginInit();
            this.SuspendLayout();
            // 
            // IBox
            // 
            this.IBox.BackColor = System.Drawing.Color.White;
            this.IBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.IBox.Location = new System.Drawing.Point(0, 0);
            this.IBox.Margin = new System.Windows.Forms.Padding(2);
            this.IBox.Name = "IBox";
            this.IBox.Size = new System.Drawing.Size(50, 50);
            this.IBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IBox.TabIndex = 0;
            this.IBox.TabStop = false;
            // 
            // WImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(120, 66);
            this.Controls.Add(this.IBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(132, 105);
            this.Name = "WImage";
            this.ShowIcon = false;
            this.Text = "WImage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WImage_FormClosed);
            this.Enter += new System.EventHandler(this.WImage_Enter);
            this.Leave += new System.EventHandler(this.WImage_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.IBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox IBox;

    }
}