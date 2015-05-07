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
            this.Action = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.SlideBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.SlideBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(192, 25);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(75, 23);
            this.Action.TabIndex = 0;
            this.Action.Text = "Progowanie";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(146, 25);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(40, 20);
            this.ValueBox.TabIndex = 1;
            // 
            // SlideBar
            // 
            this.SlideBar.Location = new System.Drawing.Point(12, 12);
            this.SlideBar.Maximum = 255;
            this.SlideBar.Name = "SlideBar";
            this.SlideBar.Size = new System.Drawing.Size(128, 45);
            this.SlideBar.TabIndex = 2;
            this.SlideBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 73);
            this.Controls.Add(this.SlideBar);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.Action);
            this.Name = "Slider";
            this.Text = "Slider";
            ((System.ComponentModel.ISupportInitialize)(this.SlideBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Action;
        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.TrackBar SlideBar;
    }
}