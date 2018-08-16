using System;
using System.Linq;

namespace P05.MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split().ToArray();

             string firstWord = new string(inputWords[0].Distinct().ToArray());
             string secondWord = new string(inputWords[1].Distinct().ToArray());

            if (firstWord.Length != secondWord.Length)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
