using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtAlert.Models;
using Newtonsoft.Json;

namespace DebtAlert.DataAccess
{
    class DebtorDA
    {

        #region Debtor
        public List<Debtor> GetAllDebtorsFromJSONFile()
        {
            StreamReader file = new StreamReader(Utils.debtorsPath);
            List<Debtor> people = new List<Debtor>();
            string line;

            while ((line = file.ReadLine()) != null)
            {
                Debtor newPerson = JsonConvert.DeserializeObject<Debtor>(line);

                people.Add(newPerson);
            }
            file.Close();

            return people;
        }

        public void InitializeComboBoxWithAllDebtors(ComboBox comboBox)
        {
            List<Debtor> debtors = GetAllDebtorsFromJSONFile();

            comboBox.DataSource = debtors;
            comboBox.DisplayMember = "FullName";
            comboBox.ValueMember = "EmailAddress";

            //Makes it readonly
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void AddDebtorToJSONFile(Debtor debtorToAdd)
        {
            //Describe how a Debtor will be formatted as
            using (StreamWriter file = File.AppendText(Utils.debtorsPath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, debtorToAdd);
                file.WriteLine("");
            }
        }

        //Will be transformed to add Debtor to database at creation in the future --> TODO
        public Debtor CreateDebtor(string firstName, string lastName, string nickname, string emailAddress)
        {
            Debtor newDebtor = new Debtor(firstName, lastName, nickname, emailAddress);

            return newDebtor;
        }

        //Create back all the Debtors contained in file, and skip when debtorInFile equals debtorToDelete
        //Will later be an sql query (DELETE... Where email = debtorToDelete.email)
        public string DeleteDebtor(Debtor debtorToDelete)
        {
            List<Debtor> debtors = GetAllDebtorsFromJSONFile();

            Debtor debtorFound = GetDebtor(debtorToDelete);

            if (debtorFound != null)
            {
                debtors.Remove(debtorFound);
                //Make file empty
                //TODO : Should save a copy of file if smth bad happens
                File.WriteAllText(Utils.debtorsPath, string.Empty);

                //Re-write all debtors without debtorToDelete to file
                debtors.ForEach(debtor => AddDebtorToJSONFile(debtor));

                return "Removed Successfully !";
            }
            else
            {
                return "An error occurred.";
            }

            
        }

        public Debtor GetDebtor(Debtor debtorToFind)
        {
            //Get all debtors to find the good one
            List<Debtor> debtors = GetAllDebtorsFromJSONFile();

            return debtors.Find(debtor => debtor.EmailAddress.Equals(debtorToFind.EmailAddress));
        }
        #endregion
    }
}
