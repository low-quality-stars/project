//system namespace to use console class
using System;

//collection of classes for this project
namespace Strings_Taylor_Felicity
{
    //main class for program
    internal class Program
    {
        //Main method excecuted when app atarts
        static void Main(string[] args)
        {
            //asks user to input a character and assigns character to variable
            Console.WriteLine("Please input a character");
            char myChar = Console.ReadKey().KeyChar;

            //checks if the letter the user entered is a letter
            bool isLetter = Char.IsLetter(myChar);

            //prints result to console
            Console.WriteLine($"\n {myChar} is a letter: {isLetter}.");

            //asks user question and saves response to variable, sentence
            Console.WriteLine("What is your favorite color and why?");
            string sentence = Console.ReadLine();

            //asks user to enter a word, saves response to variable word
            Console.WriteLine("enter a word");
            string word = Console.ReadLine();

            //checks if word is in sentence
            bool isIn = sentence.Contains(word);

            //prints if word is in sentence
            Console.WriteLine($"{word} exists in {sentence}, {isIn}!");
        }
    }
}