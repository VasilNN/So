using System;
using System.Linq;
using System.Collections.Generic;

namespace P04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> consoleInput = new List<string>();

            while (consoleInput.Contains("stop") == false)
            {
                consoleInput.Add(Console.ReadLine());
            }
            consoleInput.RemoveAt(consoleInput.Count - 1);

            Dictionary<string, string> mailBook = new Dictionary<string, string>();

            for (int i = 0; i < consoleInput.Count; i++)
            {
                if (i % 2 == 0)
                {
                    List<string> domain = consoleInput[i + 1].Split(".").ToList();
                    if (domain[1] != "us" && domain[1] != "uk")
                    {
                        if (mailBook.ContainsKey(consoleInput[i]) == false)
                        {
                            mailBook.Add(consoleInput[i], "");
                        }
                        mailBook[consoleInput[i]] = consoleInput[i + 1];
                    }
                }
            }

            foreach (var pair in mailBook)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
