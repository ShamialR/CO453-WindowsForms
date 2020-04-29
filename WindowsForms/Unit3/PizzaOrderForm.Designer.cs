namespace WindowsForms.Unit3
{
    partial class PizzaOrderForm
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
            this.pizzaSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.pizzaCostGroupBox = new System.Windows.Forms.GroupBox();
            this.pizzaCostLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.toppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.chocolateCheckBox = new System.Windows.Forms.CheckBox();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.rhubarbCheckBox = new System.Windows.Forms.CheckBox();
            this.pineappleCheckBox = new System.Windows.Forms.CheckBox();
            this.pizzaSizeGroupBox.SuspendLayout();
            this.pizzaCostGroupBox.SuspendLayout();
            this.toppingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pizzaSizeGroupBox
            // 
            this.pizzaSizeGroupBox.Controls.Add(this.smallRadioButton);
            this.pizzaSizeGroupBox.Controls.Add(this.mediumRadioButton);
            this.pizzaSizeGroupBox.Controls.Add(this.largeRadioButton);
            this.pizzaSizeGroupBox.Location = new System.Drawing.Point(29, 22);
            this.pizzaSizeGroupBox.Name = "pizzaSizeGroupBox";
            this.pizzaSizeGroupBox.Size = new System.Drawing.Size(119, 157);
            this.pizzaSizeGroupBox.TabIndex = 0;
            this.pizzaSizeGroupBox.TabStop = false;
            this.pizzaSizeGroupBox.Text = "Pizza Size";
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(27, 106);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallRadioButton.TabIndex = 2;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            this.smallRadioButton.CheckedChanged += new System.EventHandler(this.chooseSmallPizza);
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(25, 72);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            this.mediumRadioButton.CheckedChanged += new System.EventHandler(this.chooseMediumPizza);
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoCheck = false;
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(25, 39);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeRadioButton.TabIndex = 0;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            this.largeRadioButton.CheckedChanged += new System.EventHandler(this.chooseLargePizza);
            // 
            // pizzaCostGroupBox
            // 
            this.pizzaCostGroupBox.Controls.Add(this.pizzaCostLabel);
            this.pizzaCostGroupBox.Location = new System.Drawing.Point(29, 198);
            this.pizzaCostGroupBox.Name = "pizzaCostGroupBox";
            this.pizzaCostGroupBox.Size = new System.Drawing.Size(219, 77);
            this.pizzaCostGroupBox.TabIndex = 1;
            this.pizzaCostGroupBox.TabStop = false;
            this.pizzaCostGroupBox.Text = "PizzaCost";
            // 
            // pizzaCostLabel
            // 
            this.pizzaCostLabel.Location = new System.Drawing.Point(58, 31);
            this.pizzaCostLabel.Name = "pizzaCostLabel";
            this.pizzaCostLabel.Size = new System.Drawing.Size(100, 23);
            this.pizzaCostLabel.TabIndex = 0;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(254, 207);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(168, 60);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitApplication);
            // 
            // toppingsGroupBox
            // 
            this.toppingsGroupBox.Controls.Add(this.chocolateCheckBox);
            this.toppingsGroupBox.Controls.Add(this.pepperoniCheckBox);
            this.toppingsGroupBox.Controls.Add(this.rhubarbCheckBox);
            this.toppingsGroupBox.Controls.Add(this.pineappleCheckBox);
            this.toppingsGroupBox.Location = new System.Drawing.Point(193, 22);
            this.toppingsGroupBox.Name = "toppingsGroupBox";
            this.toppingsGroupBox.Size = new System.Drawing.Size(229, 157);
            this.toppingsGroupBox.TabIndex = 3;
            this.toppingsGroupBox.TabStop = false;
            this.toppingsGroupBox.Text = "Toppings";
            // 
            // chocolateCheckBox
            // 
            this.chocolateCheckBox.AutoSize = true;
            this.chocolateCheckBox.Location = new System.Drawing.Point(60, 121);
            this.chocolateCheckBox.Name = "chocolateCheckBox";
            this.chocolateCheckBox.Size = new System.Drawing.Size(74, 17);
            this.chocolateCheckBox.TabIndex = 3;
            this.chocolateCheckBox.Text = "Chocolate";
            this.chocolateCheckBox.UseVisualStyleBackColor = true;
            this.chocolateCheckBox.CheckedChanged += new System.EventHandler(this.pickChocolateTopping);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(60, 88);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 2;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.pickPepperoniTopping);
            // 
            // rhubarbCheckBox
            // 
            this.rhubarbCheckBox.AutoSize = true;
            this.rhubarbCheckBox.Location = new System.Drawing.Point(60, 56);
            this.rhubarbCheckBox.Name = "rhubarbCheckBox";
            this.rhubarbCheckBox.Size = new System.Drawing.Size(67, 17);
            this.rhubarbCheckBox.TabIndex = 1;
            this.rhubarbCheckBox.Text = "Rhubarb";
            this.rhubarbCheckBox.UseVisualStyleBackColor = true;
            this.rhubarbCheckBox.CheckedChanged += new System.EventHandler(this.pickRhubarbTopping);
            // 
            // pineappleCheckBox
            // 
            this.pineappleCheckBox.AutoSize = true;
            this.pineappleCheckBox.Location = new System.Drawing.Point(60, 24);
            this.pineappleCheckBox.Name = "pineappleCheckBox";
            this.pineappleCheckBox.Size = new System.Drawing.Size(73, 17);
            this.pineappleCheckBox.TabIndex = 0;
            this.pineappleCheckBox.Text = "Pineapple";
            this.pineappleCheckBox.UseVisualStyleBackColor = true;
            this.pineappleCheckBox.CheckedChanged += new System.EventHandler(this.pickPineappleTopping);
            // 
            // PizzaOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(462, 291);
            this.Controls.Add(this.toppingsGroupBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.pizzaCostGroupBox);
            this.Controls.Add(this.pizzaSizeGroupBox);
            this.Name = "PizzaOrderForm";
            this.Text = "PizzaOrderForm";
            this.pizzaSizeGroupBox.ResumeLayout(false);
            this.pizzaSizeGroupBox.PerformLayout();
            this.pizzaCostGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pizzaSizeGroupBox;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.GroupBox pizzaCostGroupBox;
        private System.Windows.Forms.Label pizzaCostLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.GroupBox toppingsGroupBox;
        private System.Windows.Forms.CheckBox chocolateCheckBox;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox rhubarbCheckBox;
        private System.Windows.Forms.CheckBox pineappleCheckBox;
    }
}