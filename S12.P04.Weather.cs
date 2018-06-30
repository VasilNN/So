using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace P04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create dictonary
            var wateherDictonary = new SortedDictionary<string, KeyValuePair<string, double>>();

            //Deffine Regex
            string pattern = @"([A-Z]{2})([-]?\d+\.\d+)([a-zA-Z]+)\|";
            Regex regex = new Regex(pattern);

            //Fill the dictonary
            while (true)
            {
                //Get input and exit if "end"
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                //Decide a Match
                bool isMatch = regex.IsMatch(input);
                if (isMatch)
                {
                    Match match = regex.Match(input);

                    //Split a match
                    string city = match.Groups[1].ToString();
                    double temperature = double.Parse(match.Groups[2].ToString());
                    string weather = match.Groups[3].ToString();

                    //Add to dictonary
                    if (wateherDictonary.ContainsKey(city) == false)
                    {
                        wateherDictonary.Add(city, new KeyValuePair<string, double>(weather, temperature));
                    }
                    wateherDictonary[city] =  new KeyValuePair<string, double>(weather, temperature);
                }
            }

            //Printing
            foreach (var city in wateherDictonary.OrderBy(x=> x.Value.Value))
            {
                    Console.WriteLine($"{city.Key} => {city.Value.Value:f2} => {city.Value.Key}");
            }

            Console.WriteLine();
        }
    }
}
