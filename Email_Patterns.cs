using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problem_Statements
{   
    internal class Email_Patterns
    {
        public static string emailAddressUC1 = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";//UC6

        public void ValidateEmailAddress(string[] emails)
        {
            foreach(string email in emails)
            {
                string result = Regex.IsMatch(email, emailAddressUC1) ? $"{email} entered is valid" : $"{email} entered is Invalid";

                Console.WriteLine(result);
            }

        }
    }
}
