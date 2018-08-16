using System;
using System.Linq;

namespace P04.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputWords = Console.ReadLine().Split().ToArray();
            int sum = 0;

            for (int index = 0; index < Math.Min(inputWords[0].Length, inputWords[1].Length); index++)
            {
                sum += inputWords[0][index] * inputWords[1][index];
            }

            if (inputWords[0].Length > inputWords[1].Length)
            {
                sum += sumOfTheRest(inputWords[0], inputWords[1]);
            }
            else if (inputWords[1].Length > inputWords[0].Length)
            {
                sum += sumOfTheRest(inputWords[1], inputWords[0]);
            }

            Console.WriteLine(sum);
        }

        static int sumOfTheRest(string longerLord, string shorterWord)
        {
            int sum = 0;

            for (int index = shorterWord.Length; index < longerLord.Length; index++)
            {
                sum += longerLord[index];
            }
            return sum;
        }
    }
}
