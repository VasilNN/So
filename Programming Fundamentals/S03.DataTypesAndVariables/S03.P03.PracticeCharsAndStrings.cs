using System;

namespace P03.PracticeCharsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            string secondString = Console.ReadLine();

            Console.WriteLine(firstString);
            Console.WriteLine(firstChar);
            Console.WriteLine(secondChar);
            Console.WriteLine(thirdChar);
            Console.WriteLine(secondString);
        }
    }
}
