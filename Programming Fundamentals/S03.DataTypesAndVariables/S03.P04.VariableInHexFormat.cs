using System;

namespace P04.VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStringFormat = Console.ReadLine();
            int outputIntHexFormat = Convert.ToInt32(inputStringFormat, 16);
            Console.WriteLine(outputIntHexFormat);
        }
    }
}
