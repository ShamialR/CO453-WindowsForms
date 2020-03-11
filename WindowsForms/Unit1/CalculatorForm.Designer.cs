namespace WindowsForms.Unit1
{
    partial class CalculatorForm
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
            this.firstNumberText = new System.Windows.Forms.TextBox();
            this.secondNumberText = new System.Windows.Forms.TextBox();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultAnswerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.additionButton = new System.Windows.Forms.Button();
            this.subtractionButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberText
            // 
            this.firstNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.firstNumberText.Location = new System.Drawing.Point(240, 70);
            this.firstNumberText.Name = "firstNumberText";
            this.firstNumberText.Size = new System.Drawing.Size(100, 26);
            this.firstNumberText.TabIndex = 0;
            // 
            // secondNumberText
            // 
            this.secondNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.secondNumberText.Location = new System.Drawing.Point(240, 118);
            this.secondNumberText.Name = "secondNumberText";
            this.secondNumberText.Size = new System.Drawing.Size(100, 26);
            this.secondNumberText.TabIndex = 1;
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(107, 77);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.firstNumberLabel.TabIndex = 2;
            this.firstNumberLabel.Text = "First Number:";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(107, 125);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.secondNumberLabel.TabIndex = 3;
            this.secondNumberLabel.Text = "Second Number:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(107, 170);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(48, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Results: ";
            // 
            // resultAnswerLabel
            // 
            this.resultAnswerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.resultAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.resultAnswerLabel.Location = new System.Drawing.Point(240, 165);
            this.resultAnswerLabel.Name = "resultAnswerLabel";
            this.resultAnswerLabel.Size = new System.Drawing.Size(100, 27);
            this.resultAnswerLabel.TabIndex = 5;
            this.resultAnswerLabel.Text = "                  ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.titleLabel.Location = new System.Drawing.Point(40, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(268, 37);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Simple Calculator";
            // 
            // additionButton
            // 
            this.additionButton.Location = new System.Drawing.Point(392, 67);
            this.additionButton.Name = "additionButton";
            this.additionButton.Size = new System.Drawing.Size(75, 23);
            this.additionButton.TabIndex = 7;
            this.additionButton.Text = "Add";
            this.additionButton.UseVisualStyleBackColor = true;
            this.additionButton.Click += new System.EventHandler(this.additionButton_Click);
            // 
            // subtractionButton
            // 
            this.subtractionButton.Location = new System.Drawing.Point(392, 115);
            this.subtractionButton.Name = "subtractionButton";
            this.subtractionButton.Size = new System.Drawing.Size(75, 23);
            this.subtractionButton.TabIndex = 8;
            this.subtractionButton.Text = "Subtract";
            this.subtractionButton.UseVisualStyleBackColor = true;
            this.subtractionButton.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(392, 165);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(75, 23);
            this.multiplicationButton.TabIndex = 9;
            this.multiplicationButton.Text = "Multiply";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(392, 216);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 23);
            this.divisionButton.TabIndex = 10;
            this.divisionButton.Text = "Divide";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 258);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(203, 216);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(75, 23);
            this.averageButton.TabIndex = 12;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.Location = new System.Drawing.Point(298, 216);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(75, 23);
            this.powerButton.TabIndex = 13;
            this.powerButton.Text = "Power";
            this.powerButton.UseVisualStyleBackColor = true;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(101, 216);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(510, 293);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.powerButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.subtractionButton);
            this.Controls.Add(this.additionButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resultAnswerLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.secondNumberLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Controls.Add(this.secondNumberText);
            this.Controls.Add(this.firstNumberText);
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberText;
        private System.Windows.Forms.TextBox secondNumberText;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label resultAnswerLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button additionButton;
        private System.Windows.Forms.Button subtractionButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button clearButton;
    }
}