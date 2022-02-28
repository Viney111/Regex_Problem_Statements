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
            Console.Write("Enter eMail Address : ");
            string email = Console.ReadLine();  
            email_Patterns.ValidateEmailAddress(email);
        }
    }
}
