using System;
using System.Linq;
using System.Collections.Generic;

namespace P05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crating the KVP for the hands and the cards
            Dictionary<string, List<string>> handsOfCardsDictonary = new Dictionary<string, List<string>>();

            //Resetting the combined list for the cards
            List<string> newCards = new List<string>();
            List<string> cardsFromInput = new List<string>();

            //Get the input into a list
            while (true)
            {
                List<string> consoleInput = Console.ReadLine().Split(": ").ToList();

                //Check if the input is valid
                if (consoleInput.Contains("JOKER") == false)
                {
                    //Splitting the input into two parts
                    cardsFromInput = consoleInput[1].Split(", ").ToList(); //Used for getting the cards

                    //Adding entry to the dictonary
                    if (handsOfCardsDictonary.ContainsKey(consoleInput[0]) == false) // Checking if the KEY exist
                    {
                        handsOfCardsDictonary.Add(consoleInput[0], cardsFromInput);
                    }

                    //Check if the value in the Key is duplicated anf get the unique only
                    newCards = newCards.Union(cardsFromInput).ToList();

                    //Add the new Value to the Key
                    handsOfCardsDictonary[consoleInput[0]] = newCards;

                    //Console.WriteLine(string.Join(" - > ", newCards));

                    foreach (var list in handsOfCardsDictonary)
                    {
                        Console.WriteLine(string.Join(", ",list.Value));
                    }
                }
                else if (consoleInput.Contains("JOKER"))
                {
                    break;
                }
            }
        }
    }
}
