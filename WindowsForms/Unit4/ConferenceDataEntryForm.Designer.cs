namespace WindowsForms.Unit4
{
    partial class ConferenceDataEntryForm
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
            this.attendeeNameLabel = new System.Windows.Forms.Label();
            this.attendeeNameTextBox = new System.Windows.Forms.TextBox();
            this.schoolNameLabel = new System.Windows.Forms.Label();
            this.schoolNameListBox = new System.Windows.Forms.ListBox();
            this.diningOptionsLabel = new System.Windows.Forms.Label();
            this.pizzaRadioButton = new System.Windows.Forms.RadioButton();
            this.fishAndChipsRadioButton = new System.Windows.Forms.RadioButton();
            this.pastaRadioButton = new System.Windows.Forms.RadioButton();
            this.saladRadioButton = new System.Windows.Forms.RadioButton();
            this.quitButton = new System.Windows.Forms.Button();
            this.totalsButton = new System.Windows.Forms.Button();
            this.seeBillButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // attendeeNameLabel
            // 
            this.attendeeNameLabel.AutoSize = true;
            this.attendeeNameLabel.Location = new System.Drawing.Point(34, 43);
            this.attendeeNameLabel.Name = "attendeeNameLabel";
            this.attendeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.attendeeNameLabel.TabIndex = 0;
            this.attendeeNameLabel.Text = "Attendee Name:";
            // 
            // attendeeNameTextBox
            // 
            this.attendeeNameTextBox.Location = new System.Drawing.Point(139, 40);
            this.attendeeNameTextBox.Name = "attendeeNameTextBox";
            this.attendeeNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.attendeeNameTextBox.TabIndex = 1;
            // 
            // schoolNameLabel
            // 
            this.schoolNameLabel.AutoSize = true;
            this.schoolNameLabel.Location = new System.Drawing.Point(34, 92);
            this.schoolNameLabel.Name = "schoolNameLabel";
            this.schoolNameLabel.Size = new System.Drawing.Size(74, 13);
            this.schoolNameLabel.TabIndex = 2;
            this.schoolNameLabel.Text = "School Name:";
            // 
            // schoolNameListBox
            // 
            this.schoolNameListBox.FormattingEnabled = true;
            this.schoolNameListBox.Items.AddRange(new object[] {
            "Oakridge School",
            "Royal Grammar School",
            "Henley College",
            "Bucks New Uni"});
            this.schoolNameListBox.Location = new System.Drawing.Point(139, 92);
            this.schoolNameListBox.Name = "schoolNameListBox";
            this.schoolNameListBox.Size = new System.Drawing.Size(137, 56);
            this.schoolNameListBox.TabIndex = 3;
            // 
            // diningOptionsLabel
            // 
            this.diningOptionsLabel.AutoSize = true;
            this.diningOptionsLabel.Location = new System.Drawing.Point(34, 177);
            this.diningOptionsLabel.Name = "diningOptionsLabel";
            this.diningOptionsLabel.Size = new System.Drawing.Size(79, 13);
            this.diningOptionsLabel.TabIndex = 4;
            this.diningOptionsLabel.Text = "Dining Options:";
            // 
            // pizzaRadioButton
            // 
            this.pizzaRadioButton.AutoSize = true;
            this.pizzaRadioButton.Location = new System.Drawing.Point(139, 177);
            this.pizzaRadioButton.Name = "pizzaRadioButton";
            this.pizzaRadioButton.Size = new System.Drawing.Size(50, 17);
            this.pizzaRadioButton.TabIndex = 5;
            this.pizzaRadioButton.TabStop = true;
            this.pizzaRadioButton.Text = "Pizza";
            this.pizzaRadioButton.UseVisualStyleBackColor = true;
            // 
            // fishAndChipsRadioButton
            // 
            this.fishAndChipsRadioButton.AutoSize = true;
            this.fishAndChipsRadioButton.Location = new System.Drawing.Point(139, 200);
            this.fishAndChipsRadioButton.Name = "fishAndChipsRadioButton";
            this.fishAndChipsRadioButton.Size = new System.Drawing.Size(82, 17);
            this.fishAndChipsRadioButton.TabIndex = 6;
            this.fishAndChipsRadioButton.TabStop = true;
            this.fishAndChipsRadioButton.Text = "Fish n Chips";
            this.fishAndChipsRadioButton.UseVisualStyleBackColor = true;
            // 
            // pastaRadioButton
            // 
            this.pastaRadioButton.AutoSize = true;
            this.pastaRadioButton.Location = new System.Drawing.Point(139, 223);
            this.pastaRadioButton.Name = "pastaRadioButton";
            this.pastaRadioButton.Size = new System.Drawing.Size(52, 17);
            this.pastaRadioButton.TabIndex = 7;
            this.pastaRadioButton.TabStop = true;
            this.pastaRadioButton.Text = "Pasta";
            this.pastaRadioButton.UseVisualStyleBackColor = true;
            // 
            // saladRadioButton
            // 
            this.saladRadioButton.AutoSize = true;
            this.saladRadioButton.Location = new System.Drawing.Point(139, 246);
            this.saladRadioButton.Name = "saladRadioButton";
            this.saladRadioButton.Size = new System.Drawing.Size(52, 17);
            this.saladRadioButton.TabIndex = 8;
            this.saladRadioButton.TabStop = true;
            this.saladRadioButton.Text = "Salad";
            this.saladRadioButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(457, 284);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(92, 27);
            this.quitButton.TabIndex = 9;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(310, 284);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(92, 27);
            this.totalsButton.TabIndex = 10;
            this.totalsButton.Text = "Total";
            this.totalsButton.UseVisualStyleBackColor = true;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // seeBillButton
            // 
            this.seeBillButton.Location = new System.Drawing.Point(26, 284);
            this.seeBillButton.Name = "seeBillButton";
            this.seeBillButton.Size = new System.Drawing.Size(92, 27);
            this.seeBillButton.TabIndex = 11;
            this.seeBillButton.Text = "See Bill";
            this.seeBillButton.UseVisualStyleBackColor = true;
            this.seeBillButton.Click += new System.EventHandler(this.seeBillButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(315, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 232);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(167, 284);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 27);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ConferenceDataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(587, 324);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.seeBillButton);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.saladRadioButton);
            this.Controls.Add(this.pastaRadioButton);
            this.Controls.Add(this.fishAndChipsRadioButton);
            this.Controls.Add(this.pizzaRadioButton);
            this.Controls.Add(this.diningOptionsLabel);
            this.Controls.Add(this.schoolNameListBox);
            this.Controls.Add(this.schoolNameLabel);
            this.Controls.Add(this.attendeeNameTextBox);
            this.Controls.Add(this.attendeeNameLabel);
            this.Name = "ConferenceDataEntryForm";
            this.Text = "ConferenceDataEntryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label attendeeNameLabel;
        private System.Windows.Forms.Label schoolNameLabel;
        private System.Windows.Forms.Label diningOptionsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox attendeeNameTextBox;
        public System.Windows.Forms.ListBox schoolNameListBox;
        public System.Windows.Forms.RadioButton pizzaRadioButton;
        public System.Windows.Forms.RadioButton fishAndChipsRadioButton;
        public System.Windows.Forms.RadioButton pastaRadioButton;
        public System.Windows.Forms.RadioButton saladRadioButton;
        public System.Windows.Forms.Button quitButton;
        public System.Windows.Forms.Button totalsButton;
        public System.Windows.Forms.Button seeBillButton;
        public System.Windows.Forms.Button clearButton;
    }
}