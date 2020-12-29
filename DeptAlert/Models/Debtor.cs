using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using DebtAlert.Controller;

namespace DebtAlert.Models
{
    public class Debtor
    {
        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Constructors. Empty Constructor is necessary for Serialization
        /// </summary>

        public Debtor(string firstName, string lastName, string nickname, string emailAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Nickname = nickname;
            this.EmailAddress = emailAddress;
        }

        public Debtor()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Nickname = "";
            this.EmailAddress = "";
        }
        #endregion

        //Used for filling ComboBox
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }
    }
}