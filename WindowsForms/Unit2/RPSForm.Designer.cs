namespace WindowsForms.Unit2
{
    partial class RPSForm
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
            this.userChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.computerChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.rockRadioButton = new System.Windows.Forms.RadioButton();
            this.paperRadioButton = new System.Windows.Forms.RadioButton();
            this.scissorsRadioButton = new System.Windows.Forms.RadioButton();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.userScoreTextLabel = new System.Windows.Forms.Label();
            this.computerScoreTextLabel = new System.Windows.Forms.Label();
            this.userScoreLabel = new System.Windows.Forms.Label();
            this.computerScoreLabel = new System.Windows.Forms.Label();
            this.userChoiceGroupBox.SuspendLayout();
            this.computerChoiceGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userChoiceGroupBox
            // 
            this.userChoiceGroupBox.Controls.Add(this.userPictureBox);
            this.userChoiceGroupBox.Controls.Add(this.scissorsRadioButton);
            this.userChoiceGroupBox.Controls.Add(this.paperRadioButton);
            this.userChoiceGroupBox.Controls.Add(this.rockRadioButton);
            this.userChoiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userChoiceGroupBox.Location = new System.Drawing.Point(12, 16);
            this.userChoiceGroupBox.Name = "userChoiceGroupBox";
            this.userChoiceGroupBox.Size = new System.Drawing.Size(218, 422);
            this.userChoiceGroupBox.TabIndex = 0;
            this.userChoiceGroupBox.TabStop = false;
            this.userChoiceGroupBox.Text = "User Choice";
            // 
            // computerChoiceGroupBox
            // 
            this.computerChoiceGroupBox.Controls.Add(this.playButton);
            this.computerChoiceGroupBox.Controls.Add(this.computerPictureBox);
            this.computerChoiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.computerChoiceGroupBox.Location = new System.Drawing.Point(279, 16);
            this.computerChoiceGroupBox.Name = "computerChoiceGroupBox";
            this.computerChoiceGroupBox.Size = new System.Drawing.Size(218, 422);
            this.computerChoiceGroupBox.TabIndex = 1;
            this.computerChoiceGroupBox.TabStop = false;
            this.computerChoiceGroupBox.Text = "Computer Choice";
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.computerScoreLabel);
            this.resultGroupBox.Controls.Add(this.userScoreLabel);
            this.resultGroupBox.Controls.Add(this.computerScoreTextLabel);
            this.resultGroupBox.Controls.Add(this.userScoreTextLabel);
            this.resultGroupBox.Controls.Add(this.resultLabel);
            this.resultGroupBox.Controls.Add(this.quitButton);
            this.resultGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultGroupBox.Location = new System.Drawing.Point(552, 16);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(218, 422);
            this.resultGroupBox.TabIndex = 1;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Result";
            // 
            // rockRadioButton
            // 
            this.rockRadioButton.AutoSize = true;
            this.rockRadioButton.Location = new System.Drawing.Point(42, 252);
            this.rockRadioButton.Name = "rockRadioButton";
            this.rockRadioButton.Size = new System.Drawing.Size(64, 24);
            this.rockRadioButton.TabIndex = 0;
            this.rockRadioButton.TabStop = true;
            this.rockRadioButton.Text = "Rock";
            this.rockRadioButton.UseVisualStyleBackColor = true;
            this.rockRadioButton.CheckedChanged += new System.EventHandler(this.rockRadioButton_CheckedChanged);
            // 
            // paperRadioButton
            // 
            this.paperRadioButton.AutoSize = true;
            this.paperRadioButton.Location = new System.Drawing.Point(42, 298);
            this.paperRadioButton.Name = "paperRadioButton";
            this.paperRadioButton.Size = new System.Drawing.Size(69, 24);
            this.paperRadioButton.TabIndex = 1;
            this.paperRadioButton.TabStop = true;
            this.paperRadioButton.Text = "Paper";
            this.paperRadioButton.UseVisualStyleBackColor = true;
            this.paperRadioButton.CheckedChanged += new System.EventHandler(this.paperRadioButton_CheckedChanged);
            // 
            // scissorsRadioButton
            // 
            this.scissorsRadioButton.AutoSize = true;
            this.scissorsRadioButton.Location = new System.Drawing.Point(42, 341);
            this.scissorsRadioButton.Name = "scissorsRadioButton";
            this.scissorsRadioButton.Size = new System.Drawing.Size(87, 24);
            this.scissorsRadioButton.TabIndex = 2;
            this.scissorsRadioButton.TabStop = true;
            this.scissorsRadioButton.Text = "Scissors";
            this.scissorsRadioButton.UseVisualStyleBackColor = true;
            this.scissorsRadioButton.CheckedChanged += new System.EventHandler(this.scissorsRadioButton_CheckedChanged);
            // 
            // userPictureBox
            // 
            this.userPictureBox.Location = new System.Drawing.Point(13, 41);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(190, 188);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 3;
            this.userPictureBox.TabStop = false;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(13, 41);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(190, 188);
            this.computerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.computerPictureBox.TabIndex = 4;
            this.computerPictureBox.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(13, 318);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(188, 71);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(14, 318);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(188, 71);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.resultLabel.Location = new System.Drawing.Point(14, 45);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(188, 119);
            this.resultLabel.TabIndex = 7;
            // 
            // userScoreTextLabel
            // 
            this.userScoreTextLabel.AutoSize = true;
            this.userScoreTextLabel.Location = new System.Drawing.Point(16, 183);
            this.userScoreTextLabel.Name = "userScoreTextLabel";
            this.userScoreTextLabel.Size = new System.Drawing.Size(97, 20);
            this.userScoreTextLabel.TabIndex = 8;
            this.userScoreTextLabel.Text = "User Score: ";
            // 
            // computerScoreTextLabel
            // 
            this.computerScoreTextLabel.AutoSize = true;
            this.computerScoreTextLabel.Location = new System.Drawing.Point(17, 239);
            this.computerScoreTextLabel.Name = "computerScoreTextLabel";
            this.computerScoreTextLabel.Size = new System.Drawing.Size(133, 20);
            this.computerScoreTextLabel.TabIndex = 9;
            this.computerScoreTextLabel.Text = "Computer Score: ";
            // 
            // userScoreLabel
            // 
            this.userScoreLabel.AutoSize = true;
            this.userScoreLabel.Location = new System.Drawing.Point(17, 209);
            this.userScoreLabel.Name = "userScoreLabel";
            this.userScoreLabel.Size = new System.Drawing.Size(0, 20);
            this.userScoreLabel.TabIndex = 10;
            // 
            // computerScoreLabel
            // 
            this.computerScoreLabel.AutoSize = true;
            this.computerScoreLabel.Location = new System.Drawing.Point(17, 269);
            this.computerScoreLabel.Name = "computerScoreLabel";
            this.computerScoreLabel.Size = new System.Drawing.Size(0, 20);
            this.computerScoreLabel.TabIndex = 11;
            // 
            // RPSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.computerChoiceGroupBox);
            this.Controls.Add(this.userChoiceGroupBox);
            this.Name = "RPSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPSForm";
            this.Load += new System.EventHandler(this.RPSForm_Load);
            this.userChoiceGroupBox.ResumeLayout(false);
            this.userChoiceGroupBox.PerformLayout();
            this.computerChoiceGroupBox.ResumeLayout(false);
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userChoiceGroupBox;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.RadioButton scissorsRadioButton;
        private System.Windows.Forms.RadioButton paperRadioButton;
        private System.Windows.Forms.RadioButton rockRadioButton;
        private System.Windows.Forms.GroupBox computerChoiceGroupBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label computerScoreLabel;
        private System.Windows.Forms.Label userScoreLabel;
        private System.Windows.Forms.Label computerScoreTextLabel;
        private System.Windows.Forms.Label userScoreTextLabel;
    }
}