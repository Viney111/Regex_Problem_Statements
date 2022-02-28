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
            string[] checkingEmails = { "abc.xyz@bridgelabz.co", "abc@bridgelabz.co", "abcds.gdfr@bridgelabz.co.in", "abcds.gdfr@bridgelabz.co.ini" }; 
            email_Patterns.ValidateEmailAddress(checkingEmails);
        }
    }
}
