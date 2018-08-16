using System;
using System.Linq;

namespace P06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sequenceStart = 0;
            int sequenceLenght = 1;
            int longestSequence = 1;


            for (int index = 1; index < arr.Length; index++)
            {
                if (arr[index] == arr[index - 1] && index > 0)
                {
                    sequenceLenght++;

                    if (sequenceLenght > longestSequence)
                    {
                        longestSequence = sequenceLenght;
                        sequenceStart = index - (sequenceLenght - 1);
                    }
                }
                else
                {
                    sequenceLenght = 1;
                }
            }

            for (int i = sequenceStart; i < sequenceStart + longestSequence; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
