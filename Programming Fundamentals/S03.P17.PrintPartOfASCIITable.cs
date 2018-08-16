using System;

namespace P17.PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            char firstChar = (char)firstNumber;
            char secondChar = (char)secondNumber;

            for (char i = firstChar; i <= secondChar; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
