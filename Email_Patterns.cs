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
        public static string emailAddressUC1 = @"^[a-zA-Z0-9]{3,}(([.|-|+|_]?)([a-zA-Z0-9]{1,}))?@bridgelabz.co$";//UC4

        public void ValidateEmailAddress(string email)
        {
            string result = Regex.IsMatch(email, emailAddressUC1) ? "Email entered is valid" : "Email entered is Invalid";
            Console.WriteLine(result);
        }
    }
}
