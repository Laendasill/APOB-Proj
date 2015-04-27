namespace APOB
{
    partial class WHistogram
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
            this.IHistogram = new System.Windows.Forms.PictureBox();
            this.ChannelChooser = new System.Windows.Forms.GroupBox();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.Gray = new System.Windows.Forms.RadioButton();
            this.LPoziom = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.LValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IHistogram)).BeginInit();
            this.ChannelChooser.SuspendLayout();
            this.SuspendLayout();
            // 
            // IHistogram
            // 
            this.IHistogram.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IHistogram.Location = new System.Drawing.Point(0, 0);
            this.IHistogram.Margin = new System.Windows.Forms.Padding(2);
            this.IHistogram.Name = "IHistogram";
            this.IHistogram.Size = new System.Drawing.Size(265, 135);
            this.IHistogram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.IHistogram.TabIndex = 1;
            this.IHistogram.TabStop = false;
            this.IHistogram.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IHistogram_MouseMove);
            // 
            // ChannelChooser
            // 
            this.ChannelChooser.Controls.Add(this.Blue);
            this.ChannelChooser.Controls.Add(this.Green);
            this.ChannelChooser.Controls.Add(this.Red);
            this.ChannelChooser.Controls.Add(this.Gray);
            this.ChannelChooser.Location = new System.Drawing.Point(0, 144);
            this.ChannelChooser.Name = "ChannelChooser";
            this.ChannelChooser.Size = new System.Drawing.Size(265, 40);
            this.ChannelChooser.TabIndex = 2;
            this.ChannelChooser.TabStop = false;
            this.ChannelChooser.Text = "Kanał";
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.Location = new System.Drawing.Point(205, 15);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(46, 17);
            this.Blue.TabIndex = 3;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = true;
            this.Blue.CheckedChanged += new System.EventHandler(this.ChannelFocusChange);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.Location = new System.Drawing.Point(138, 15);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(54, 17);
            this.Green.TabIndex = 2;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = true;
            this.Green.CheckedChanged += new System.EventHandler(this.ChannelFocusChange);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.Location = new System.Drawing.Point(74, 15);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(45, 17);
            this.Red.TabIndex = 1;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.CheckedChanged += new System.EventHandler(this.ChannelFocusChange);
            // 
            // Gray
            // 
            this.Gray.AutoSize = true;
            this.Gray.Checked = true;
            this.Gray.Location = new System.Drawing.Point(8, 15);
            this.Gray.Name = "Gray";
            this.Gray.Size = new System.Drawing.Size(47, 17);
            this.Gray.TabIndex = 0;
            this.Gray.TabStop = true;
            this.Gray.Text = "Gray";
            this.Gray.UseVisualStyleBackColor = true;
            this.Gray.CheckedChanged += new System.EventHandler(this.ChannelFocusChange);
            // 
            // LPoziom
            // 
            this.LPoziom.AutoSize = true;
            this.LPoziom.Location = new System.Drawing.Point(5, 187);
            this.LPoziom.Name = "LPoziom";
            this.LPoziom.Size = new System.Drawing.Size(44, 13);
            this.LPoziom.TabIndex = 3;
            this.LPoziom.Text = "Poziom:";
            // 
            // Level
            // 
            this.Level.BackColor = System.Drawing.SystemColors.Menu;
            this.Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Level.Location = new System.Drawing.Point(47, 187);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(29, 13);
            this.Level.TabIndex = 4;
            this.Level.Text = "0";
            this.Level.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Value
            // 
            this.Value.BackColor = System.Drawing.SystemColors.Menu;
            this.Value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Value.Location = new System.Drawing.Point(47, 202);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(29, 13);
            this.Value.TabIndex = 6;
            this.Value.Text = "0";
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LValue
            // 
            this.LValue.AutoSize = true;
            this.LValue.Location = new System.Drawing.Point(5, 202);
            this.LValue.Name = "LValue";
            this.LValue.Size = new System.Drawing.Size(50, 13);
            this.LValue.TabIndex = 5;
            this.LValue.Text = "Wartość:";
            // 
            // WHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(265, 245);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.LValue);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.LPoziom);
            this.Controls.Add(this.ChannelChooser);
            this.Controls.Add(this.IHistogram);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WHistogram";
            this.Text = "hist";
            ((System.ComponentModel.ISupportInitialize)(this.IHistogram)).EndInit();
            this.ChannelChooser.ResumeLayout(false);
            this.ChannelChooser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IHistogram;
        private System.Windows.Forms.GroupBox ChannelChooser;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.RadioButton Gray;
        private System.Windows.Forms.Label LPoziom;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label LValue;


    }
}