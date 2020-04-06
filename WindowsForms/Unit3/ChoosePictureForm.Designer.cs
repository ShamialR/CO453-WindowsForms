namespace WindowsForms.Unit3
{
    partial class ChoosePictureForm
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
            this.choiceComboBox = new System.Windows.Forms.ComboBox();
            this.choicePictureBox = new System.Windows.Forms.PictureBox();
            this.quitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.choicePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // choiceComboBox
            // 
            this.choiceComboBox.FormattingEnabled = true;
            this.choiceComboBox.Items.AddRange(new object[] {
            "Dragon",
            "Godzilla",
            "Hydra",
            "Kong",
            "Nessie",
            "Shadow"});
            this.choiceComboBox.Location = new System.Drawing.Point(54, 59);
            this.choiceComboBox.Name = "choiceComboBox";
            this.choiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.choiceComboBox.TabIndex = 0;
            this.choiceComboBox.Text = "Choose Here";
            this.choiceComboBox.SelectedIndexChanged += new System.EventHandler(this.choiceComboBox_SelectedIndexChanged);
            // 
            // choicePictureBox
            // 
            this.choicePictureBox.Location = new System.Drawing.Point(325, 55);
            this.choicePictureBox.Name = "choicePictureBox";
            this.choicePictureBox.Size = new System.Drawing.Size(188, 216);
            this.choicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choicePictureBox.TabIndex = 1;
            this.choicePictureBox.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(56, 249);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(119, 22);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // ChoosePictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(582, 326);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.choicePictureBox);
            this.Controls.Add(this.choiceComboBox);
            this.Name = "ChoosePictureForm";
            this.Text = "Choose A Picture";
            ((System.ComponentModel.ISupportInitialize)(this.choicePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox choiceComboBox;
        private System.Windows.Forms.PictureBox choicePictureBox;
        private System.Windows.Forms.Button quitButton;
    }
}