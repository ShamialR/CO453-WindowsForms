namespace WindowsForms.Unit1
{
    partial class QuitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitForm));
            this.thanksCalculatorButton = new System.Windows.Forms.Label();
            this.clickToExitButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // thanksCalculatorButton
            // 
            this.thanksCalculatorButton.AutoSize = true;
            this.thanksCalculatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.thanksCalculatorButton.Location = new System.Drawing.Point(28, 19);
            this.thanksCalculatorButton.Name = "thanksCalculatorButton";
            this.thanksCalculatorButton.Size = new System.Drawing.Size(462, 31);
            this.thanksCalculatorButton.TabIndex = 0;
            this.thanksCalculatorButton.Text = "Thank You For Using The Calculator!";
            // 
            // clickToExitButton
            // 
            this.clickToExitButton.AutoSize = true;
            this.clickToExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.clickToExitButton.Location = new System.Drawing.Point(370, 220);
            this.clickToExitButton.Name = "clickToExitButton";
            this.clickToExitButton.Size = new System.Drawing.Size(119, 24);
            this.clickToExitButton.TabIndex = 1;
            this.clickToExitButton.Text = "Click To Exit!";
            // 
            // QuitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.clickToExitButton);
            this.Controls.Add(this.thanksCalculatorButton);
            this.Name = "QuitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuitForm";
            this.Click += new System.EventHandler(this.QuitForm_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label thanksCalculatorButton;
        private System.Windows.Forms.Label clickToExitButton;
    }
}