namespace WindowsForms.Unit3
{
    partial class MonkeyBashForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonkeyBashForm));
            this.monkeyPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreGroupBox = new System.Windows.Forms.GroupBox();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox)).BeginInit();
            this.scoreGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // monkeyPictureBox
            // 
            this.monkeyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox.Image")));
            this.monkeyPictureBox.Location = new System.Drawing.Point(66, 47);
            this.monkeyPictureBox.Name = "monkeyPictureBox";
            this.monkeyPictureBox.Size = new System.Drawing.Size(83, 91);
            this.monkeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox.TabIndex = 0;
            this.monkeyPictureBox.TabStop = false;
            this.monkeyPictureBox.Click += new System.EventHandler(this.monkeyPictureBox_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 262);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(146, 262);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(281, 262);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 1000;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // scoreGroupBox
            // 
            this.scoreGroupBox.Controls.Add(this.missesLabel);
            this.scoreGroupBox.Controls.Add(this.hitsLabel);
            this.scoreGroupBox.Location = new System.Drawing.Point(399, 21);
            this.scoreGroupBox.Name = "scoreGroupBox";
            this.scoreGroupBox.Size = new System.Drawing.Size(141, 69);
            this.scoreGroupBox.TabIndex = 4;
            this.scoreGroupBox.TabStop = false;
            this.scoreGroupBox.Text = "Score";
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(25, 21);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(37, 13);
            this.hitsLabel.TabIndex = 0;
            this.hitsLabel.Text = "Hits: 0";
            // 
            // missesLabel
            // 
            this.missesLabel.AutoSize = true;
            this.missesLabel.Location = new System.Drawing.Point(25, 43);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(51, 13);
            this.missesLabel.TabIndex = 1;
            this.missesLabel.Text = "Misses: 0";
            // 
            // MonkeyBashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 297);
            this.Controls.Add(this.scoreGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.monkeyPictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MonkeyBashForm";
            this.Text = "MonkeyBashForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MonkeyBashForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox)).EndInit();
            this.scoreGroupBox.ResumeLayout(false);
            this.scoreGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox monkeyPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.GroupBox scoreGroupBox;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label hitsLabel;
    }
}