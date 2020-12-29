namespace DebtAlert.Views
{
    partial class WelcomeView
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
            this.AddDebtorViewButton = new System.Windows.Forms.Button();
            this.DeleteDebtorViewButton = new System.Windows.Forms.Button();
            this.NewDebtViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDebtorViewButton
            // 
            this.AddDebtorViewButton.Location = new System.Drawing.Point(221, 178);
            this.AddDebtorViewButton.Name = "AddDebtorViewButton";
            this.AddDebtorViewButton.Size = new System.Drawing.Size(98, 23);
            this.AddDebtorViewButton.TabIndex = 0;
            this.AddDebtorViewButton.Text = "Add new Debtor";
            this.AddDebtorViewButton.UseVisualStyleBackColor = true;
            this.AddDebtorViewButton.Click += new System.EventHandler(this.AddDebtorViewButton_Click);
            // 
            // DeleteDebtorViewButton
            // 
            this.DeleteDebtorViewButton.Location = new System.Drawing.Point(221, 230);
            this.DeleteDebtorViewButton.Name = "DeleteDebtorViewButton";
            this.DeleteDebtorViewButton.Size = new System.Drawing.Size(98, 23);
            this.DeleteDebtorViewButton.TabIndex = 0;
            this.DeleteDebtorViewButton.Text = "Delete Debtor";
            this.DeleteDebtorViewButton.UseVisualStyleBackColor = true;
            this.DeleteDebtorViewButton.Click += new System.EventHandler(this.DeleteDebtorViewButton_Click);
            // 
            // NewDebtViewButton
            // 
            this.NewDebtViewButton.Location = new System.Drawing.Point(221, 287);
            this.NewDebtViewButton.Name = "NewDebtViewButton";
            this.NewDebtViewButton.Size = new System.Drawing.Size(98, 23);
            this.NewDebtViewButton.TabIndex = 1;
            this.NewDebtViewButton.Text = "New Debt";
            this.NewDebtViewButton.UseVisualStyleBackColor = true;
            this.NewDebtViewButton.Click += new System.EventHandler(this.NewDebtViewButton_Click);
            // 
            // WelcomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 451);
            this.Controls.Add(this.NewDebtViewButton);
            this.Controls.Add(this.DeleteDebtorViewButton);
            this.Controls.Add(this.AddDebtorViewButton);
            this.Name = "WelcomeView";
            this.Text = "WelcomeView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddDebtorViewButton;
        private System.Windows.Forms.Button DeleteDebtorViewButton;
        private System.Windows.Forms.Button NewDebtViewButton;
    }
}