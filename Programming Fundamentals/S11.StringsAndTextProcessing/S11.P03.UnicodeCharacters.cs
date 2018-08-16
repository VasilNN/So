using System;

namespace P03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            for (int index = 0; index < inputString.Length; index++)
            {
                Console.Write(GetEscapeSequence(inputString[index]));
            }
            Console.WriteLine();
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
