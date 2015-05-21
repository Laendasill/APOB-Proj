namespace APOB
{
    partial class Slider
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
            this.SliderBox = new System.Windows.Forms.TrackBar();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SliderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SliderBox
            // 
            this.SliderBox.Location = new System.Drawing.Point(12, 12);
            this.SliderBox.Maximum = 255;
            this.SliderBox.Minimum = 1;
            this.SliderBox.Name = "SliderBox";
            this.SliderBox.Size = new System.Drawing.Size(142, 45);
            this.SliderBox.TabIndex = 0;
            this.SliderBox.Value = 1;
            this.SliderBox.Scroll += new System.EventHandler(this.SliderBox_Scroll);
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(160, 12);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(57, 20);
            this.ValueBox.TabIndex = 1;
            this.ValueBox.Text = "5";
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(223, 12);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 23);
            this.ActionButton.TabIndex = 2;
            this.ActionButton.Text = "Progowanie";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 63);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.SliderBox);
            this.Name = "Slider";
            this.Text = "Slider";
            ((System.ComponentModel.ISupportInitialize)(this.SliderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar SliderBox;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button ActionButton;
    }
}