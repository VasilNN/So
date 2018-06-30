using System;
using System.Text.RegularExpressions;

namespace P02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string searchedWord = Console.ReadLine();
            string input = Console.ReadLine();

            string pattern = $@"[^.!?;]*(\b{searchedWord}\b)[^.?!;]*";

            Regex regex = new Regex(pattern);

            var output = regex.Matches(input);

            foreach (var setntece in output)
            {
                Console.WriteLine(setntece.ToString().Trim());
            }
        }
    }
}
