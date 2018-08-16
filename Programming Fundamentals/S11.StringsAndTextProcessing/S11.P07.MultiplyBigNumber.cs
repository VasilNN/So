using System;
using System.Linq;

namespace P07.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumberFirst = Console.ReadLine();
            int inputNumberSecond = int.Parse(Console.ReadLine());

            string sumString = "";
            long max = 9999999999;
            int left = 0;

            while (true)
            {
                long firstNumberEnd = 0;
                long sum = left;
                left = 0;

                //Extract the first number
                if (inputNumberFirst.Length >= 10)
                {
                    firstNumberEnd = long.Parse(inputNumberFirst.Substring(inputNumberFirst.Length - 10));
                    inputNumberFirst = inputNumberFirst.Substring(0, inputNumberFirst.Length - 10);
                }
                else if (inputNumberFirst.Length > 0)
                {
                    firstNumberEnd = long.Parse(inputNumberFirst);
                    inputNumberFirst = "";

                }

                //Check if there is nothing left
                if (firstNumberEnd == 0)
                {
                    if (sumString.Length == 0)
                    {
                        sumString = "0";
                    }
                    break;
                }


                sum += firstNumberEnd * inputNumberSecond;
                if (sum > max)
                {
                    left = (int)(sum / 10000000000);
                    sumString = sum.ToString().Substring(1) + sumString;
                }
                else
                {
                    sumString = sum.ToString() + sumString;
                }
            }

            int endSum = int.Parse(sumString.First().ToString());
            if (endSum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(sumString);
            }
        }
    }
}
