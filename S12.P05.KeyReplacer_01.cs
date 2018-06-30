using System;
using System.Text.RegularExpressions;

namespace P05.KeyReplacer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string text = Console.ReadLine();


            string patternStart = @"^([a-zA-Z])+[^\|<\\]*";
            string patternEnd = @"[^\|<\\]([a-zA-Z])*$";

            Regex regexStart = new Regex(patternStart);
            Regex regexEnd = new Regex(patternEnd);

            Match startKey = regexStart.Match(input);
            Match endKey = regexEnd.Match(input);

            string midPattern = $@"{startKey}(.*?){endKey}";
            Regex regexMid = new Regex(midPattern);

            MatchCollection matches = regexMid.Matches(text);

            string result = "";
            foreach (Match match in matches)
            {
                result += match.Groups[1].Value;
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }
            Console.WriteLine();
        }
    }
}
