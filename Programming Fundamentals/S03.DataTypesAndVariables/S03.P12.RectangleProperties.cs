using System;

namespace P12.RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstSide = double.Parse(Console.ReadLine());
            double secondSide = double.Parse(Console.ReadLine());

            double perimeter = 2 * firstSide + 2 * secondSide;
            double area = firstSide * secondSide;
            double diagonal = Math.Sqrt(Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2));

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
