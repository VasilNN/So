using System;
using System.Collections.Generic;
using System.Linq;


namespace P06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create dictonary for user as key and IP is value
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                //Get the row with info from the console
                List<string> consoleInput = Console.ReadLine().Split(" ").ToList();

                //Save the User and the IpAdress
                string ipAddress = "";
                string user = "";

                //Exit from the program
                if (consoleInput.Contains("end") == true)
                {
                    break;
                }

                //Check if it's IP, message or User
                foreach (var element in consoleInput)
                {
                    List<string> checkForType = element.Split("=").ToList();

                    //Recognize and sepaate by type
                    for (int item = 0; item < 1; item++)
                    {
                        if (checkForType[item].ToString() == "IP")
                        {
                            ipAddress = checkForType[item + 1].ToString();
                        }
                        else if (checkForType[item].ToString() == "user")
                        {
                            user = checkForType[item + 1].ToString();
                        }
                    }
                }

                //////////////
                //Check if the user excist and if not create new one
                if (userLogs.ContainsKey(user) == false)
                {
                    userLogs.Add(user, new Dictionary<string, int>());
                }

                // Check if the IpAddress exist and if not create a new one
                if (userLogs[user].ContainsKey(ipAddress) == false)
                {
                    userLogs[user].Add(ipAddress, 0);
                }

                //Increase the count
                userLogs[user][ipAddress]++;
            }
            //Sort the dictonary
            foreach (var userKey in userLogs.Keys)
            {
                //Print the User
                string concatString = "";
                Console.WriteLine($"{userKey}: ");

                var tempUserKeyValue = userLogs[userKey];
                foreach (var ipKey in tempUserKeyValue.Keys)
                {
                    var count = tempUserKeyValue[ipKey];
                    concatString += ipKey + " => " + count + ", ";
                }
                string printString = concatString.Substring(0, concatString.Length - 2);
                Console.WriteLine(printString + ".");
            }
        }
    }
}
