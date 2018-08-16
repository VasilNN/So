using System;
using System.Numerics;

namespace P1.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());

            int snowballSnowMax = 0;
            int snowballTimeMax = 0;
            int snowballQualityMax = 0;
            BigInteger maxValue = -1;


            for (int i = 0; i < numberOfBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (maxValue < value)
                {
                    maxValue = value;
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballQualityMax = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {maxValue} ({snowballQualityMax})");
        }
    }
}
