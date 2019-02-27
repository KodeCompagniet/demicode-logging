namespace e4subsea.Logging.Exceptions
{
    partial class UserFeedbackForm
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

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Windows.Forms", "2.0.0.0")]
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ErrorTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.AdditionalInformationTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._cancelButton = new System.Windows.Forms.Button();
            this._copyToClipboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(211, 349);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(104, 23);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ErrorTextbox
            // 
            this.ErrorTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorTextbox.Location = new System.Drawing.Point(12, 224);
            this.ErrorTextbox.Multiline = true;
            this.ErrorTextbox.Name = "ErrorTextbox";
            this.ErrorTextbox.ReadOnly = true;
            this.ErrorTextbox.Size = new System.Drawing.Size(626, 119);
            this.ErrorTextbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "An unexpected error have occured. Click Submit to send the following information " +
                               "to 4Subsea.";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                                | System.Windows.Forms.AnchorStyles.Right)));
            this.UsernameTextbox.Location = new System.Drawing.Point(53, 35);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(585, 20);
            this.UsernameTextbox.TabIndex = 4;
            // 
            // AdditionalInformationTextBox
            // 
            this.AdditionalInformationTextBox.AcceptsReturn = true;
            this.AdditionalInformationTextBox.AcceptsTab = true;
            this.AdditionalInformationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                                              | System.Windows.Forms.AnchorStyles.Left)
                                                                                             | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionalInformationTextBox.Location = new System.Drawing.Point(12, 80);
            this.AdditionalInformationTextBox.Multiline = true;
            this.AdditionalInformationTextBox.Name = "AdditionalInformationTextBox";
            this.AdditionalInformationTextBox.Size = new System.Drawing.Size(626, 121);
            this.AdditionalInformationTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Additional information, e.g. what did you do before experiencing the problem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Error details:";
            // 
            // _cancelButton
            // 
            this._cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                                                                              | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelButton.Location = new System.Drawing.Point(321, 349);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(99, 23);
            this._cancelButton.TabIndex = 9;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _copyToClipboardButton
            // 
            this._copyToClipboardButton.Location = new System.Drawing.Point(12, 349);
            this._copyToClipboardButton.Name = "_copyToClipboardButton";
            this._copyToClipboardButton.Size = new System.Drawing.Size(110, 23);
            this._copyToClipboardButton.TabIndex = 10;
            this._copyToClipboardButton.Text = "Copy to Clipboard";
            this._copyToClipboardButton.UseVisualStyleBackColor = true;
            this._copyToClipboardButton.Click += new System.EventHandler(this._copyToClipboardButton_Click);
            // 
            // UserFeedbackForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelButton;
            this.ClientSize = new System.Drawing.Size(650, 384);
            this.ControlBox = false;
            this.Controls.Add(this._copyToClipboardButton);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AdditionalInformationTextBox);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorTextbox);
            this.Controls.Add(this.SubmitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UserFeedbackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "An unexpected error occured";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ErrorTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.TextBox AdditionalInformationTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Button _copyToClipboardButton;
    }
}