using System;
namespace UserRegistrationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            PatternCheck check = new PatternCheck();
            Console.WriteLine("Welcome to the User Registration Problems");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Select from the below which you want to validate");
                Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Exit");
                Console.Write("Enter your choice: ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter your First name");
                        string firstName=Console.ReadLine();
                        check.ValidateFirstName(firstName);
                        break;
                    case 2:
                        Console.WriteLine("Enter your Last name");
                        string lastName = Console.ReadLine();
                        check.ValidateLastName(lastName);
                        break;
                    case 3:
                        Console.WriteLine("Enter your Email Id");
                        string email = Console.ReadLine();
                        check.ValidateEmail(email);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}