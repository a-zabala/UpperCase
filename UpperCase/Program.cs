using System;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence to make uppercase: ");
            // takes user input and saves it to string variable
            string mySentence = Console.ReadLine();

            //changes mySentence to all uppercase and prints to screen
            Console.WriteLine(mySentence.ToUpper());
            Console.ReadLine();
        }
    }
}
