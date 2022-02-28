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
            //Calling object of the PinCode Pattern Class.
            PinCodePatterns pinCodePatterns = new PinCodePatterns();
            Console.Write("Enter the pin code : ");
            string pinCode = Console.ReadLine();

            pinCodePatterns.ValidatePinCode(pinCode);  
        }
    }
}
