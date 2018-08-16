using System;
using System.Linq;

namespace P02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rotations = int.Parse(Console.ReadLine());

            int[] arrFirst = new int[input.Split().Length];
            int[] arrSecond = new int[arrFirst.Length];
            int[] arrSum = new int[arrFirst.Length];

            //String to int array
            arrFirst = input.Split()
                       .Select(int.Parse)
                       .ToArray();


            for (int indexForCycles = 0; indexForCycles < rotations; indexForCycles++)
            {
                //R shift
                arrSecond[0] = arrFirst[arrFirst.Length - 1];
                for (int indexForShift = 1; indexForShift <= arrFirst.Length - 1; indexForShift++)
                {
                    arrSecond[indexForShift] = arrFirst[indexForShift - 1];
                }

                //Sum of the arrays
                for (int i = 0; i <= arrFirst.Length - 1; i++)
                {
                    arrSum[i] += arrSecond[i] ;
                    arrFirst[i] = arrSecond[i];
                }
            }

            //Print
            foreach (int item in arrSum)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
