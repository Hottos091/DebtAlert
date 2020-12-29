using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace DebtAlert.Models
{
    public static class Utils
    {
        //public static string path = @"C:\Users\Utilisateur\OneDrive\Projets\C#\DebtAlert\DebtAlert\people.txt";
        #pragma warning disable CA2211 // Non-constant fields should not be visible
        public static string debtorsPath = Path.Combine(Environment.CurrentDirectory, @"../../debtors.txt");
        public static string debtsPath = Path.Combine(Environment.CurrentDirectory, @"../../debts.txt");
#pragma warning restore CA2211 // Non-constant fields should not be visible

        #region JSON (De)Serializing
        public static string SerializePersonToJSON(Debtor person){
            return JsonConvert.SerializeObject(person);
        }

        public static Debtor DeserializeJSONToPerson(string jsonPerson){
            return JsonConvert.DeserializeObject<Debtor>(jsonPerson);
        }

        #endregion

        public static void SwapForm(Form formToClose, Form formToShow)
        {
            if(formToClose != null && formToShow != null)
            {
                formToClose.Hide();
                formToShow.ShowDialog();
                formToClose.Close();
            }
        }

        public static bool TextBoxValidating(TextBox textBox)
        {
            if (textBox != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Please enter letters only");
                    return false;
                }

                if (string.IsNullOrEmpty(textBox.Text))
                {
                    MessageBox.Show("Please fill the fields");
                    return false;
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}