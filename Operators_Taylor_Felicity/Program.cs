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
            Console.WriteLine("INTERGERS");
            //initializes and multiplies 2 intergers
            int intMult = 8 * 3;
            //initializes and adds 2 intergers
            int intAdd = 34 + 89;

            //prints maximum of the two interger variables
            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}.");
            //prints minimum of the two interger variables
            Console.WriteLine($"The min of {intMult} and {intAdd} is {Math.Min(intMult, intAdd)}.");

            //initializes boolean to see if intMult is greater than intAdd
            bool isIntGreater = intMult > intAdd;
            //prints if intMult is greater than intAdd
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.\n");


            Console.WriteLine("SHORTS");
            //initializes and multiplies 2 shorts
            short shortMult = 8 * 3;
            //initializes and adds 2 shorts
            short shortAdd = 34 + 89;

            //prints maximum of the two short variables
            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}.");
            //prints minimum of the two short variables
            Console.WriteLine($"The min of {shortMult} and {shortAdd} is {Math.Min(shortMult, shortAdd)}.");

            //initializes boolean to see if shortMult is greater than shortAdd
            bool isshortGreater = shortMult > shortAdd;
            //prints if shortMult is greater than shortAdd
            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}.\n");


            Console.WriteLine("LONGS");
            //initializes and multiplies 2 longs
            long longMult = 8 * 3;
            //initializes and adds 2 longs
            long longAdd = 34 + 89;

            //prints maximum of the two long variables
            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}.");
            //prints minimum of the two long variables
            Console.WriteLine($"The min of {longMult} and {longAdd} is {Math.Min(longMult, longAdd)}.");

            //initializes boolean to see if longMult is greater than longAdd
            bool islongGreater = longMult > longAdd;
            //prints if longMult is greater than longAdd
            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}.\n");


            Console.WriteLine("FLOATS");
            //initializes and multiplies 2 floats
            float floatMult = 8.7f * 3.2f;
            //initializes and adds 2 floats
            float floatAdd = 34.8f + 89.12f;

            //prints maximum of the two float variables
            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}.");
            //prints minimum of the two float variables
            Console.WriteLine($"The min of {floatMult} and {floatAdd} is {Math.Min(floatMult, floatAdd)}.");

            //initializes boolean to see if floatMult is greater than floatAdd
            bool isfloatGreater = floatMult > floatAdd;
            //prints if floatMult is greater than floatAdd
            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}.\n");


            Console.WriteLine("DOUBLES");
            //initializes and multiplies 2 doubles
            double doubleMult = 8.983 * 3.24;
            //initializes and adds 2 doubles
            double doubleAdd = 34.9 + 89.67;

            //prints maximum of the two double variables
            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}.");
            //prints minimum of the two double variables
            Console.WriteLine($"The min of {doubleMult} and {doubleAdd} is {Math.Min(doubleMult, doubleAdd)}.");

            //initializes boolean to see if doubleMult is greater than doubleAdd
            bool isdoubleGreater = doubleMult > doubleAdd;
            //prints if doubleMult is greater than doubleAdd
            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}.\n");


            Console.WriteLine("DECIMALS");
            //initializes and multiplies 2 decimals
            decimal decimalMult = (decimal)(8.32 * 3.21);
            //initializes and adds 2 decimals
            decimal decimalAdd = (decimal)(34.56 + 89.93);

            //prints maximum of the two decimal variables
            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}.");
            //prints minimum of the two decimal variables
            Console.WriteLine($"The min of {decimalMult} and {decimalAdd} is {Math.Min(decimalMult, decimalAdd)}.");

            //initializes boolean to see if decimalMult is greater than decimalAdd
            bool isdecimalGreater = decimalMult > decimalAdd;
            //prints if decimalMult is greater than decimalAdd
            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}.");
        }
    }
}