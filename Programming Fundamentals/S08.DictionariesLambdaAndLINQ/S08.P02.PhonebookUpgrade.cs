using System;
using System.Linq;
using System.Collections.Generic;

namespace P02.PhonebookUpgrade
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
                else if (consoleInput[0] == "ListAll")
                {
                    Dictionary<string, string> sortedPhonebook = phonebook.OrderBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
                    foreach (var pair in sortedPhonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
                    }
                }
                consoleInput = Console.ReadLine().Split();
            }
        }
    }
}
