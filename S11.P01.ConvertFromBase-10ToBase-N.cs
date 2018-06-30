using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace P01.ConvertFromBase_10ToBase_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            BigInteger baseToNumber = input[0];
            BigInteger number = input[1];

            List<BigInteger> baseN = new List<BigInteger>();
            while (number > 0)
            {
                baseN.Add(number % baseToNumber);
                number = number / baseToNumber;
            }
            baseN.Reverse();
            Console.WriteLine(string.Join("", baseN));
        }
    }
}
