using System;

namespace HelloWorldYonayv_Fixico
{
    class Program
    {
        static void Main(string[] args)
        {
           //Asks the user for first name
           Console.WriteLine("What is your first name?");
            // Assigns user input to firstName variable
            string firstName = Console.ReadLine();
            // Asks the user for last name
            Console.WriteLine("What is your last name?");
            // Assigns user input to lastName variable
            string lastName = Console.ReadLine();

            //Prints a welcome message with firstName and lastName
            Console.WriteLine("Hello," + firstName + " " + lastName + "!");



        }
    }
}
