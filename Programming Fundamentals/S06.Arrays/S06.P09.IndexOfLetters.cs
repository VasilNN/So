using System;
using System.Linq;

namespace P09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine().ToLower().ToCharArray();

            foreach (var item in arr)
            {
                Console.Write(item + " -> ");
                Console.WriteLine(item - 97);
            }
        }
    }
}
