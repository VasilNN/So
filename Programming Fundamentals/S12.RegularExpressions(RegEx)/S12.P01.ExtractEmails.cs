using System;
using System.Text.RegularExpressions;

namespace P01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            Regex regex = new Regex(pattern);

            foreach (var word in input)
            {
                bool isCorrect = regex.IsMatch(word);

                if (isCorrect)
                {
                    Console.WriteLine(regex.Match(word));
                }
            }
        }
    }
}
