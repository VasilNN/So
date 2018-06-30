using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace P02.ConvertFromBase_NToBase_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            int baseNumber = (int)input[0];
            BigInteger number = input[1];

            BigInteger sum = 0;
            BigInteger lastNumber = 0;
            BigInteger workNumber = 1;
            while (number > 0)
            {
                lastNumber = number % 10;
                number = number / 10;
                sum += lastNumber * workNumber;
                workNumber *= baseNumber;
            }
            Console.WriteLine(string.Join("", sum));
        }
    }
}
