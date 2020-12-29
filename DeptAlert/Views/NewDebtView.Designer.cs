namespace DebtAlert.Views
{
    partial class NewDebtView
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
            this.CreditorLabel = new System.Windows.Forms.Label();
            this.CreditorsComboBox = new System.Windows.Forms.ComboBox();
            this.DebtAmountTextBox = new System.Windows.Forms.TextBox();
            this.DebtAmountLabel = new System.Windows.Forms.Label();
            this.DebtorLabel = new System.Windows.Forms.Label();
            this.DebtorsComboBox = new System.Windows.Forms.ComboBox();
            this.AddDebtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreditorLabel
            // 
            this.CreditorLabel.AutoSize = true;
            this.CreditorLabel.Location = new System.Drawing.Point(53, 122);
            this.CreditorLabel.Name = "CreditorLabel";
            this.CreditorLabel.Size = new System.Drawing.Size(49, 13);
            this.CreditorLabel.TabIndex = 0;
            this.CreditorLabel.Text = "Creditor :";
            // 
            // CreditorsComboBox
            // 
            this.CreditorsComboBox.FormattingEnabled = true;
            this.CreditorsComboBox.Location = new System.Drawing.Point(117, 119);
            this.CreditorsComboBox.Name = "CreditorsComboBox";
            this.CreditorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.CreditorsComboBox.TabIndex = 1;
            // 
            // DebtAmountTextBox
            // 
            this.DebtAmountTextBox.Location = new System.Drawing.Point(138, 210);
            this.DebtAmountTextBox.Name = "DebtAmountTextBox";
            this.DebtAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.DebtAmountTextBox.TabIndex = 2;
            // 
            // DebtAmountLabel
            // 
            this.DebtAmountLabel.AutoSize = true;
            this.DebtAmountLabel.Location = new System.Drawing.Point(53, 213);
            this.DebtAmountLabel.Name = "DebtAmountLabel";
            this.DebtAmountLabel.Size = new System.Drawing.Size(78, 13);
            this.DebtAmountLabel.TabIndex = 0;
            this.DebtAmountLabel.Text = "Debt Amount : ";
            // 
            // DebtorLabel
            // 
            this.DebtorLabel.AutoSize = true;
            this.DebtorLabel.Location = new System.Drawing.Point(309, 122);
            this.DebtorLabel.Name = "DebtorLabel";
            this.DebtorLabel.Size = new System.Drawing.Size(48, 13);
            this.DebtorLabel.TabIndex = 0;
            this.DebtorLabel.Text = "Debtor : ";
            // 
            // DebtorsComboBox
            // 
            this.DebtorsComboBox.FormattingEnabled = true;
            this.DebtorsComboBox.Location = new System.Drawing.Point(373, 119);
            this.DebtorsComboBox.Name = "DebtorsComboBox";
            this.DebtorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.DebtorsComboBox.TabIndex = 1;
            // 
            // AddDebtButton
            // 
            this.AddDebtButton.Location = new System.Drawing.Point(419, 364);
            this.AddDebtButton.Name = "AddDebtButton";
            this.AddDebtButton.Size = new System.Drawing.Size(75, 23);
            this.AddDebtButton.TabIndex = 3;
            this.AddDebtButton.Text = "Add Debt";
            this.AddDebtButton.UseVisualStyleBackColor = true;
            this.AddDebtButton.Click += new System.EventHandler(this.AddDebtButton_Click);
            // 
            // NewDebtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.AddDebtButton);
            this.Controls.Add(this.DebtAmountTextBox);
            this.Controls.Add(this.DebtorsComboBox);
            this.Controls.Add(this.CreditorsComboBox);
            this.Controls.Add(this.DebtAmountLabel);
            this.Controls.Add(this.DebtorLabel);
            this.Controls.Add(this.CreditorLabel);
            this.Name = "NewDebtView";
            this.Text = "NewDebtView";
            this.Load += new System.EventHandler(this.NewDebtView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CreditorLabel;
        private System.Windows.Forms.ComboBox CreditorsComboBox;
        private System.Windows.Forms.TextBox DebtAmountTextBox;
        private System.Windows.Forms.Label DebtAmountLabel;
        private System.Windows.Forms.Label DebtorLabel;
        private System.Windows.Forms.ComboBox DebtorsComboBox;
        private System.Windows.Forms.Button AddDebtButton;
    }
}