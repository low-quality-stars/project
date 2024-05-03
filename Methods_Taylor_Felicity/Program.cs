//system namespace to use console class
using System;

//collection of classes for this project
namespace Methods_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app starts
        static void Main(string[] args)
        {
            //prints message to console asking for whole number, reads number x2
            Console.WriteLine("Enter a whole number!");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another whole number");
            int y = Convert.ToInt32(Console.ReadLine());

            //printss the product of the two whole numbers
            Console.WriteLine(Multiply(x, y));

            //asks user for their name, reads name
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            //
            WelcomeUser(name);

            Goodbye();
        }

        //multiplies the two whole numbers
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //prints welcome message to console
        static void WelcomeUser(string username)
        {
            Console.WriteLine($"Hello, {username}, it is nice to meet you!");
        }

        //prints goodbye message to console
        static void Goodbye()
        {
            Console.WriteLine("Have a wonderful day");
        }
    }
}