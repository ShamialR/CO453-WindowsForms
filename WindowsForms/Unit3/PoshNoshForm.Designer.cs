namespace WindowsForms.Unit3
{
    partial class PoshNoshForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoshNoshForm));
            this.dinnerPictureBox = new System.Windows.Forms.PictureBox();
            this.totalCostGroupBox = new System.Windows.Forms.GroupBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.startersGroupBox = new System.Windows.Forms.GroupBox();
            this.startersListBox = new System.Windows.Forms.ListBox();
            this.mainsGroupBox = new System.Windows.Forms.GroupBox();
            this.mainsListBox = new System.Windows.Forms.ListBox();
            this.dessertsGroupBox = new System.Windows.Forms.GroupBox();
            this.dessertsComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPictureBox)).BeginInit();
            this.totalCostGroupBox.SuspendLayout();
            this.startersGroupBox.SuspendLayout();
            this.mainsGroupBox.SuspendLayout();
            this.dessertsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dinnerPictureBox
            // 
            this.dinnerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("dinnerPictureBox.Image")));
            this.dinnerPictureBox.Location = new System.Drawing.Point(270, 19);
            this.dinnerPictureBox.Name = "dinnerPictureBox";
            this.dinnerPictureBox.Size = new System.Drawing.Size(271, 157);
            this.dinnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dinnerPictureBox.TabIndex = 0;
            this.dinnerPictureBox.TabStop = false;
            // 
            // totalCostGroupBox
            // 
            this.totalCostGroupBox.Controls.Add(this.totalCostLabel);
            this.totalCostGroupBox.Location = new System.Drawing.Point(270, 210);
            this.totalCostGroupBox.Name = "totalCostGroupBox";
            this.totalCostGroupBox.Size = new System.Drawing.Size(135, 51);
            this.totalCostGroupBox.TabIndex = 1;
            this.totalCostGroupBox.TabStop = false;
            this.totalCostGroupBox.Text = "Total Cost";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(13, 27);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(0, 13);
            this.totalCostLabel.TabIndex = 0;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(406, 215);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(135, 46);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // startersGroupBox
            // 
            this.startersGroupBox.Controls.Add(this.startersListBox);
            this.startersGroupBox.Location = new System.Drawing.Point(12, 19);
            this.startersGroupBox.Name = "startersGroupBox";
            this.startersGroupBox.Size = new System.Drawing.Size(221, 76);
            this.startersGroupBox.TabIndex = 2;
            this.startersGroupBox.TabStop = false;
            this.startersGroupBox.Text = "Starters";
            // 
            // startersListBox
            // 
            this.startersListBox.FormattingEnabled = true;
            this.startersListBox.Items.AddRange(new object[] {
            "Black Pudding Pate",
            "Caesar Salad",
            "Chicken Liver Toast",
            "Chilli Fish Cakes",
            "King Prawn CousCous",
            "Prawn Cocktail",
            "Soup of the Day"});
            this.startersListBox.Location = new System.Drawing.Point(54, 24);
            this.startersListBox.Name = "startersListBox";
            this.startersListBox.Size = new System.Drawing.Size(138, 30);
            this.startersListBox.Sorted = true;
            this.startersListBox.TabIndex = 0;
            this.startersListBox.SelectedIndexChanged += new System.EventHandler(this.startersListBox_SelectedIndexChanged);
            // 
            // mainsGroupBox
            // 
            this.mainsGroupBox.Controls.Add(this.mainsListBox);
            this.mainsGroupBox.Location = new System.Drawing.Point(12, 101);
            this.mainsGroupBox.Name = "mainsGroupBox";
            this.mainsGroupBox.Size = new System.Drawing.Size(221, 76);
            this.mainsGroupBox.TabIndex = 3;
            this.mainsGroupBox.TabStop = false;
            this.mainsGroupBox.Text = "Mains";
            // 
            // mainsListBox
            // 
            this.mainsListBox.FormattingEnabled = true;
            this.mainsListBox.Items.AddRange(new object[] {
            "Chicken Lasagne",
            "Fish and Chips",
            "Steak and Chips",
            "Vegetable Curry"});
            this.mainsListBox.Location = new System.Drawing.Point(54, 21);
            this.mainsListBox.Name = "mainsListBox";
            this.mainsListBox.Size = new System.Drawing.Size(138, 30);
            this.mainsListBox.Sorted = true;
            this.mainsListBox.TabIndex = 0;
            this.mainsListBox.SelectedIndexChanged += new System.EventHandler(this.mainsListBox_SelectedIndexChanged);
            // 
            // dessertsGroupBox
            // 
            this.dessertsGroupBox.Controls.Add(this.dessertsComboBox);
            this.dessertsGroupBox.Location = new System.Drawing.Point(12, 185);
            this.dessertsGroupBox.Name = "dessertsGroupBox";
            this.dessertsGroupBox.Size = new System.Drawing.Size(221, 76);
            this.dessertsGroupBox.TabIndex = 4;
            this.dessertsGroupBox.TabStop = false;
            this.dessertsGroupBox.Text = "Desserts";
            // 
            // dessertsComboBox
            // 
            this.dessertsComboBox.FormattingEnabled = true;
            this.dessertsComboBox.Items.AddRange(new object[] {
            "Cake",
            "Ice Cream",
            "Chocolate",
            "Cookie"});
            this.dessertsComboBox.Location = new System.Drawing.Point(54, 27);
            this.dessertsComboBox.Name = "dessertsComboBox";
            this.dessertsComboBox.Size = new System.Drawing.Size(138, 21);
            this.dessertsComboBox.TabIndex = 0;
            this.dessertsComboBox.Text = "Dessert Choices";
            this.dessertsComboBox.SelectedIndexChanged += new System.EventHandler(this.dessertsComboBox_SelectedIndexChanged);
            // 
            // PoshNoshForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(577, 292);
            this.Controls.Add(this.dessertsGroupBox);
            this.Controls.Add(this.mainsGroupBox);
            this.Controls.Add(this.startersGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.totalCostGroupBox);
            this.Controls.Add(this.dinnerPictureBox);
            this.Name = "PoshNoshForm";
            this.Text = "PoshNoshForm";
            ((System.ComponentModel.ISupportInitialize)(this.dinnerPictureBox)).EndInit();
            this.totalCostGroupBox.ResumeLayout(false);
            this.totalCostGroupBox.PerformLayout();
            this.startersGroupBox.ResumeLayout(false);
            this.mainsGroupBox.ResumeLayout(false);
            this.dessertsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dinnerPictureBox;
        private System.Windows.Forms.GroupBox totalCostGroupBox;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox startersGroupBox;
        private System.Windows.Forms.ListBox startersListBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.GroupBox mainsGroupBox;
        private System.Windows.Forms.ListBox mainsListBox;
        private System.Windows.Forms.GroupBox dessertsGroupBox;
        private System.Windows.Forms.ComboBox dessertsComboBox;
    }
}