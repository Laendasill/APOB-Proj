namespace APOB
{
    partial class Posterize
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
            this.Action = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ValueBox
            // 
            this.ValueBox.Location = new System.Drawing.Point(12, 12);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(60, 20);
            this.ValueBox.TabIndex = 0;
            this.ValueBox.Text = "1";
            // 
            // Action
            // 
            this.Action.Location = new System.Drawing.Point(78, 12);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(75, 23);
            this.Action.TabIndex = 1;
            this.Action.Text = "Redukuj ";
            this.Action.UseVisualStyleBackColor = true;
            this.Action.Click += new System.EventHandler(this.Action_Click);
            // 
            // Posterize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 44);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.ValueBox);
            this.Name = "Posterize";
            this.Text = "Posterize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValueBox;
        private System.Windows.Forms.Button Action;
    }
}