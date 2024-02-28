//system namespace to use console class
using System;

//collection of classes for this project
namespace Operators_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app atarts
        static void Main(string[] args)
        {
            int intMult = 8 * 3;
            int intAdd = 34 + 89;

            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}.");
            Console.WriteLine($"The min of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}.");

            bool isIntGreater = intMult > intAdd;
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");

        }
    }
}