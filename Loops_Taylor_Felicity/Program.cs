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

            Console.WriteLine("why do you or do you not enjoy books?");
            string response = Console.ReadLine();

            Console.WriteLine($"The sentenc, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            Console.WriteLine("enter a whole number");
            string response2 = Console.ReadLine();

            Console.WriteLine($"the sum of the idividual digits of {response2} is {SumOfDigits(response2)}.");
        }


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