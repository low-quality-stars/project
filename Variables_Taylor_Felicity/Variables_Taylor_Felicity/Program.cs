//system namespace to use console class
using System;

//collection of classes for this project
namespace Variables_Taylor_Felicity
{
    //main class for program
    internal class Program
    {

        //Main method excecuted when app atarts
        static void Main(string[] args)
        {
            //declars int named favoriteNumber
            int favoriteNumber;
            //boolean initialized to false for jumping and running
            bool isJumping = false, isRunning = false;
            //declared random float variable
            float myFloat;
            //assignging favoriteNumber to 32
            favoriteNumber = 32;
            //assigning myFloat to 52.53
            myFloat = 52.53f;
            //initializing constant finalGrade to 82
            const double finalGrade = 82.0;

            //prints variables to console
            Console.WriteLine(favoriteNumber);
            Console.WriteLine(isJumping);
            Console.WriteLine(isRunning);
            Console.WriteLine(myFloat);
            Console.WriteLine(finalGrade);
        }  
    }
}