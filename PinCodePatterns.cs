﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problem_Statements
{
    internal class PinCodePatterns
    {
        public static string RegexPinCode = "^[1-9][0-9]{5}$"; //UC1

        public string PincodeWithRestrictionAtFirstLetter = @"^![a-z A-z #$%]^[1-9][0-9]{5}$"; //UC2
        public void ValidatePinCode(string pinCode)
        {
           string result = Regex.IsMatch(pinCode, PincodeWithRestrictionAtFirstLetter)? "PinCode entered is valid" : "PinCode entered is Invalid";
           Console.WriteLine(result);
        }
    }
}