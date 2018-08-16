using System;
using System.Text.RegularExpressions;

namespace EP03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            //Whole pattern - ^(\%[A-Z][a-z]+\%)(\<\w+\>)(\|[0-9]+\|)([0-9]+\.[0-9]+\$)$

            //Regex patterns
            string namePattern = @"^\%([A-Z][a-z]+)\%";
            string productPattern = @"\<(\w+)\>";
            string quantityPattern = @"\|([0-9]+)\|";
            string pricePattern = @"([0-9]+\.?[0-9]*)\$";

            //Initialize the input string
            string inputConsole = string.Empty;
            double income = 0;
            while ((inputConsole = Console.ReadLine()) != "end of shift")
            {
                //%George%<Croissant>|2|10.3$
                string name = "";
                string product = "";
                int quantity = 0;
                double totalPrice = 0;
                double price;

                //Regex regexes
                Regex nameRegex = new Regex(namePattern);
                Regex productRegex = new Regex(productPattern);
                Regex quantityRegex = new Regex(quantityPattern);
                Regex priceRegex = new Regex(pricePattern);

                //Check for valid entraces
                bool nameValid = nameRegex.IsMatch(inputConsole);
                bool productValid = productRegex.IsMatch(inputConsole);
                bool quantityValid = quantityRegex.IsMatch(inputConsole);
                bool priceValid = priceRegex.IsMatch(inputConsole);

                //Check if all valid
                if (nameValid && productValid && quantityValid && priceValid)
                {
                    name = nameRegex.Match(inputConsole).Groups[1].Value.ToString();
                    product = productRegex.Match(inputConsole).Groups[1].Value.ToString();
                    quantity = int.Parse(quantityRegex.Match(inputConsole).Groups[1].ToString());
                    string priceStr = (priceRegex.Match(inputConsole).Groups[1].Value.ToString());
                    price = Convert.ToDouble(priceStr);
                    totalPrice = quantity * price;
                    income += totalPrice;
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                }
            }
            //string totalPriceStr = income
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
