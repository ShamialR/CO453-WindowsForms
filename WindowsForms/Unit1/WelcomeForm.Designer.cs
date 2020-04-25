namespace WindowsForms
{
    partial class WelcomeForm
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
            this.greetingLabel = new System.Windows.Forms.Label();
            this.bragLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.showButton1 = new System.Windows.Forms.Button();
            this.showButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetingLabel
            // 
            this.greetingLabel.BackColor = System.Drawing.Color.Yellow;
            this.greetingLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greetingLabel.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetingLabel.ForeColor = System.Drawing.Color.Blue;
            this.greetingLabel.Location = new System.Drawing.Point(100, 30);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(370, 40);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Welcome to SuperSoft";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bragLabel
            // 
            this.bragLabel.BackColor = System.Drawing.Color.Yellow;
            this.bragLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bragLabel.Font = new System.Drawing.Font("Arial", 16F);
            this.bragLabel.ForeColor = System.Drawing.Color.Blue;
            this.bragLabel.Location = new System.Drawing.Point(100, 107);
            this.bragLabel.Name = "bragLabel";
            this.bragLabel.Size = new System.Drawing.Size(310, 70);
            this.bragLabel.TabIndex = 1;
            this.bragLabel.Text = "The BEST Prices";
            this.bragLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(554, 265);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 35);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitApplication);
            // 
            // showButton1
            // 
            this.showButton1.Font = new System.Drawing.Font("Arial", 16F);
            this.showButton1.Location = new System.Drawing.Point(25, 265);
            this.showButton1.Name = "showButton1";
            this.showButton1.Size = new System.Drawing.Size(200, 35);
            this.showButton1.TabIndex = 3;
            this.showButton1.Text = "Best Computer";
            this.showButton1.UseVisualStyleBackColor = true;
            this.showButton1.Click += new System.EventHandler(this.showBestComputerMessage);
            // 
            // showButton2
            // 
            this.showButton2.Font = new System.Drawing.Font("Arial", 16F);
            this.showButton2.Location = new System.Drawing.Point(279, 265);
            this.showButton2.Name = "showButton2";
            this.showButton2.Size = new System.Drawing.Size(167, 35);
            this.showButton2.TabIndex = 4;
            this.showButton2.Text = "Best Software";
            this.showButton2.UseVisualStyleBackColor = true;
            this.showButton2.Click += new System.EventHandler(this.showBestSoftwareMessage);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(649, 340);
            this.Controls.Add(this.showButton2);
            this.Controls.Add(this.showButton1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.bragLabel);
            this.Controls.Add(this.greetingLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSoft Software Co.";
            this.Load += new System.EventHandler(this.loadWelcomeForm);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label bragLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button showButton1;
        private System.Windows.Forms.Button showButton2;
    }
}

