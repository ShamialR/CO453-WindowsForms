namespace WindowsForms.Unit4
{
    partial class ResultsForm
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
            this.billDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalBillLabel = new System.Windows.Forms.Label();
            this.peopleLabel = new System.Windows.Forms.Label();
            this.eachPaysLabel = new System.Windows.Forms.Label();
            this.displayEachPaysLabel = new System.Windows.Forms.Label();
            this.displayTotalBillLabel = new System.Windows.Forms.Label();
            this.displayPeopleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.displayTipLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.billDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // billDetailsGroupBox
            // 
            this.billDetailsGroupBox.Controls.Add(this.displayTipLabel);
            this.billDetailsGroupBox.Controls.Add(this.tipLabel);
            this.billDetailsGroupBox.Controls.Add(this.displayPeopleLabel);
            this.billDetailsGroupBox.Controls.Add(this.displayTotalBillLabel);
            this.billDetailsGroupBox.Controls.Add(this.peopleLabel);
            this.billDetailsGroupBox.Controls.Add(this.totalBillLabel);
            this.billDetailsGroupBox.Location = new System.Drawing.Point(43, 36);
            this.billDetailsGroupBox.Name = "billDetailsGroupBox";
            this.billDetailsGroupBox.Size = new System.Drawing.Size(244, 124);
            this.billDetailsGroupBox.TabIndex = 0;
            this.billDetailsGroupBox.TabStop = false;
            this.billDetailsGroupBox.Text = "Bill Details";
            // 
            // totalBillLabel
            // 
            this.totalBillLabel.AutoSize = true;
            this.totalBillLabel.Location = new System.Drawing.Point(17, 35);
            this.totalBillLabel.Name = "totalBillLabel";
            this.totalBillLabel.Size = new System.Drawing.Size(50, 13);
            this.totalBillLabel.TabIndex = 0;
            this.totalBillLabel.Text = "Total Bill:";
            // 
            // peopleLabel
            // 
            this.peopleLabel.AutoSize = true;
            this.peopleLabel.Location = new System.Drawing.Point(17, 66);
            this.peopleLabel.Name = "peopleLabel";
            this.peopleLabel.Size = new System.Drawing.Size(43, 13);
            this.peopleLabel.TabIndex = 1;
            this.peopleLabel.Text = "People:";
            // 
            // eachPaysLabel
            // 
            this.eachPaysLabel.AutoSize = true;
            this.eachPaysLabel.Location = new System.Drawing.Point(40, 197);
            this.eachPaysLabel.Name = "eachPaysLabel";
            this.eachPaysLabel.Size = new System.Drawing.Size(61, 13);
            this.eachPaysLabel.TabIndex = 2;
            this.eachPaysLabel.Text = "Each Pays:";
            // 
            // displayEachPaysLabel
            // 
            this.displayEachPaysLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.displayEachPaysLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayEachPaysLabel.Location = new System.Drawing.Point(150, 187);
            this.displayEachPaysLabel.Name = "displayEachPaysLabel";
            this.displayEachPaysLabel.Size = new System.Drawing.Size(97, 23);
            this.displayEachPaysLabel.TabIndex = 3;
            // 
            // displayTotalBillLabel
            // 
            this.displayTotalBillLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayTotalBillLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayTotalBillLabel.Location = new System.Drawing.Point(104, 25);
            this.displayTotalBillLabel.Name = "displayTotalBillLabel";
            this.displayTotalBillLabel.Size = new System.Drawing.Size(100, 23);
            this.displayTotalBillLabel.TabIndex = 4;
            // 
            // displayPeopleLabel
            // 
            this.displayPeopleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayPeopleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayPeopleLabel.Location = new System.Drawing.Point(104, 56);
            this.displayPeopleLabel.Name = "displayPeopleLabel";
            this.displayPeopleLabel.Size = new System.Drawing.Size(100, 23);
            this.displayPeopleLabel.TabIndex = 5;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(115, 281);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // displayTipLabel
            // 
            this.displayTipLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.displayTipLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.displayTipLabel.Location = new System.Drawing.Point(104, 88);
            this.displayTipLabel.Name = "displayTipLabel";
            this.displayTipLabel.Size = new System.Drawing.Size(100, 23);
            this.displayTipLabel.TabIndex = 7;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(17, 98);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(25, 13);
            this.tipLabel.TabIndex = 6;
            this.tipLabel.Text = "Tip:";
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 326);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.displayEachPaysLabel);
            this.Controls.Add(this.eachPaysLabel);
            this.Controls.Add(this.billDetailsGroupBox);
            this.Name = "ResultsForm";
            this.Text = "Results";
            this.billDetailsGroupBox.ResumeLayout(false);
            this.billDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox billDetailsGroupBox;
        private System.Windows.Forms.Label peopleLabel;
        private System.Windows.Forms.Label totalBillLabel;
        private System.Windows.Forms.Label eachPaysLabel;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label displayPeopleLabel;
        public System.Windows.Forms.Label displayTotalBillLabel;
        public System.Windows.Forms.Label displayEachPaysLabel;
        public System.Windows.Forms.Label displayTipLabel;
        private System.Windows.Forms.Label tipLabel;
    }
}