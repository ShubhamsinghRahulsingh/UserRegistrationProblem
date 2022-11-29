﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class PatternCheck
    {
        const string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public void ValidateFirstName(string input)
        {
            if(Regex.IsMatch(input, firstName))
                Console.WriteLine("Your First name is  "+input);
            else
                Console.WriteLine("Entered name is in invalid format.Try again ");
        }
    }
}
