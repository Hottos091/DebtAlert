using System;
using System.Collections.Generic; 

namespace DebtAlert.Models
{
    public class DebtsDetails
    {
        private decimal MoneyAmout {get;set;}
        private DateTime PaybackDate {get;set;}
        private List<Debtor> People {get;set;}

        public DebtsDetails(decimal moneyAmount, DateTime paybackDate){
            this.MoneyAmout = moneyAmount;
            this.PaybackDate = paybackDate;
        }

    }
}