using System;
using System.Linq;

namespace P05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstCharArray = Console.ReadLine()
                                            .ToLower()
                                            .Split(' ')
                                            .Select(char.Parse)
                                            .ToArray();

            char[] secondCharArray = Console.ReadLine()
                                            .ToLower()
                                            .Split(' ')
                                            .Select(char.Parse)
                                            .ToArray();

            if (firstCharArray[0] == secondCharArray[0])
            {
                if (firstCharArray.Length > secondCharArray.Length)
                {
                    PrintArray(secondCharArray);
                    PrintArray(firstCharArray);
                }
                else
                {
                    PrintArray(firstCharArray);
                    PrintArray(secondCharArray);
                }
            }
            else
            {
                if (firstCharArray[0] > secondCharArray[0])
                {
                    PrintArray(secondCharArray);
                    PrintArray(firstCharArray);
                }
                else
                {
                    PrintArray(firstCharArray);
                    PrintArray(secondCharArray);
                }
            }

        }

        private static void PrintArray(char[] arr)
        {
            foreach (var character in arr)
            {
                Console.Write(character);
            }
            Console.WriteLine();
        }
    }
}
