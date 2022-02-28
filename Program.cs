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
            Patterns patterns = new Patterns();
            Console.Write("Enter the pin code : ");
            string pinCode = Console.ReadLine();
            patterns.ValidatePinCode(pinCode);  
        }
    }
}
