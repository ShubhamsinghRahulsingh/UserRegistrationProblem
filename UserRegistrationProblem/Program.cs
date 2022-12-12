using System;
namespace UserRegistrationProblem
{
    class Program
    {
        public static string emailsFilePath = @"D:\GitRepository\UserRegistrationProblem\UserRegistrationProblem\File\EmailsData.txt";
        static void Main(string[] args)
        {
            PatternCheck check = new PatternCheck();
            Console.WriteLine("Welcome to the User Registration Problems");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Select from the below which you want to validate");
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Mobile Number\n5.Password\n6.EmailsData Check\n7.Exit");
                Console.Write("Enter your choice: ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName=Console.ReadLine();
                        // check.ValidateFirstName(firstName);
                        string result=check.ValidateFirstNameUsingLambda(firstName);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name");
                        string lastName = Console.ReadLine();
                        // check.ValidateLastName(lastName);
                        string resultt = check.ValidateLastNameUsingLambda(lastName);
                        Console.WriteLine(resultt);
                        break;
                    case 3:
                        Console.WriteLine("Enter your Email Id");
                        string email = Console.ReadLine();
                       // check.ValidateEmail(email);
                        string vald=check.ValidateEmailUsingLambda(email);
                        Console.WriteLine(vald);
                        break;
                    case 4:
                        Console.WriteLine("Enter your Mobile Number");
                        string mobileNumber = Console.ReadLine();
                       // check.ValidateMobileNumber(mobileNumber);
                        string mobile=check.ValidateMobileNumberUsingLambda(mobileNumber);
                        Console.WriteLine(mobile);
                        break;
                    case 5:
                        Console.WriteLine("Enter your Password");
                        string password = Console.ReadLine();
                        //check.ValidatePassword(password);
                        string pass=check.ValidatePasswordUsingLambda(password);
                        Console.WriteLine(pass);
                        break;
                    case 6:
                      // check.ReadEmailsData(emailsFilePath);
                       check.ReadEmailsDataUsingLambda(emailsFilePath);
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}