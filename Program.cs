using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Regex_Problem_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email_Patterns email_Patterns = new Email_Patterns();
            string[] checkingEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com","abc-100@abc.net", "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com" }; 
            email_Patterns.ValidateEmailAddress(checkingEmails);
        }
    }
}
