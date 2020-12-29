using DebtAlert.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtAlert.DataAccess
{
    class DebtDA
    {
        public string AddDebtToJSONFile(Debt debtToAdd)
        {
            //Describe how a Debtor will be formatted as
            try
            {
                using (StreamWriter file = File.AppendText(Utils.debtsPath))
                {
                    /*JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, debtToAdd);
                    file.WriteLine("");*/

                    string jsonString = JsonConvert.SerializeObject(debtToAdd);
                    file.WriteLine(jsonString);
                    file.WriteLine("");
                }


                return "Debt added successfully !";
            }
            catch (IOException e)
            {
                return "An exception occurred : " +  e.Message;
            }
        }
    }
}
