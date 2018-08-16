using System;

namespace P06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFirstWord = Console.ReadLine();
            string inputSecondWord = Console.ReadLine();

            object concatWords = inputFirstWord + " " + inputSecondWord;
            string concatStringWords = (string)concatWords;

            Console.WriteLine(concatStringWords);
        }
    }
}
