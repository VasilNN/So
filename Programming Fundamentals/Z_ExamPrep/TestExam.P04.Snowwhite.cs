using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFromConsole = "";
            var dwarfsDictonary = new Dictionary<string, Dictionary<string, int>>();

            while ((inputFromConsole = Console.ReadLine()) != "Once upon a time")
            {
                string[] dwarfsInfo = inputFromConsole.Split(" <:> ").ToArray();

                string dwarfName = dwarfsInfo[0];
                string dwarfHatColor = dwarfsInfo[1];
                int dwarfPhysics = int.Parse(dwarfsInfo[2]);

                //Add hat
                if (dwarfsDictonary.ContainsKey(dwarfHatColor) == false)
                {
                    dwarfsDictonary.Add(dwarfHatColor, new Dictionary<string, int>());
                }
                //Add name
                if (dwarfsDictonary[dwarfHatColor].ContainsKey(dwarfName) == false)
                {
                    dwarfsDictonary[dwarfHatColor].Add(dwarfName, new int());
                }
                //Comapre physics
                if (dwarfsDictonary[dwarfHatColor][dwarfName] < dwarfPhysics)
                {
                    dwarfsDictonary[dwarfHatColor][dwarfName] = dwarfPhysics;

                }
            }

            foreach (var hatColor in dwarfsDictonary.OrderByDescending(x => x.Value.Values.Max()).ThenByDescending(x => x.Value.Count))
            {
                var dwarfNames = hatColor.Value;
                foreach (var name in dwarfNames)
                {
                    Console.WriteLine($"({hatColor.Key}) {name.Key} <-> {name.Value}");
                }
            }
        }
    }
}
