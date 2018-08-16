using System;
using System.Collections.Generic;

namespace P01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] consoleInput = Console.ReadLine().Split();
            while (consoleInput[0] != "END")
            {
                if (consoleInput[0] == "A")
                {
                    if (phonebook.ContainsKey(consoleInput[1]) == false)
                    {
                        phonebook.Add(consoleInput[1], "");
                    }
                    phonebook[consoleInput[1]] = consoleInput[2];
                }
                else if (consoleInput[0] == "S")
                {
                    if (phonebook.TryGetValue(consoleInput[1], out string value))
                    {
                        Console.WriteLine($"{consoleInput[1]} -> {value}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {consoleInput[1]} does not exist.");
                    }
                }
                consoleInput = Console.ReadLine().Split();
            }
        }
    }
}
