using System;

namespace P04.SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            bool[] arr = new bool[range+1];

            //Assign true to array
            for (int i = 2; i <= range; i++)
            {
                arr[i] = true;
            }

            //Check for primes
            for (int i = 3; i <= range; i++)
            {
                if (i % 2 == 0 && arr[i] == true)
                {
                    arr[i] = false;
                }

                //All the multiples are NOT primes
                for (int j = 2; j <= range; j++)
                {
                    int index = i * j;
                    if (index < range)
                    {
                        arr[index] = false;
                    }
                }
            }

            //Print prime numbers
            for (int i = 0; i <= range; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
