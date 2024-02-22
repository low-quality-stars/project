//system namespace to use console class
using System;

//collection of classes for this project
namespace HelloWorld_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app atarts
        static void Main(string[] args) 
        {
            //asks user for first name
            Console.WriteLine("What is your first name?");
            //assigns firstName variable using user input
            string firstName = Console.ReadLine();
            //asks user for last name
            Console.WriteLine("What is your last name?");
            //assigns lastName variable using user input
            string lastName = Console.ReadLine();

            //says hello to user with firstName lastName assignment 
            Console.WriteLine($"Hello, {firstName} {lastName}!"); 
                }
    }
}
