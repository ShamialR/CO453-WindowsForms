namespace WindowsForms.Unit4
{
    partial class ConferenceSeeBillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConferenceSeeBillForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.displayAttendeeNameLabel = new System.Windows.Forms.Label();
            this.schoolNameLabel = new System.Windows.Forms.Label();
            this.displaySchoolNameLabel = new System.Windows.Forms.Label();
            this.choicesGroupBox = new System.Windows.Forms.GroupBox();
            this.displayTotalCostLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.displayAttendanceCostLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayDiningCostLabel = new System.Windows.Forms.Label();
            this.diningCostLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.acceptBillButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choicesGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(449, 286);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(119, 35);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendee Name:";
            // 
            // displayAttendeeNameLabel
            // 
            this.displayAttendeeNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayAttendeeNameLabel.Location = new System.Drawing.Point(131, 43);
            this.displayAttendeeNameLabel.Name = "displayAttendeeNameLabel";
            this.displayAttendeeNameLabel.Size = new System.Drawing.Size(84, 13);
            this.displayAttendeeNameLabel.TabIndex = 2;
            // 
            // schoolNameLabel
            // 
            this.schoolNameLabel.AutoSize = true;
            this.schoolNameLabel.Location = new System.Drawing.Point(10, 80);
            this.schoolNameLabel.Name = "schoolNameLabel";
            this.schoolNameLabel.Size = new System.Drawing.Size(74, 13);
            this.schoolNameLabel.TabIndex = 3;
            this.schoolNameLabel.Text = "School Name:";
            // 
            // displaySchoolNameLabel
            // 
            this.displaySchoolNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displaySchoolNameLabel.Location = new System.Drawing.Point(131, 80);
            this.displaySchoolNameLabel.Name = "displaySchoolNameLabel";
            this.displaySchoolNameLabel.Size = new System.Drawing.Size(84, 13);
            this.displaySchoolNameLabel.TabIndex = 4;
            // 
            // choicesGroupBox
            // 
            this.choicesGroupBox.Controls.Add(this.displayTotalCostLabel);
            this.choicesGroupBox.Controls.Add(this.totalCostLabel);
            this.choicesGroupBox.Controls.Add(this.displayAttendanceCostLabel);
            this.choicesGroupBox.Controls.Add(this.label3);
            this.choicesGroupBox.Controls.Add(this.displayDiningCostLabel);
            this.choicesGroupBox.Controls.Add(this.diningCostLabel);
            this.choicesGroupBox.Location = new System.Drawing.Point(29, 171);
            this.choicesGroupBox.Name = "choicesGroupBox";
            this.choicesGroupBox.Size = new System.Drawing.Size(236, 144);
            this.choicesGroupBox.TabIndex = 5;
            this.choicesGroupBox.TabStop = false;
            this.choicesGroupBox.Text = "Choices";
            // 
            // displayTotalCostLabel
            // 
            this.displayTotalCostLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayTotalCostLabel.Location = new System.Drawing.Point(131, 107);
            this.displayTotalCostLabel.Name = "displayTotalCostLabel";
            this.displayTotalCostLabel.Size = new System.Drawing.Size(84, 13);
            this.displayTotalCostLabel.TabIndex = 9;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(10, 107);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 8;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // displayAttendanceCostLabel
            // 
            this.displayAttendanceCostLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayAttendanceCostLabel.Location = new System.Drawing.Point(131, 70);
            this.displayAttendanceCostLabel.Name = "displayAttendanceCostLabel";
            this.displayAttendanceCostLabel.Size = new System.Drawing.Size(84, 13);
            this.displayAttendanceCostLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Attendance Cost:";
            // 
            // displayDiningCostLabel
            // 
            this.displayDiningCostLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayDiningCostLabel.Location = new System.Drawing.Point(131, 32);
            this.displayDiningCostLabel.Name = "displayDiningCostLabel";
            this.displayDiningCostLabel.Size = new System.Drawing.Size(84, 13);
            this.displayDiningCostLabel.TabIndex = 5;
            // 
            // diningCostLabel
            // 
            this.diningCostLabel.AutoSize = true;
            this.diningCostLabel.Location = new System.Drawing.Point(10, 32);
            this.diningCostLabel.Name = "diningCostLabel";
            this.diningCostLabel.Size = new System.Drawing.Size(64, 13);
            this.diningCostLabel.TabIndex = 0;
            this.diningCostLabel.Text = "Dining Cost:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.schoolNameLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.displaySchoolNameLabel);
            this.groupBox1.Controls.Add(this.displayAttendeeNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choices";
            // 
            // acceptBillButton
            // 
            this.acceptBillButton.Location = new System.Drawing.Point(295, 286);
            this.acceptBillButton.Name = "acceptBillButton";
            this.acceptBillButton.Size = new System.Drawing.Size(119, 35);
            this.acceptBillButton.TabIndex = 7;
            this.acceptBillButton.Text = "Accept Bill";
            this.acceptBillButton.UseVisualStyleBackColor = true;
            this.acceptBillButton.Click += new System.EventHandler(this.acceptBillButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(281, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ConferenceSeeBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(589, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.acceptBillButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.choicesGroupBox);
            this.Controls.Add(this.closeButton);
            this.Name = "ConferenceSeeBillForm";
            this.Text = "Bill Form";
            this.choicesGroupBox.ResumeLayout(false);
            this.choicesGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label schoolNameLabel;
        private System.Windows.Forms.GroupBox choicesGroupBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label diningCostLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button acceptBillButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label displayAttendeeNameLabel;
        public System.Windows.Forms.Label displaySchoolNameLabel;
        public System.Windows.Forms.Label displayTotalCostLabel;
        public System.Windows.Forms.Label displayAttendanceCostLabel;
        public System.Windows.Forms.Label displayDiningCostLabel;
    }
}