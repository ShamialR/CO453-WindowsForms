namespace WindowsForms.Unit4
{
    partial class TipsterForm
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
            this.billLabel = new System.Windows.Forms.Label();
            this.numberOfPeopleLabel = new System.Windows.Forms.Label();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.numberOfPeopleListBox = new System.Windows.Forms.ListBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.tipGroupBox = new System.Windows.Forms.GroupBox();
            this.madTipRadioButton = new System.Windows.Forms.RadioButton();
            this.generousTipRadioButton = new System.Windows.Forms.RadioButton();
            this.normalTipRadioButton = new System.Windows.Forms.RadioButton();
            this.noneTipRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tipGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.billLabel.Location = new System.Drawing.Point(12, 28);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(27, 18);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Bill";
            // 
            // numberOfPeopleLabel
            // 
            this.numberOfPeopleLabel.AutoSize = true;
            this.numberOfPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfPeopleLabel.Location = new System.Drawing.Point(12, 226);
            this.numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            this.numberOfPeopleLabel.Size = new System.Drawing.Size(131, 18);
            this.numberOfPeopleLabel.TabIndex = 1;
            this.numberOfPeopleLabel.Text = "Number Of People";
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(118, 29);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(100, 20);
            this.billTextBox.TabIndex = 2;
            // 
            // numberOfPeopleListBox
            // 
            this.numberOfPeopleListBox.FormattingEnabled = true;
            this.numberOfPeopleListBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.numberOfPeopleListBox.Location = new System.Drawing.Point(178, 217);
            this.numberOfPeopleListBox.Name = "numberOfPeopleListBox";
            this.numberOfPeopleListBox.Size = new System.Drawing.Size(40, 69);
            this.numberOfPeopleListBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(264, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(222, 216);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(264, 278);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(411, 278);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // tipGroupBox
            // 
            this.tipGroupBox.Controls.Add(this.madTipRadioButton);
            this.tipGroupBox.Controls.Add(this.generousTipRadioButton);
            this.tipGroupBox.Controls.Add(this.normalTipRadioButton);
            this.tipGroupBox.Controls.Add(this.noneTipRadioButton);
            this.tipGroupBox.Location = new System.Drawing.Point(15, 78);
            this.tipGroupBox.Name = "tipGroupBox";
            this.tipGroupBox.Size = new System.Drawing.Size(203, 114);
            this.tipGroupBox.TabIndex = 7;
            this.tipGroupBox.TabStop = false;
            this.tipGroupBox.Text = "Tip";
            // 
            // madTipRadioButton
            // 
            this.madTipRadioButton.AutoSize = true;
            this.madTipRadioButton.Location = new System.Drawing.Point(43, 88);
            this.madTipRadioButton.Name = "madTipRadioButton";
            this.madTipRadioButton.Size = new System.Drawing.Size(46, 17);
            this.madTipRadioButton.TabIndex = 3;
            this.madTipRadioButton.TabStop = true;
            this.madTipRadioButton.Text = "Mad";
            this.madTipRadioButton.UseVisualStyleBackColor = true;
            // 
            // generousTipRadioButton
            // 
            this.generousTipRadioButton.AutoSize = true;
            this.generousTipRadioButton.Location = new System.Drawing.Point(43, 65);
            this.generousTipRadioButton.Name = "generousTipRadioButton";
            this.generousTipRadioButton.Size = new System.Drawing.Size(71, 17);
            this.generousTipRadioButton.TabIndex = 2;
            this.generousTipRadioButton.TabStop = true;
            this.generousTipRadioButton.Text = "Generous";
            this.generousTipRadioButton.UseVisualStyleBackColor = true;
            // 
            // normalTipRadioButton
            // 
            this.normalTipRadioButton.AutoSize = true;
            this.normalTipRadioButton.Location = new System.Drawing.Point(43, 42);
            this.normalTipRadioButton.Name = "normalTipRadioButton";
            this.normalTipRadioButton.Size = new System.Drawing.Size(58, 17);
            this.normalTipRadioButton.TabIndex = 1;
            this.normalTipRadioButton.TabStop = true;
            this.normalTipRadioButton.Text = "Normal";
            this.normalTipRadioButton.UseVisualStyleBackColor = true;
            // 
            // noneTipRadioButton
            // 
            this.noneTipRadioButton.AutoSize = true;
            this.noneTipRadioButton.Location = new System.Drawing.Point(43, 19);
            this.noneTipRadioButton.Name = "noneTipRadioButton";
            this.noneTipRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneTipRadioButton.TabIndex = 0;
            this.noneTipRadioButton.TabStop = true;
            this.noneTipRadioButton.Text = "None";
            this.noneTipRadioButton.UseVisualStyleBackColor = true;
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(541, 324);
            this.Controls.Add(this.tipGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.numberOfPeopleListBox);
            this.Controls.Add(this.billTextBox);
            this.Controls.Add(this.numberOfPeopleLabel);
            this.Controls.Add(this.billLabel);
            this.Name = "TipsterForm";
            this.Text = "Tipster Data Entry";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tipGroupBox.ResumeLayout(false);
            this.tipGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.Label numberOfPeopleLabel;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.ListBox numberOfPeopleListBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox tipGroupBox;
        private System.Windows.Forms.RadioButton madTipRadioButton;
        private System.Windows.Forms.RadioButton generousTipRadioButton;
        private System.Windows.Forms.RadioButton normalTipRadioButton;
        private System.Windows.Forms.RadioButton noneTipRadioButton;
    }
}