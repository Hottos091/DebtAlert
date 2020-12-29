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
using DebtAlert.Views;

namespace DebtAlert.Views
{
    public partial class WelcomeView : Form
    {
        public WelcomeView()
        {
            InitializeComponent();
            
        }

        private void AddDebtorViewButton_Click(object sender, EventArgs e)
        {
            Utils.SwapForm(this, new AddPersonView());
        }

        private void DeleteDebtorViewButton_Click(object sender, EventArgs e)
        {
            Utils.SwapForm(this, new DeleteDebtorView());
        }

        private void NewDebtViewButton_Click(object sender, EventArgs e)
        {
            Utils.SwapForm(this, new NewDebtView());
        }
    }
}
