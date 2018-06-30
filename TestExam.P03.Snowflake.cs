using System;
using System.Text.RegularExpressions;

namespace P03.Snowflake
{
    class Program
    {
        static void Main(string[] args)
        {
            string allLines = "";
            for (int i = 0; i < 5; i++)
            {
                allLines += Console.ReadLine();
            }

            string pattern = @"^([^a-zA-Z0-9]+)([_0-9]+)([^a-zA-Z0-9]+)([_0-9]+)([a-zA-Z]+)([_0-9]+)([^a-zA-Z0-9]+)([_0-9]+)([^a-zA-Z0-9]+)$";

            string patternCore = @"([a-zA-Z]+)";

            Regex regexAll = new Regex(pattern);
            bool isMatch = regexAll.IsMatch(allLines);

            if (isMatch == true)
            {
                Regex regexCore = new Regex(patternCore);
                Match core = regexCore.Match(allLines);
                Console.WriteLine("Valid");
                Console.WriteLine(core.Length);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
