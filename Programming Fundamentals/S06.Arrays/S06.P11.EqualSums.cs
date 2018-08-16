using System;
using System.Linq;

namespace P11.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumLeft = 0;
            int sumRight = 0;

            int midElement = 0;
            int leftElement = 0;
            int rightElement = 0;

            bool isEqual = false;
            bool neverEnter = true;
            
            for (midElement = 0; midElement < arr.Length; midElement++)
            {
                neverEnter = false;

                for (leftElement = 0; leftElement < midElement; leftElement++)
                {
                    sumLeft += arr[leftElement];
                }
                for (rightElement = midElement + 1; rightElement < arr.Length; rightElement++)
                {
                    sumRight += arr[rightElement];
                }
                if (sumLeft == sumRight)
                {
                    isEqual = true;
                    break;
                }
                
                sumLeft = 0;
                sumRight = 0;
            }

            if (isEqual)
            {
                Console.WriteLine(leftElement);
            }
            else if (neverEnter)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
