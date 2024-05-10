//system namespace to use console class
using System;

//collection of classes for this project
namespace Loops_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app atarts
        static void Main(string[] args)
        {
            //asks user a question, reads answer
            Console.WriteLine("why do you or do you not enjoy books?");
            string response = Console.ReadLine();

            //repeats sentence baxk telling user how many spaces are in it
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            //asks user for a whole number, reads answer
            Console.WriteLine("enter a whole number");
            string response2 = Console.ReadLine();

            //tells the user the sum of the individual numbers of the whole number given
            Console.WriteLine($"the sum of the idividual digits of {response2} is {SumOfDigits(response2)}.");
        }

        //counts the number of spaces
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach(char character in sentence)
            {
                if(character == ' ')
                {
                    numberOfSpaces++;
                }
            }

            return numberOfSpaces;
        }

        //calculates sum of numbers
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach(char digit in number) 
            {
                sum += (int)Char.GetNumericValue(digit);
            }

            return sum;
        }
    }
}