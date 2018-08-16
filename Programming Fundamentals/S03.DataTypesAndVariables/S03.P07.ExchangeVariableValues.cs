sing System;

namespace P07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            string tempValue = "";

            //Print Before
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstValue}");
            Console.WriteLine($"b = {secondValue}");

            //Swap      
            tempValue = firstValue;
            firstValue = secondValue;
            secondValue = tempValue;

            //Print After
            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstValue}");
            Console.WriteLine($"b = {secondValue}");
        }
    }
}
