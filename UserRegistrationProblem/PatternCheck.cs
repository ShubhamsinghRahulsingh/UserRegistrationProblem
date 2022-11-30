using System;
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
        const string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string Email = "^[a-z]{3,}[.]{0,}[a-z]{0,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{0,}[a-z]{0,}$";
        const string mobileNumber = "^91[ ]{1}[5-9]{1}[0-9]{9}$";
        const string password = "^[a-zA-z]{8,}$";
        public void ValidateFirstName(string input)
        {
            if(Regex.IsMatch(input, firstName))
                Console.WriteLine("Your First name is  "+input);
            else
                Console.WriteLine("Entered name is in invalid format.Try again ");
        }
        public void ValidateLastName(string input)
        {
            if (Regex.IsMatch(input, lastName))
                Console.WriteLine("Your Last name is  " + input);
            else
                Console.WriteLine("Entered name is in invalid format.");
        }
        public void ValidateEmail(string input)
        {
            if (Regex.IsMatch(input, Email))
                Console.WriteLine("Your Email Id is  " + input);
            else
                Console.WriteLine("Entered Email is in invalid format.");
        }
        public void ValidateMobileNumber(string input)
        {
            if (Regex.IsMatch(input, mobileNumber))
                Console.WriteLine("Your Mobile Number is  " + input);
            else
                Console.WriteLine("Entered Mobile Number is in invalid format.");
        }
        public void ValidatePassword(string input)
        {
            if (Regex.IsMatch(input, password))
                Console.WriteLine("Your Password is Correct ");
            else
                Console.WriteLine("Entered Password is in invalid format.");
        }
    }
}
