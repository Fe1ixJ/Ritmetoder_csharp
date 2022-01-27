namespace Ritmetoder
{
    partial class Form1
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
            this.labelRäkna = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRäkna
            // 
            this.labelRäkna.AutoSize = true;
            this.labelRäkna.Location = new System.Drawing.Point(478, 22);
            this.labelRäkna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRäkna.Name = "labelRäkna";
            this.labelRäkna.Size = new System.Drawing.Size(19, 13);
            this.labelRäkna.TabIndex = 0;
            this.labelRäkna.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.labelRäkna);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRäkna;
    }
}

