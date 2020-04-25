namespace WindowsForms.Unit1
{
    partial class DataEntryForm
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.messageButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.toUpperButton = new System.Windows.Forms.Button();
            this.toLowerButton = new System.Windows.Forms.Button();
            this.changeMessageButton = new System.Windows.Forms.Button();
            this.townNameText = new System.Windows.Forms.TextBox();
            this.townNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.BackColor = System.Drawing.Color.Yellow;
            this.mainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLabel.Font = new System.Drawing.Font("Arial", 24F);
            this.mainLabel.Location = new System.Drawing.Point(50, 20);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(347, 38);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "User Details Data Entry";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(430, 280);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitApplication);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.firstNameLabel.Location = new System.Drawing.Point(50, 88);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 22);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.lastNameLabel.Location = new System.Drawing.Point(50, 128);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(106, 22);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            this.lastNameLabel.Click += new System.EventHandler(this.clickLastNameLabel);
            // 
            // messageButton
            // 
            this.messageButton.Location = new System.Drawing.Point(50, 270);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(93, 37);
            this.messageButton.TabIndex = 4;
            this.messageButton.Text = "&Message";
            this.messageButton.UseVisualStyleBackColor = true;
            this.messageButton.Click += new System.EventHandler(this.showMessage);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(298, 270);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 37);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "&Clear Message";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearMessage);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.BackColor = System.Drawing.Color.Yellow;
            this.messageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.messageLabel.Location = new System.Drawing.Point(176, 216);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(242, 24);
            this.messageLabel.TabIndex = 6;
            this.messageLabel.Text = "                                              ";
            this.messageLabel.Click += new System.EventHandler(this.clickMessageLabel);
            // 
            // firstNameText
            // 
            this.firstNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameText.Font = new System.Drawing.Font("Arial", 14F);
            this.firstNameText.Location = new System.Drawing.Point(176, 85);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(103, 29);
            this.firstNameText.TabIndex = 7;
            // 
            // lastNameText
            // 
            this.lastNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameText.Font = new System.Drawing.Font("Arial", 14F);
            this.lastNameText.Location = new System.Drawing.Point(176, 125);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(103, 29);
            this.lastNameText.TabIndex = 8;
            // 
            // toUpperButton
            // 
            this.toUpperButton.Location = new System.Drawing.Point(59, 241);
            this.toUpperButton.Name = "toUpperButton";
            this.toUpperButton.Size = new System.Drawing.Size(73, 23);
            this.toUpperButton.TabIndex = 9;
            this.toUpperButton.Text = "&Upper Case";
            this.toUpperButton.UseVisualStyleBackColor = true;
            this.toUpperButton.Click += new System.EventHandler(this.changeMessageToUpper);
            // 
            // toLowerButton
            // 
            this.toLowerButton.Location = new System.Drawing.Point(59, 313);
            this.toLowerButton.Name = "toLowerButton";
            this.toLowerButton.Size = new System.Drawing.Size(73, 23);
            this.toLowerButton.TabIndex = 10;
            this.toLowerButton.Text = "&Lower Case";
            this.toLowerButton.UseVisualStyleBackColor = true;
            this.toLowerButton.Click += new System.EventHandler(this.changeMessageToLower);
            // 
            // changeMessageButton
            // 
            this.changeMessageButton.Location = new System.Drawing.Point(164, 270);
            this.changeMessageButton.Name = "changeMessageButton";
            this.changeMessageButton.Size = new System.Drawing.Size(111, 37);
            this.changeMessageButton.TabIndex = 11;
            this.changeMessageButton.Text = "Change Message";
            this.changeMessageButton.UseVisualStyleBackColor = true;
            this.changeMessageButton.Click += new System.EventHandler(this.changeMessage);
            // 
            // townNameText
            // 
            this.townNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.townNameText.Font = new System.Drawing.Font("Arial", 14F);
            this.townNameText.Location = new System.Drawing.Point(176, 166);
            this.townNameText.Name = "townNameText";
            this.townNameText.Size = new System.Drawing.Size(103, 29);
            this.townNameText.TabIndex = 13;
            // 
            // townNameLabel
            // 
            this.townNameLabel.AutoSize = true;
            this.townNameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.townNameLabel.Location = new System.Drawing.Point(50, 169);
            this.townNameLabel.Name = "townNameLabel";
            this.townNameLabel.Size = new System.Drawing.Size(114, 22);
            this.townNameLabel.TabIndex = 12;
            this.townNameLabel.Text = "Town Name:";
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(564, 361);
            this.Controls.Add(this.townNameText);
            this.Controls.Add(this.townNameLabel);
            this.Controls.Add(this.changeMessageButton);
            this.Controls.Add(this.toLowerButton);
            this.Controls.Add(this.toUpperButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.messageButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.mainLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataEntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button toUpperButton;
        private System.Windows.Forms.Button toLowerButton;
        private System.Windows.Forms.Button changeMessageButton;
        private System.Windows.Forms.TextBox townNameText;
        private System.Windows.Forms.Label townNameLabel;
    }
}