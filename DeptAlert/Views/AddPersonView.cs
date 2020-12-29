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
using DebtAlert.Controller;

namespace DebtAlert.Views
{
    internal partial class AddPersonView : Form
    {
        public AddPersonView()
        {
            InitializeComponent();
        }

        ApplicationController applicationController = new ApplicationController();

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddDebtorButton_Click(object sender, EventArgs e)
        {
            //Will be false if one of the validation returns false
            if (Utils.TextBoxValidating(FirstNameTextBox) &&
               Utils.TextBoxValidating(LastNameTextBox) &&
               Utils.TextBoxValidating(NicknameTextBox) &&
               EmailTextBox_Validating(EmailAddressTextBox))
            {
                //Boolean equals True
                Debtor newDebtor = new Debtor(FirstNameTextBox.Text, LastNameTextBox.Text, NicknameTextBox.Text, EmailAddressTextBox.Text);
                applicationController.AddDebtorToJSONFile(newDebtor);

                MessageBox.Show("New Debtor added to database");
                //Change View
                Utils.SwapForm(this, new WelcomeView());
            }
        }

        private bool TextBox_Validating(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Please enter letters only");
                return false;
            } 

            if(string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Please fill the fields");
                return false;
            }

            return true;
        }
        private bool EmailTextBox_Validating(TextBox textBox)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^[a-zA-Z@._-]+$"))
            {
                MessageBox.Show("Please enter valid characters only for your email address :@._-");
                return false;
            }

            return true;
        }

    }
}
