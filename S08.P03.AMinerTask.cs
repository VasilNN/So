using System;
using System.Collections.Generic;

namespace P03.AMinerTask
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

            Dictionary<string, int> minerDictonary = new Dictionary<string, int>();

            for (int i = 0; i < consoleInput.Count; i++)
            {
                if (i % 2 == 0)
                {
                    if (minerDictonary.ContainsKey(consoleInput[i]) == false)
                    {
                        minerDictonary.Add(consoleInput[i], 0);
                    }

                    minerDictonary.TryGetValue(consoleInput[i], out int value);
                    minerDictonary[consoleInput[i]] = value + int.Parse(consoleInput[i + 1]);
                }
            }

            foreach (var pair in minerDictonary)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
