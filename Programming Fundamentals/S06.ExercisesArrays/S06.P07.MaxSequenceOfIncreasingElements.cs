using System;
using System.Linq;

namespace P07.MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sequenceStart = 0;
            int sequenceLenght = 0;
            int longestSequence = 0;


            for (int index = 0; index < arr.Length - 1; index++)
            {
                if (arr[index] < arr[index + 1])
                {
                    sequenceLenght++;

                    if (sequenceLenght > longestSequence)
                    {
                        longestSequence = sequenceLenght;
                        sequenceStart = index - sequenceLenght + 1;
                    }
                }
                else
                {
                    sequenceLenght = 0;
                }
            }

            for (int i = sequenceStart; i < sequenceStart + longestSequence + 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
