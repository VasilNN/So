using System;

namespace P06.SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumberFirst = Console.ReadLine();
            string inputNumberSecond = Console.ReadLine();

            string sumString = "";
            long max = 9999999999;
            int left = 0;

            while (true)
            {
                long firstNumberEnd = 0;
                long secondNumberEnd = 0;
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

                //Extract the second number
                if (inputNumberSecond.Length >= 10)
                {
                    secondNumberEnd = long.Parse(inputNumberSecond.Substring(inputNumberSecond.Length - 10));
                    inputNumberSecond = inputNumberSecond.Substring(0, inputNumberSecond.Length - 10);
                }
                else if (inputNumberSecond.Length > 0)
                {
                    secondNumberEnd = long.Parse(inputNumberSecond);
                    inputNumberSecond = "";
                }

                //Check if there is nothing left
                if (firstNumberEnd == 0 && secondNumberEnd == 0)
                {
                    break;
                }

                sum += firstNumberEnd + secondNumberEnd;
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
            Console.WriteLine(sumString);
        }
    }
}
