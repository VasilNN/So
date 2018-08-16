using System;
using System.Collections.Generic;
using System.Linq;

namespace P11.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDragons = int.Parse(Console.ReadLine());
            var dragonBook = new Dictionary<string, SortedDictionary<string, List<int>>>();

            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] inputFromConsole = Console.ReadLine().Split().ToArray();

                string dragonType = inputFromConsole[0];
                string dragonName = inputFromConsole[1];
                string dragonDamageStr = inputFromConsole[2];
                string dragonHealthStr = inputFromConsole[3];
                string dragonArmorStr = inputFromConsole[4];

                int dragonDamage = 0;
                int dragonHealth = 0;
                int dragonArmor = 0;

                //Check For Null
                if (dragonDamageStr == "null")
                {
                    dragonDamage = 45;
                }
                else
                {
                    dragonDamage = int.Parse(dragonDamageStr);
                }

                if (dragonHealthStr == "null")
                {
                    dragonHealth = 250;
                }
                else
                {
                    dragonHealth = int.Parse(dragonHealthStr);
                }

                if (dragonArmorStr == "null")
                {
                    dragonArmor = 10;
                }
                else
                {
                    dragonArmor = int.Parse(dragonArmorStr);
                }

                //If contains color
                if (dragonBook.ContainsKey(dragonType) == false)
                {
                    dragonBook.Add(dragonType, new SortedDictionary<string, List<int>>());
                }
                if (dragonBook[dragonType].ContainsKey(dragonName) == false)
                {
                    dragonBook[dragonType].Add(dragonName, new List<int>() { dragonDamage, dragonHealth, dragonArmor });
                }

                dragonBook[dragonType][dragonName][0] = dragonDamage;
                dragonBook[dragonType][dragonName][1] = dragonHealth;
                dragonBook[dragonType][dragonName][2] = dragonArmor;
            }

            foreach (var type in dragonBook.Keys)
            {
                var dragonTypeTemp = dragonBook[type];

                double avarageDamage = 0;
                double avarageHealth = 0;
                double avarageArmor = 0;
                int dragons = 0;

                //Get the avarage stats
                foreach (var name in dragonTypeTemp.Keys)
                {
                    //Sum the stats
                    avarageDamage += dragonBook[type][name][0];
                    avarageHealth += dragonBook[type][name][1];
                    avarageArmor += dragonBook[type][name][2];
                    dragons++;
                }
                //Avarage the stats
                avarageDamage /= dragons;
                avarageHealth /= dragons;
                avarageArmor /= dragons;

                //Print avarage
                Console.WriteLine($"{type}::({avarageDamage:f2}/{avarageHealth:f2}/{avarageArmor:f2})");


                //Print Each Dragon
                foreach (var name in dragonTypeTemp.Keys)
                {
                    Console.WriteLine($"-{name} -> damage: {dragonBook[type][name][0]}, health: {dragonBook[type][name][1]}, armor: {dragonBook[type][name][2]}");
                }
            }
        }
    }
}

