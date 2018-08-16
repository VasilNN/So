using System;

namespace P18.DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputValue = Console.ReadLine();

            bool isValid = false;
            bool firstPrint = true;

            try
            {
                sbyte valueSByte = sbyte.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* sbyte");
            }
            catch (Exception)
            {
            }

            try
            {
                byte valueByte = byte.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* byte");
            }
            catch (Exception)
            {
            }

            try
            {
                short valueByte = short.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* short");
            }
            catch (Exception)
            {
            }

            try
            {
                ushort valueByte = ushort.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* ushort");
            }
            catch (Exception)
            {
            }

            try
            {
                int valueByte = int.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* int");
            }
            catch (Exception)
            {
            }

            try
            {
                uint valueByte = uint.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* uint");
            }
            catch (Exception)
            {
            }

            try
            {
                long valueByte = long.Parse(inputValue);
                isValid = true;
                if (firstPrint)
                {
                    Console.WriteLine($"{inputValue} can fit in:");
                    firstPrint = false;
                }
                Console.WriteLine("* long");
            }
            catch (Exception)
            {
            }

            if (!isValid)
            {
                Console.WriteLine($"{inputValue} can't fit in any type");
            }
        }
    }
}
