//system namespace to use console class
using System;

//collection of classes for this project
namespace Conditionals_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app atarts
        static void Main(string[] args)
        {
            //asks user to enter a whole number & assigns to integer variable 
            Console.WriteLine("please input a whole number");
            int myNum = Convert.ToInt32(Console.ReadLine());

            //check if positive or negative
            if(myNum >= 0)
            {
                Console.WriteLine($"{myNum} is a positive number");
            }
            else
            {
                Console.WriteLine($"{myNum} is a negative number");
            }

            //check if even or odd
            if (myNum % 2 == 0)
            {
                Console.WriteLine($"{myNum} is even");
            }
            else
            {
                Console.WriteLine($"{myNum} is odd");
            }

            //creates two integer numbers
            int numOne = 4;
            int numTwo = 83;

            //compares all three numbers to find the maximum
            int maxNum1 = Math.Max(myNum, numOne);
            int max = Math.Max(maxNum1, numTwo);

            //prints max number to console
            Console.WriteLine($"the maximum number between {myNum} and {numOne} and {numTwo} is {max}");

            //asks user to enter a letter grade & assigns to grade char variable
            Console.WriteLine("please enter a grade (A, B, C, D, F)");
            char grade = Console.ReadKey().KeyChar;

            //prints description based on grade input
            switch(grade)
            {
                case 'A':
                    Console.WriteLine("\nSuperior");
                    break;
                case 'B':
                    Console.WriteLine("\nVery Good");
                    break;
                case 'C':
                    Console.WriteLine("\nAverage");
                    break;
                case 'D':
                    Console.WriteLine("\nBelow Average");
                    break;
                case 'F':
                    Console.WriteLine("\nFail");
                    break;
                default:
                    Console.WriteLine("you did not enter a valid grade");
                    break;
            }
        }
    }
}
