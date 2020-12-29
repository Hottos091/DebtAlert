using DebtAlert.Models;

namespace DebtAlert.Views
{
    partial class DeleteDebtorView
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
            this.AllDebtorsComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteDebtorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllDebtorsComboBox
            // 
            this.AllDebtorsComboBox.FormattingEnabled = true;
            this.AllDebtorsComboBox.Location = new System.Drawing.Point(193, 179);
            this.AllDebtorsComboBox.Name = "AllDebtorsComboBox";
            this.AllDebtorsComboBox.Size = new System.Drawing.Size(121, 21);
            this.AllDebtorsComboBox.TabIndex = 0;
            // 
            // DeleteDebtorButton
            // 
            this.DeleteDebtorButton.Location = new System.Drawing.Point(357, 333);
            this.DeleteDebtorButton.Name = "DeleteDebtorButton";
            this.DeleteDebtorButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteDebtorButton.TabIndex = 1;
            this.DeleteDebtorButton.Text = "Delete";
            this.DeleteDebtorButton.UseVisualStyleBackColor = true;
            this.DeleteDebtorButton.Click += new System.EventHandler(this.DeleteDebtorButton_Click);
            // 
            // DeleteDebtorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.DeleteDebtorButton);
            this.Controls.Add(this.AllDebtorsComboBox);
            this.Location = new System.Drawing.Point(250, 200);
            this.Name = "DeleteDebtorView";
            this.Text = "DeleteDebtor";
            this.Load += new System.EventHandler(this.DeleteDebtorView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox AllDebtorsComboBox;
        private System.Windows.Forms.Button DeleteDebtorButton;
    }
}