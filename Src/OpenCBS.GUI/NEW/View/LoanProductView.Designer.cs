﻿namespace OpenCBS.GUI.NEW.View
{
    partial class LoanProductView
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
            this._tabControl = new System.Windows.Forms.TabControl();
            this._generalTabPage = new System.Windows.Forms.TabPage();
            this._scheduleComboBox = new System.Windows.Forms.ComboBox();
            this._scheduleLabel = new System.Windows.Forms.Label();
            this._availableForCompanyCheckBox = new System.Windows.Forms.CheckBox();
            this._availableForNsgCheckBox = new System.Windows.Forms.CheckBox();
            this._availableForSgCheckBox = new System.Windows.Forms.CheckBox();
            this._availableForIndividualCheckBox = new System.Windows.Forms.CheckBox();
            this._availableForLabel = new System.Windows.Forms.Label();
            this._paymentFrequencyComboBox = new System.Windows.Forms.ComboBox();
            this._codeTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._paymentFrequencyLabel = new System.Windows.Forms.Label();
            this._codeLabel = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this._okButton = new System.Windows.Forms.Button();
            this._cancelButton = new System.Windows.Forms.Button();
            this._yearComboBox = new System.Windows.Forms.ComboBox();
            this._yearLabel = new System.Windows.Forms.Label();
            this._tabControl.SuspendLayout();
            this._generalTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._generalTabPage);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(757, 371);
            this._tabControl.TabIndex = 0;
            // 
            // _generalTabPage
            // 
            this._generalTabPage.Controls.Add(this._yearComboBox);
            this._generalTabPage.Controls.Add(this._yearLabel);
            this._generalTabPage.Controls.Add(this._scheduleComboBox);
            this._generalTabPage.Controls.Add(this._scheduleLabel);
            this._generalTabPage.Controls.Add(this._availableForCompanyCheckBox);
            this._generalTabPage.Controls.Add(this._availableForNsgCheckBox);
            this._generalTabPage.Controls.Add(this._availableForSgCheckBox);
            this._generalTabPage.Controls.Add(this._availableForIndividualCheckBox);
            this._generalTabPage.Controls.Add(this._availableForLabel);
            this._generalTabPage.Controls.Add(this._paymentFrequencyComboBox);
            this._generalTabPage.Controls.Add(this._codeTextBox);
            this._generalTabPage.Controls.Add(this._nameTextBox);
            this._generalTabPage.Controls.Add(this._paymentFrequencyLabel);
            this._generalTabPage.Controls.Add(this._codeLabel);
            this._generalTabPage.Controls.Add(this._nameLabel);
            this._generalTabPage.Location = new System.Drawing.Point(4, 25);
            this._generalTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._generalTabPage.Name = "_generalTabPage";
            this._generalTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._generalTabPage.Size = new System.Drawing.Size(749, 342);
            this._generalTabPage.TabIndex = 0;
            this._generalTabPage.Text = "General";
            this._generalTabPage.UseVisualStyleBackColor = true;
            // 
            // _scheduleComboBox
            // 
            this._scheduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._scheduleComboBox.FormattingEnabled = true;
            this._scheduleComboBox.Location = new System.Drawing.Point(147, 223);
            this._scheduleComboBox.Name = "_scheduleComboBox";
            this._scheduleComboBox.Size = new System.Drawing.Size(209, 24);
            this._scheduleComboBox.TabIndex = 12;
            // 
            // _scheduleLabel
            // 
            this._scheduleLabel.AutoSize = true;
            this._scheduleLabel.Location = new System.Drawing.Point(12, 226);
            this._scheduleLabel.Name = "_scheduleLabel";
            this._scheduleLabel.Size = new System.Drawing.Size(62, 16);
            this._scheduleLabel.TabIndex = 11;
            this._scheduleLabel.Text = "Schedule";
            // 
            // _availableForCompanyCheckBox
            // 
            this._availableForCompanyCheckBox.AutoSize = true;
            this._availableForCompanyCheckBox.Location = new System.Drawing.Point(147, 197);
            this._availableForCompanyCheckBox.Name = "_availableForCompanyCheckBox";
            this._availableForCompanyCheckBox.Size = new System.Drawing.Size(82, 20);
            this._availableForCompanyCheckBox.TabIndex = 10;
            this._availableForCompanyCheckBox.Text = "Company";
            this._availableForCompanyCheckBox.UseVisualStyleBackColor = true;
            // 
            // _availableForNsgCheckBox
            // 
            this._availableForNsgCheckBox.AutoSize = true;
            this._availableForNsgCheckBox.Location = new System.Drawing.Point(147, 171);
            this._availableForNsgCheckBox.Name = "_availableForNsgCheckBox";
            this._availableForNsgCheckBox.Size = new System.Drawing.Size(142, 20);
            this._availableForNsgCheckBox.TabIndex = 9;
            this._availableForNsgCheckBox.Text = "Non-solidarity group";
            this._availableForNsgCheckBox.UseVisualStyleBackColor = true;
            // 
            // _availableForSgCheckBox
            // 
            this._availableForSgCheckBox.AutoSize = true;
            this._availableForSgCheckBox.Location = new System.Drawing.Point(147, 145);
            this._availableForSgCheckBox.Name = "_availableForSgCheckBox";
            this._availableForSgCheckBox.Size = new System.Drawing.Size(117, 20);
            this._availableForSgCheckBox.TabIndex = 8;
            this._availableForSgCheckBox.Text = "Solidarity group";
            this._availableForSgCheckBox.UseVisualStyleBackColor = true;
            // 
            // _availableForIndividualCheckBox
            // 
            this._availableForIndividualCheckBox.AutoSize = true;
            this._availableForIndividualCheckBox.Location = new System.Drawing.Point(147, 119);
            this._availableForIndividualCheckBox.Name = "_availableForIndividualCheckBox";
            this._availableForIndividualCheckBox.Size = new System.Drawing.Size(79, 20);
            this._availableForIndividualCheckBox.TabIndex = 7;
            this._availableForIndividualCheckBox.Text = "Individual";
            this._availableForIndividualCheckBox.UseVisualStyleBackColor = true;
            // 
            // _availableForLabel
            // 
            this._availableForLabel.AutoSize = true;
            this._availableForLabel.Location = new System.Drawing.Point(12, 119);
            this._availableForLabel.Name = "_availableForLabel";
            this._availableForLabel.Size = new System.Drawing.Size(77, 16);
            this._availableForLabel.TabIndex = 6;
            this._availableForLabel.Text = "Available for";
            // 
            // _paymentFrequencyComboBox
            // 
            this._paymentFrequencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._paymentFrequencyComboBox.FormattingEnabled = true;
            this._paymentFrequencyComboBox.Location = new System.Drawing.Point(147, 81);
            this._paymentFrequencyComboBox.Name = "_paymentFrequencyComboBox";
            this._paymentFrequencyComboBox.Size = new System.Drawing.Size(209, 24);
            this._paymentFrequencyComboBox.TabIndex = 5;
            // 
            // _codeTextBox
            // 
            this._codeTextBox.Location = new System.Drawing.Point(147, 48);
            this._codeTextBox.Name = "_codeTextBox";
            this._codeTextBox.Size = new System.Drawing.Size(209, 22);
            this._codeTextBox.TabIndex = 3;
            // 
            // _nameTextBox
            // 
            this._nameTextBox.Location = new System.Drawing.Point(147, 15);
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(209, 22);
            this._nameTextBox.TabIndex = 1;
            // 
            // _paymentFrequencyLabel
            // 
            this._paymentFrequencyLabel.AutoSize = true;
            this._paymentFrequencyLabel.Location = new System.Drawing.Point(12, 84);
            this._paymentFrequencyLabel.Name = "_paymentFrequencyLabel";
            this._paymentFrequencyLabel.Size = new System.Drawing.Size(120, 16);
            this._paymentFrequencyLabel.TabIndex = 4;
            this._paymentFrequencyLabel.Text = "Payment frequency";
            // 
            // _codeLabel
            // 
            this._codeLabel.AutoSize = true;
            this._codeLabel.Location = new System.Drawing.Point(12, 51);
            this._codeLabel.Name = "_codeLabel";
            this._codeLabel.Size = new System.Drawing.Size(38, 16);
            this._codeLabel.TabIndex = 2;
            this._codeLabel.Text = "Code";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(12, 18);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(42, 16);
            this._nameLabel.TabIndex = 0;
            this._nameLabel.Text = "Name";
            // 
            // _okButton
            // 
            this._okButton.Location = new System.Drawing.Point(539, 384);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(100, 26);
            this._okButton.TabIndex = 1;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _cancelButton
            // 
            this._cancelButton.Location = new System.Drawing.Point(645, 384);
            this._cancelButton.Name = "_cancelButton";
            this._cancelButton.Size = new System.Drawing.Size(100, 26);
            this._cancelButton.TabIndex = 2;
            this._cancelButton.Text = "Cancel";
            this._cancelButton.UseVisualStyleBackColor = true;
            // 
            // _yearComboBox
            // 
            this._yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._yearComboBox.FormattingEnabled = true;
            this._yearComboBox.Location = new System.Drawing.Point(147, 253);
            this._yearComboBox.Name = "_yearComboBox";
            this._yearComboBox.Size = new System.Drawing.Size(209, 24);
            this._yearComboBox.TabIndex = 14;
            // 
            // _yearLabel
            // 
            this._yearLabel.AutoSize = true;
            this._yearLabel.Location = new System.Drawing.Point(12, 256);
            this._yearLabel.Name = "_yearLabel";
            this._yearLabel.Size = new System.Drawing.Size(34, 16);
            this._yearLabel.TabIndex = 13;
            this._yearLabel.Text = "Year";
            // 
            // LoanProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 422);
            this.Controls.Add(this._cancelButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._tabControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoanProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan product";
            this._tabControl.ResumeLayout(false);
            this._generalTabPage.ResumeLayout(false);
            this._generalTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _generalTabPage;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _cancelButton;
        private System.Windows.Forms.Label _codeLabel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.Label _paymentFrequencyLabel;
        private System.Windows.Forms.TextBox _codeTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        private System.Windows.Forms.ComboBox _paymentFrequencyComboBox;
        private System.Windows.Forms.CheckBox _availableForCompanyCheckBox;
        private System.Windows.Forms.CheckBox _availableForNsgCheckBox;
        private System.Windows.Forms.CheckBox _availableForSgCheckBox;
        private System.Windows.Forms.CheckBox _availableForIndividualCheckBox;
        private System.Windows.Forms.Label _availableForLabel;
        private System.Windows.Forms.ComboBox _scheduleComboBox;
        private System.Windows.Forms.Label _scheduleLabel;
        private System.Windows.Forms.ComboBox _yearComboBox;
        private System.Windows.Forms.Label _yearLabel;
    }
}