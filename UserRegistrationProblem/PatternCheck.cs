using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem
{
    public class PatternCheck
    {
        string[] emailsData;
        const string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        const string email = "^[a-z]{3,}[.]{0,}[a-z]{0,}[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}[.]{0,}[a-z]{0,}$";
        const string mobileNumber = "^91[ ]{1}[5-9]{1}[0-9]{9}$";
        const string password = "^(?=.*[!@#$%_])(?=.*[0-9])(?=.*[A-Z])[A-Za-z0-9!@#_$%]{8,}$";
        const string emailsCheck = "^[a-zA-Z]+[.+_-]{0,1}[a-z0-9]+[@][a-zA-Z0-9]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
        //public void ValidateFirstName(string input)
        //{
        //    if(Regex.IsMatch(input, firstName))
        //        Console.WriteLine("Your First name is  "+input);
        //    else
        //        Console.WriteLine("Entered name is in invalid format.Try again ");
        //}
        //public void ValidateLastName(string input)
        //{
        //    if (Regex.IsMatch(input, lastName))
        //        Console.WriteLine("Your Last name is  " + input);
        //    else
        //        Console.WriteLine("Entered name is in invalid format.");
        //}
        //public void ValidateEmail(string input)
        //{
        //    if (Regex.IsMatch(input, email))
        //        Console.WriteLine("Your Email Id is  " + input);
        //    else
        //        Console.WriteLine("Entered Email is in invalid format.");
        //}
        //public void ValidateMobileNumber(string input)
        //{
        //    if (Regex.IsMatch(input, mobileNumber))
        //        Console.WriteLine("Your Mobile Number is  " + input);
        //    else
        //        Console.WriteLine("Entered Mobile Number is in invalid format.");
        //}
        //public void ValidatePassword(string input)
        //{
        //    if (Regex.IsMatch(input, password))
        //        Console.WriteLine("Your Password is Correct ");
        //    else
        //        Console.WriteLine("Entered Password is in invalid format.");
        //}
        //public void ReadEmailsData(string filepath)
        //{
        //    var email = File.ReadAllText(filepath);
        //    emailsData = email.Split(",");
        //    ValidateEmailData(emailsData);
        //}
        //public void ValidateEmailData(string[] input)
        //{
        //    foreach (var email in input)
        //    {
        //        if (Regex.IsMatch(email, emailsCheck))
        //            Console.WriteLine("{0} as Email Id is valid", email);
        //        else
        //            Console.WriteLine("{0} as Email Id is invalid ", email);
        //    }
        //}

        //Validate all UC using Lambda Expression
        public string ValidateFirstNameUsingLambda(string input) =>
            Regex.IsMatch(input, firstName) ? "Name is Valid" : "Entered Invalid Name";
        public string ValidateLastNameUsingLambda(string input) =>
            Regex.IsMatch(input, lastName) ? "Name is Valid" : "Entered Invalid Name";
        public string ValidateEmailUsingLambda(string input) =>
           Regex.IsMatch(input, email) ? "Email is Valid" : "Entered Invalid Email";
        public string ValidateMobileNumberUsingLambda(string input) =>
          Regex.IsMatch(input, mobileNumber) ? "Mobile Number is Valid" : "Entered Invalid Mobile Number";
        public string ValidatePasswordUsingLambda(string input) =>
          Regex.IsMatch(input, password) ? "Password is Valid" : "Entered Invalid Password";
        public void ReadEmailsDataUsingLambda(string filepath)
        {
            var email = File.ReadAllText(filepath);
            emailsData = email.Split(",");
            foreach(var data in emailsData)
            {
                if(ValidateAllEmailUsingLambda(data))
                {
                    Console.WriteLine("{0} as Email Id is valid", data);
                }
                else
                {
                    Console.WriteLine("{0} as Email Id is invalid ", data);
                }
            }
        }
        public bool ValidateAllEmailUsingLambda(string email)=>
            Regex.IsMatch(email,emailsCheck)?true:false;
    }
}
