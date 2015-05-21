namespace APOB
{
    partial class treshold
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
            this.ValueBox = new System.Windows.Forms.TextBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(12, 12);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(47, 20);
            this.ValueBox.TabIndex = 0;
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(139, 9);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 23);
            this.ActionButton.TabIndex = 1;
            this.ActionButton.Text = "Progowanie";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(65, 12);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(47, 20);
            this.Value2.TabIndex = 2;
            // 
            // treshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 40);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.ValueBox);
            this.Name = "treshold";
            this.Text = "treshold";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.TextBox Value2;
    }
}