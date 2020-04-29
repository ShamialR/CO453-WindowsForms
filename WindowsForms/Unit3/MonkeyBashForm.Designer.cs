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
            this.monkeyPictureBox1 = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.animationTimer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreGroupBox = new System.Windows.Forms.GroupBox();
            this.missesLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.animationTimer2 = new System.Windows.Forms.Timer(this.components);
            this.animationTimer3 = new System.Windows.Forms.Timer(this.components);
            this.animationTimer4 = new System.Windows.Forms.Timer(this.components);
            this.animationTimer5 = new System.Windows.Forms.Timer(this.components);
            this.monkeyPictureBox2 = new System.Windows.Forms.PictureBox();
            this.monkeyPictureBox3 = new System.Windows.Forms.PictureBox();
            this.monkeyPictureBox4 = new System.Windows.Forms.PictureBox();
            this.monkeyPictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox1)).BeginInit();
            this.scoreGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // monkeyPictureBox1
            // 
            this.monkeyPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox1.Image")));
            this.monkeyPictureBox1.Location = new System.Drawing.Point(66, 47);
            this.monkeyPictureBox1.Name = "monkeyPictureBox1";
            this.monkeyPictureBox1.Size = new System.Drawing.Size(83, 91);
            this.monkeyPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox1.TabIndex = 0;
            this.monkeyPictureBox1.TabStop = false;
            this.monkeyPictureBox1.Click += new System.EventHandler(this.hitMonkey1);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(26, 405);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startGame);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(193, 405);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopGame);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(553, 405);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitApplication);
            // 
            // animationTimer1
            // 
            this.animationTimer1.Interval = 1000;
            this.animationTimer1.Tick += new System.EventHandler(this.moveMonkey1);
            // 
            // scoreGroupBox
            // 
            this.scoreGroupBox.Controls.Add(this.missesLabel);
            this.scoreGroupBox.Controls.Add(this.hitsLabel);
            this.scoreGroupBox.Location = new System.Drawing.Point(487, 43);
            this.scoreGroupBox.Name = "scoreGroupBox";
            this.scoreGroupBox.Size = new System.Drawing.Size(141, 69);
            this.scoreGroupBox.TabIndex = 4;
            this.scoreGroupBox.TabStop = false;
            this.scoreGroupBox.Text = "Score";
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
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Location = new System.Drawing.Point(25, 21);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(37, 13);
            this.hitsLabel.TabIndex = 0;
            this.hitsLabel.Text = "Hits: 0";
            // 
            // animationTimer2
            // 
            this.animationTimer2.Interval = 1000;
            this.animationTimer2.Tick += new System.EventHandler(this.moveMonkey2);
            // 
            // animationTimer3
            // 
            this.animationTimer3.Interval = 1000;
            this.animationTimer3.Tick += new System.EventHandler(this.moveMonkey3);
            // 
            // animationTimer4
            // 
            this.animationTimer4.Interval = 1000;
            this.animationTimer4.Tick += new System.EventHandler(this.moveMonkey4);
            // 
            // animationTimer5
            // 
            this.animationTimer5.Interval = 1000;
            this.animationTimer5.Tick += new System.EventHandler(this.moveMonkey5);
            // 
            // monkeyPictureBox2
            // 
            this.monkeyPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox2.Image")));
            this.monkeyPictureBox2.Location = new System.Drawing.Point(317, 237);
            this.monkeyPictureBox2.Name = "monkeyPictureBox2";
            this.monkeyPictureBox2.Size = new System.Drawing.Size(83, 91);
            this.monkeyPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox2.TabIndex = 5;
            this.monkeyPictureBox2.TabStop = false;
            this.monkeyPictureBox2.Click += new System.EventHandler(this.hitMonkey2);
            // 
            // monkeyPictureBox3
            // 
            this.monkeyPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox3.Image")));
            this.monkeyPictureBox3.Location = new System.Drawing.Point(37, 267);
            this.monkeyPictureBox3.Name = "monkeyPictureBox3";
            this.monkeyPictureBox3.Size = new System.Drawing.Size(83, 91);
            this.monkeyPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox3.TabIndex = 6;
            this.monkeyPictureBox3.TabStop = false;
            this.monkeyPictureBox3.Click += new System.EventHandler(this.hitMnkey3);
            // 
            // monkeyPictureBox4
            // 
            this.monkeyPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox4.Image")));
            this.monkeyPictureBox4.Location = new System.Drawing.Point(246, 86);
            this.monkeyPictureBox4.Name = "monkeyPictureBox4";
            this.monkeyPictureBox4.Size = new System.Drawing.Size(83, 91);
            this.monkeyPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox4.TabIndex = 7;
            this.monkeyPictureBox4.TabStop = false;
            this.monkeyPictureBox4.Click += new System.EventHandler(this.hitMonkey4);
            // 
            // monkeyPictureBox5
            // 
            this.monkeyPictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("monkeyPictureBox5.Image")));
            this.monkeyPictureBox5.Location = new System.Drawing.Point(515, 267);
            this.monkeyPictureBox5.Name = "monkeyPictureBox5";
            this.monkeyPictureBox5.Size = new System.Drawing.Size(83, 91);
            this.monkeyPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monkeyPictureBox5.TabIndex = 8;
            this.monkeyPictureBox5.TabStop = false;
            this.monkeyPictureBox5.Click += new System.EventHandler(this.hitMonkey5);
            // 
            // MonkeyBashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(662, 460);
            this.Controls.Add(this.monkeyPictureBox5);
            this.Controls.Add(this.monkeyPictureBox4);
            this.Controls.Add(this.monkeyPictureBox3);
            this.Controls.Add(this.monkeyPictureBox2);
            this.Controls.Add(this.scoreGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.monkeyPictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MonkeyBashForm";
            this.Text = "MonkeyBashForm";
            this.Load += new System.EventHandler(this.loadMonkeyForm);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.missMonkey);
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox1)).EndInit();
            this.scoreGroupBox.ResumeLayout(false);
            this.scoreGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyPictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox monkeyPictureBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Timer animationTimer1;
        private System.Windows.Forms.GroupBox scoreGroupBox;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Timer animationTimer2;
        private System.Windows.Forms.Timer animationTimer3;
        private System.Windows.Forms.Timer animationTimer4;
        private System.Windows.Forms.Timer animationTimer5;
        private System.Windows.Forms.PictureBox monkeyPictureBox2;
        private System.Windows.Forms.PictureBox monkeyPictureBox3;
        private System.Windows.Forms.PictureBox monkeyPictureBox4;
        private System.Windows.Forms.PictureBox monkeyPictureBox5;
    }
}