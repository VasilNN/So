using System;

namespace P13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                int digit = int.Parse(input);
                if (digit >= 0 && digit<= 9)
                {
                    Console.WriteLine("digit");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
            catch (Exception)
            {
                try
                {
                    char vowel = char.Parse(input);

                    if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                    {
                        Console.WriteLine("vowel");
                    }
                    else
                    {
                        Console.WriteLine("other");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
