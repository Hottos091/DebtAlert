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
using DebtAlert.Controller;

namespace DebtAlert.Views
{
    public partial class DeleteDebtorView : Form
    {
        ApplicationController applicationController = new ApplicationController();
        public DeleteDebtorView()
        {
            InitializeComponent();
        }

        private void DeleteDebtorView_Load(object sender, EventArgs e)
        {
            applicationController.InitializeComboBoxWithAllDebtors(this.AllDebtorsComboBox);
        }

        private void DeleteDebtorButton_Click(object sender, EventArgs e)
        {
            string message = applicationController.DeleteDebtor((Debtor)this.AllDebtorsComboBox.SelectedItem);

            MessageBox.Show(message);

            Utils.SwapForm(this, new WelcomeView());
        }
    }
}
