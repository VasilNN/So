using System;

namespace P01.PracticeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numberSByte = sbyte.Parse(Console.ReadLine());
            byte numberByte = byte.Parse(Console.ReadLine());

            short numberShort = short.Parse(Console.ReadLine());
            ushort numberUShort = ushort.Parse(Console.ReadLine());

 
            uint numberUInteger = uint.Parse(Console.ReadLine());
            int numberInteger = int.Parse(Console.ReadLine());

            long numberLong = long.Parse(Console.ReadLine());
            //ulong numberULong = ulong.Parse(Console.ReadLine());

            Console.WriteLine(numberSByte);
            Console.WriteLine(numberByte);
            Console.WriteLine(numberShort);
            Console.WriteLine(numberUShort);
            Console.WriteLine(numberUInteger);
            Console.WriteLine(numberInteger);
            Console.WriteLine(numberLong);
           // Console.WriteLine(numberULong);
        }
    }
}
