//system namespace to use console class
using System;

//collection of classes for this project
namespace Casting_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app atarts
        static void Main(string[] args)
        {
            //asks user to input a whole number and assigns input to int
            Console.WriteLine("Please input a whole number");
            int wholeNumber = Convert.ToInt32(Console.ReadLine());
            
            //prints favorite number to console
            Console.WriteLine("Your favorite number is " + wholeNumber);

            //asks user t/f question and assigns answer to bool
            Console.WriteLine("Do you like reading? (please enter 'true' or 'false')");
            bool isTrue = Convert.ToBoolean(Console.ReadLine());

            //print result of question
            Console.WriteLine($"It is {isTrue} that I like reading!");
        }
    }
}
