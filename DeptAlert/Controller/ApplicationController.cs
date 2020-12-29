using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebtAlert.DataAccess;
using DebtAlert.Models;

namespace DebtAlert.Controller
{
    class ApplicationController
    {
        private DebtorDA debtorDA = new DebtorDA();
        private DebtDA debtDA = new DebtDA();

        #region Debtor
        public List<Debtor> GetAllDebtorsFromJSONFile()
        {
            return debtorDA.GetAllDebtorsFromJSONFile();
        }

        public void AddDebtorToJSONFile(Debtor debtorToAdd)
        {
            debtorDA.AddDebtorToJSONFile(debtorToAdd);
        }

        public Debtor CreateDebtor(string firstName, string lastName, string nickname, string emailAddress)
        {
            return debtorDA.CreateDebtor(firstName, lastName, nickname, emailAddress);
        }

        public string DeleteDebtor(Debtor debtorToDelete)
        {
            return debtorDA.DeleteDebtor(debtorToDelete);
        }

        public void InitializeComboBoxWithAllDebtors(ComboBox comboBox)
        {
            debtorDA.InitializeComboBoxWithAllDebtors(comboBox);
        }
        #endregion

        #region Debt
        public string AddDebtToJSONFile(Debt debtToAdd)
        {
            return debtDA.AddDebtToJSONFile(debtToAdd);
        }


        #endregion
    }
}
