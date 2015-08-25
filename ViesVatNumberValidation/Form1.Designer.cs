namespace ViesVatNumberValidation
{
    partial class Form1
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
            this.simpleButton = new System.Windows.Forms.Button();
            this.advancedButton = new System.Windows.Forms.Button();
            this.vatNumberTextBox = new System.Windows.Forms.TextBox();
            this.vatNumberLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabelShort = new System.Windows.Forms.Label();
            this.requestLabel = new System.Windows.Forms.Label();
            this.countryRequesterLabelShort = new System.Windows.Forms.Label();
            this.countryRequesterComboBox = new System.Windows.Forms.ComboBox();
            this.countryRequesterLabel = new System.Windows.Forms.Label();
            this.vatRequesterNumberLabel = new System.Windows.Forms.Label();
            this.vatNumberRequesterTextBox = new System.Windows.Forms.TextBox();
            this.saveToFileButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton
            // 
            this.simpleButton.Location = new System.Drawing.Point(199, 117);
            this.simpleButton.Name = "simpleButton";
            this.simpleButton.Size = new System.Drawing.Size(136, 23);
            this.simpleButton.TabIndex = 0;
            this.simpleButton.Text = "Simple Validation";
            this.simpleButton.UseVisualStyleBackColor = true;
            this.simpleButton.Click += new System.EventHandler(this.simpleButton_Click);
            // 
            // advancedButton
            // 
            this.advancedButton.Location = new System.Drawing.Point(341, 117);
            this.advancedButton.Name = "advancedButton";
            this.advancedButton.Size = new System.Drawing.Size(124, 23);
            this.advancedButton.TabIndex = 1;
            this.advancedButton.Text = "Advanced Validation";
            this.advancedButton.UseVisualStyleBackColor = true;
            this.advancedButton.Click += new System.EventHandler(this.advancedButton_Click);
            // 
            // vatNumberTextBox
            // 
            this.vatNumberTextBox.Location = new System.Drawing.Point(341, 36);
            this.vatNumberTextBox.MaxLength = 12;
            this.vatNumberTextBox.Name = "vatNumberTextBox";
            this.vatNumberTextBox.Size = new System.Drawing.Size(124, 20);
            this.vatNumberTextBox.TabIndex = 2;
            this.vatNumberTextBox.TextChanged += new System.EventHandler(this.vatNumberTextBox_TextChanged);
            // 
            // vatNumberLabel
            // 
            this.vatNumberLabel.AutoSize = true;
            this.vatNumberLabel.Location = new System.Drawing.Point(196, 39);
            this.vatNumberLabel.Name = "vatNumberLabel";
            this.vatNumberLabel.Size = new System.Drawing.Size(71, 13);
            this.vatNumberLabel.TabIndex = 3;
            this.vatNumberLabel.Text = "VAT Number:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(196, 12);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(76, 13);
            this.countryLabel.TabIndex = 4;
            this.countryLabel.Text = "Member State:";
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(341, 12);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(124, 21);
            this.countryComboBox.TabIndex = 5;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // countryLabelShort
            // 
            this.countryLabelShort.AutoSize = true;
            this.countryLabelShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.countryLabelShort.Location = new System.Drawing.Point(320, 39);
            this.countryLabelShort.Name = "countryLabelShort";
            this.countryLabelShort.Size = new System.Drawing.Size(20, 13);
            this.countryLabelShort.TabIndex = 6;
            this.countryLabelShort.Text = "PL";
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.Location = new System.Drawing.Point(12, 154);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(168, 13);
            this.requestLabel.TabIndex = 8;
            this.requestLabel.Text = "Please choose appropriate option.";
            // 
            // countryRequesterLabelShort
            // 
            this.countryRequesterLabelShort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countryRequesterLabelShort.AutoSize = true;
            this.countryRequesterLabelShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.countryRequesterLabelShort.Location = new System.Drawing.Point(320, 94);
            this.countryRequesterLabelShort.Name = "countryRequesterLabelShort";
            this.countryRequesterLabelShort.Size = new System.Drawing.Size(20, 13);
            this.countryRequesterLabelShort.TabIndex = 13;
            this.countryRequesterLabelShort.Text = "PL";
            // 
            // countryRequesterComboBox
            // 
            this.countryRequesterComboBox.FormattingEnabled = true;
            this.countryRequesterComboBox.Location = new System.Drawing.Point(341, 67);
            this.countryRequesterComboBox.Name = "countryRequesterComboBox";
            this.countryRequesterComboBox.Size = new System.Drawing.Size(124, 21);
            this.countryRequesterComboBox.TabIndex = 12;
            this.countryRequesterComboBox.SelectedIndexChanged += new System.EventHandler(this.countryRequesterComboBox_SelectedIndexChanged);
            // 
            // countryRequesterLabel
            // 
            this.countryRequesterLabel.AutoSize = true;
            this.countryRequesterLabel.Location = new System.Drawing.Point(196, 70);
            this.countryRequesterLabel.Name = "countryRequesterLabel";
            this.countryRequesterLabel.Size = new System.Drawing.Size(128, 13);
            this.countryRequesterLabel.TabIndex = 11;
            this.countryRequesterLabel.Text = "Requester Member State:";
            // 
            // vatRequesterNumberLabel
            // 
            this.vatRequesterNumberLabel.AutoSize = true;
            this.vatRequesterNumberLabel.Location = new System.Drawing.Point(196, 94);
            this.vatRequesterNumberLabel.Name = "vatRequesterNumberLabel";
            this.vatRequesterNumberLabel.Size = new System.Drawing.Size(123, 13);
            this.vatRequesterNumberLabel.TabIndex = 10;
            this.vatRequesterNumberLabel.Text = "Requester VAT Number:";
            // 
            // vatNumberRequesterTextBox
            // 
            this.vatNumberRequesterTextBox.Location = new System.Drawing.Point(341, 91);
            this.vatNumberRequesterTextBox.MaxLength = 12;
            this.vatNumberRequesterTextBox.Name = "vatNumberRequesterTextBox";
            this.vatNumberRequesterTextBox.Size = new System.Drawing.Size(124, 20);
            this.vatNumberRequesterTextBox.TabIndex = 9;
            this.vatNumberRequesterTextBox.TextChanged += new System.EventHandler(this.vatNumberRequesterTextBox_TextChanged);
            // 
            // saveToFileButton
            // 
            this.saveToFileButton.Location = new System.Drawing.Point(12, 330);
            this.saveToFileButton.Name = "saveToFileButton";
            this.saveToFileButton.Size = new System.Drawing.Size(453, 23);
            this.saveToFileButton.TabIndex = 14;
            this.saveToFileButton.Text = "Save To File";
            this.saveToFileButton.UseVisualStyleBackColor = true;
            this.saveToFileButton.Click += new System.EventHandler(this.saveToFileButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ViesVatNumberValidation.Properties.Resources.logo_en;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 129);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BackColor = System.Drawing.Color.White;
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Location = new System.Drawing.Point(15, 154);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(450, 170);
            this.textBoxOutput.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(477, 361);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveToFileButton);
            this.Controls.Add(this.countryRequesterLabelShort);
            this.Controls.Add(this.countryRequesterComboBox);
            this.Controls.Add(this.countryRequesterLabel);
            this.Controls.Add(this.vatRequesterNumberLabel);
            this.Controls.Add(this.vatNumberRequesterTextBox);
            this.Controls.Add(this.requestLabel);
            this.Controls.Add(this.countryLabelShort);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.vatNumberLabel);
            this.Controls.Add(this.vatNumberTextBox);
            this.Controls.Add(this.advancedButton);
            this.Controls.Add(this.simpleButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VIES VAT number validation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveToFileButton;
        private System.Windows.Forms.Label countryRequesterLabelShort;
        private System.Windows.Forms.ComboBox countryRequesterComboBox;
        private System.Windows.Forms.Label countryRequesterLabel;
        private System.Windows.Forms.Label vatRequesterNumberLabel;
        private System.Windows.Forms.TextBox vatNumberRequesterTextBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label countryLabelShort;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label vatNumberLabel;
        private System.Windows.Forms.TextBox vatNumberTextBox;
        private System.Windows.Forms.Button advancedButton;
        private System.Windows.Forms.Button simpleButton;
        private System.Windows.Forms.TextBox textBoxOutput;

    }
}

