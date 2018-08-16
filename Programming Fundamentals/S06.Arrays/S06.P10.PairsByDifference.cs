using System;
using System.Linq;

namespace P10.PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int firstNumber = 0; firstNumber < arr.Length; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber < arr.Length; secondNumber++)
                {
                    if (arr[firstNumber] == arr[secondNumber] - difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
