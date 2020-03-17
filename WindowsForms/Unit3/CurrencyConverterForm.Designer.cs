namespace WindowsForms.Unit3
{
    partial class CurrencyConverterForm
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
            this.currencyConverterTextLabel = new System.Windows.Forms.Label();
            this.ukPoundsLabel = new System.Windows.Forms.Label();
            this.convertedAmountTextLabel = new System.Windows.Forms.Label();
            this.convertedResultLabel = new System.Windows.Forms.Label();
            this.ukPoundsTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dollarsRadioButton = new System.Windows.Forms.RadioButton();
            this.eurosRadioButton = new System.Windows.Forms.RadioButton();
            this.rupeesRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // currencyConverterTextLabel
            // 
            this.currencyConverterTextLabel.AutoSize = true;
            this.currencyConverterTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.currencyConverterTextLabel.Location = new System.Drawing.Point(24, 29);
            this.currencyConverterTextLabel.Name = "currencyConverterTextLabel";
            this.currencyConverterTextLabel.Size = new System.Drawing.Size(220, 29);
            this.currencyConverterTextLabel.TabIndex = 0;
            this.currencyConverterTextLabel.Text = "Currency Converter";
            // 
            // ukPoundsLabel
            // 
            this.ukPoundsLabel.AutoSize = true;
            this.ukPoundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ukPoundsLabel.Location = new System.Drawing.Point(73, 114);
            this.ukPoundsLabel.Name = "ukPoundsLabel";
            this.ukPoundsLabel.Size = new System.Drawing.Size(88, 18);
            this.ukPoundsLabel.TabIndex = 1;
            this.ukPoundsLabel.Text = "UK Pounds:";
            // 
            // convertedAmountTextLabel
            // 
            this.convertedAmountTextLabel.AutoSize = true;
            this.convertedAmountTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.convertedAmountTextLabel.Location = new System.Drawing.Point(26, 184);
            this.convertedAmountTextLabel.Name = "convertedAmountTextLabel";
            this.convertedAmountTextLabel.Size = new System.Drawing.Size(135, 18);
            this.convertedAmountTextLabel.TabIndex = 2;
            this.convertedAmountTextLabel.Text = "Converted Amount:";
            // 
            // convertedResultLabel
            // 
            this.convertedResultLabel.BackColor = System.Drawing.Color.Silver;
            this.convertedResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.convertedResultLabel.Location = new System.Drawing.Point(209, 184);
            this.convertedResultLabel.Name = "convertedResultLabel";
            this.convertedResultLabel.Size = new System.Drawing.Size(140, 18);
            this.convertedResultLabel.TabIndex = 3;
            // 
            // ukPoundsTextBox
            // 
            this.ukPoundsTextBox.Location = new System.Drawing.Point(210, 115);
            this.ukPoundsTextBox.Name = "ukPoundsTextBox";
            this.ukPoundsTextBox.Size = new System.Drawing.Size(139, 20);
            this.ukPoundsTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rupeesRadioButton);
            this.panel1.Controls.Add(this.eurosRadioButton);
            this.panel1.Controls.Add(this.dollarsRadioButton);
            this.panel1.Location = new System.Drawing.Point(424, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 251);
            this.panel1.TabIndex = 5;
            // 
            // dollarsRadioButton
            // 
            this.dollarsRadioButton.AutoSize = true;
            this.dollarsRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dollarsRadioButton.Location = new System.Drawing.Point(49, 44);
            this.dollarsRadioButton.Name = "dollarsRadioButton";
            this.dollarsRadioButton.Size = new System.Drawing.Size(64, 19);
            this.dollarsRadioButton.TabIndex = 0;
            this.dollarsRadioButton.TabStop = true;
            this.dollarsRadioButton.Text = "Dollars";
            this.dollarsRadioButton.UseVisualStyleBackColor = true;
            this.dollarsRadioButton.CheckedChanged += new System.EventHandler(this.dollarsRadioButton_CheckedChanged);
            // 
            // eurosRadioButton
            // 
            this.eurosRadioButton.AutoSize = true;
            this.eurosRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eurosRadioButton.Location = new System.Drawing.Point(49, 115);
            this.eurosRadioButton.Name = "eurosRadioButton";
            this.eurosRadioButton.Size = new System.Drawing.Size(57, 19);
            this.eurosRadioButton.TabIndex = 1;
            this.eurosRadioButton.TabStop = true;
            this.eurosRadioButton.Text = "Euros";
            this.eurosRadioButton.UseVisualStyleBackColor = true;
            this.eurosRadioButton.CheckedChanged += new System.EventHandler(this.eurosRadioButton_CheckedChanged);
            // 
            // rupeesRadioButton
            // 
            this.rupeesRadioButton.AutoSize = true;
            this.rupeesRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.rupeesRadioButton.Location = new System.Drawing.Point(49, 186);
            this.rupeesRadioButton.Name = "rupeesRadioButton";
            this.rupeesRadioButton.Size = new System.Drawing.Size(68, 19);
            this.rupeesRadioButton.TabIndex = 2;
            this.rupeesRadioButton.TabStop = true;
            this.rupeesRadioButton.Text = "Rupees";
            this.rupeesRadioButton.UseVisualStyleBackColor = true;
            this.rupeesRadioButton.CheckedChanged += new System.EventHandler(this.rupeesRadioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(658, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ukPoundsTextBox);
            this.Controls.Add(this.convertedResultLabel);
            this.Controls.Add(this.convertedAmountTextLabel);
            this.Controls.Add(this.ukPoundsLabel);
            this.Controls.Add(this.currencyConverterTextLabel);
            this.Name = "CurrencyConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurrencyConverterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currencyConverterTextLabel;
        private System.Windows.Forms.Label ukPoundsLabel;
        private System.Windows.Forms.Label convertedAmountTextLabel;
        private System.Windows.Forms.Label convertedResultLabel;
        private System.Windows.Forms.TextBox ukPoundsTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rupeesRadioButton;
        private System.Windows.Forms.RadioButton eurosRadioButton;
        private System.Windows.Forms.RadioButton dollarsRadioButton;
        private System.Windows.Forms.Button button1;
    }
}