using System;

namespace DebtAlert.Models
{
    public class Debt
    {
        public DateTime DebtCreationDate {get;set;}
        public Debtor Debtor { get; set; }
        public Debtor Creditor { get; set; }
        public decimal MoneyAmout { get; set; }
        public DateTime PaybackDate { get; set; }

        public Debt(Debtor debtor, Debtor creditor, decimal moneyAmount){
            this.DebtCreationDate = DateTime.Now;
            this.Debtor = debtor;
            this.Creditor = creditor;
            this.MoneyAmout = moneyAmount;
            this.PaybackDate = new DateTime(1999, 1, 1, 1, 0, 0, 1);
        }
    }
}