namespace WindowsForms.Unit1
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.clickForCalcLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickForCalcLabel
            // 
            this.clickForCalcLabel.AutoSize = true;
            this.clickForCalcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.clickForCalcLabel.Location = new System.Drawing.Point(92, 36);
            this.clickForCalcLabel.Name = "clickForCalcLabel";
            this.clickForCalcLabel.Size = new System.Drawing.Size(204, 24);
            this.clickForCalcLabel.TabIndex = 0;
            this.clickForCalcLabel.Text = "Click To Use Calculator";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.clickForCalcLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Click += new System.EventHandler(this.SplashForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickForCalcLabel;
    }
}