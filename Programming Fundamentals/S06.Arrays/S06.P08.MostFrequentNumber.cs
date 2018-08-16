using System;
using System.Linq;

namespace P08.MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int counter = 0;
            int mostFriquentNumberCount = 0;
            int mostFriquentNumber = arr[0];

            for (int firstNumber = 0; firstNumber < arr.Length; firstNumber++)
            {
                for (int comparedNumber = firstNumber + 1; comparedNumber < arr.Length; comparedNumber++)
                {
                    if (arr[firstNumber] == arr[comparedNumber])
                    {
                        counter++;
                    }
                }

                if (counter > mostFriquentNumberCount)
                {
                    mostFriquentNumberCount = counter;
                    mostFriquentNumber = arr[firstNumber];
                }

                counter = 0;
            }
            Console.WriteLine(mostFriquentNumber);
        }
    }
}
