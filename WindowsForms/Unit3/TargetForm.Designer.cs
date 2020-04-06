namespace WindowsForms.Unit3
{
    partial class TargetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TargetForm));
            this.targetPictureBox = new System.Windows.Forms.PictureBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreMessageLbel = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).BeginInit();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetPictureBox
            // 
            this.targetPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("targetPictureBox.Image")));
            this.targetPictureBox.Location = new System.Drawing.Point(119, 66);
            this.targetPictureBox.Name = "targetPictureBox";
            this.targetPictureBox.Size = new System.Drawing.Size(100, 100);
            this.targetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPictureBox.TabIndex = 0;
            this.targetPictureBox.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(32, 308);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(83, 28);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(210, 308);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(83, 28);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(402, 308);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(83, 28);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.scoreLabel);
            this.resultGroupBox.Controls.Add(this.scoreMessageLbel);
            this.resultGroupBox.Location = new System.Drawing.Point(444, 38);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(185, 104);
            this.resultGroupBox.TabIndex = 4;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // scoreLabel
            // 
            this.scoreLabel.Location = new System.Drawing.Point(6, 63);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(156, 29);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreMessageLbel
            // 
            this.scoreMessageLbel.Location = new System.Drawing.Point(6, 16);
            this.scoreMessageLbel.Name = "scoreMessageLbel";
            this.scoreMessageLbel.Size = new System.Drawing.Size(156, 29);
            this.scoreMessageLbel.TabIndex = 0;
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // TargetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 355);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.targetPictureBox);
            this.Name = "TargetForm";
            this.Text = "Hit The Target";
            ((System.ComponentModel.ISupportInitialize)(this.targetPictureBox)).EndInit();
            this.resultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox targetPictureBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreMessageLbel;
        private System.Windows.Forms.Timer animationTimer;
    }
}