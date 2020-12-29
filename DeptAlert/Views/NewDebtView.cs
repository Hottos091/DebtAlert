using DebtAlert.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtAlert.Models;
using System.Globalization;

namespace DebtAlert.Views
{
    public partial class NewDebtView : Form
    {
        ApplicationController applicationController = new ApplicationController();
        public NewDebtView()
        {
            InitializeComponent();
        }

        private void NewDebtView_Load(object sender, EventArgs e)
        {
            applicationController.InitializeComboBoxWithAllDebtors(this.CreditorsComboBox);
            applicationController.InitializeComboBoxWithAllDebtors(this.DebtorsComboBox);
        }

        private void AddDebtButton_Click(object sender, EventArgs e)
        {
            //Create new Debt
            Debtor debtor = (Debtor)this.DebtorsComboBox.SelectedItem;
            Debtor creditor = (Debtor)this.CreditorsComboBox.SelectedItem;
            CultureInfo cultureInfo = new CultureInfo("fr-BE");
            
            Debt newDebt = new Debt(debtor, creditor, Convert.ToDecimal(this.DebtAmountTextBox.Text, cultureInfo));
            //Save Debt to file
            MessageBox.Show(applicationController.AddDebtToJSONFile(newDebt));

            Utils.SwapForm(this, new WelcomeView());
        }
    }
}
