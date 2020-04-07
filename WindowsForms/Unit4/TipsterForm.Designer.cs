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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.billLabel.Location = new System.Drawing.Point(47, 28);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(27, 18);
            this.billLabel.TabIndex = 0;
            this.billLabel.Text = "Bill";
            // 
            // numberOfPeopleLabel
            // 
            this.numberOfPeopleLabel.AutoSize = true;
            this.numberOfPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numberOfPeopleLabel.Location = new System.Drawing.Point(47, 80);
            this.numberOfPeopleLabel.Name = "numberOfPeopleLabel";
            this.numberOfPeopleLabel.Size = new System.Drawing.Size(131, 18);
            this.numberOfPeopleLabel.TabIndex = 1;
            this.numberOfPeopleLabel.Text = "Number Of People";
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(144, 28);
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
            this.numberOfPeopleListBox.Location = new System.Drawing.Point(204, 80);
            this.numberOfPeopleListBox.Name = "numberOfPeopleListBox";
            this.numberOfPeopleListBox.Size = new System.Drawing.Size(40, 43);
            this.numberOfPeopleListBox.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(348, 28);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(222, 216);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(348, 278);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(495, 278);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 6;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // TipsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(628, 324);
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
    }
}