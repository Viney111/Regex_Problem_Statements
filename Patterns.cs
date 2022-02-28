using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problem_Statements
{
    internal class Patterns
    {
        public static string RegexPinCode = "^[1-9][0-9]{5}$";
        public void ValidatePinCode(string pinCode)
        {
           string result = Regex.IsMatch(pinCode, RegexPinCode)? "PinCode entered is valid" : "PinCode entered is not valid";
           Console.WriteLine(result);
        }
    }
}
