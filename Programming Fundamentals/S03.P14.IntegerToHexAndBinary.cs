using System;

namespace P14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            string hexadecimalValue = (Convert.ToString(inputNumber, 16)).ToUpper();
            string binaryValue = Convert.ToString(inputNumber, 2);

            Console.WriteLine(hexadecimalValue);
            Console.WriteLine(binaryValue);
        }
    }
}
