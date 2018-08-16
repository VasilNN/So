using System;

namespace P05.BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStringValue = Console.ReadLine();
            bool inputValueBool = Convert.ToBoolean(inputStringValue);

            if (inputValueBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
