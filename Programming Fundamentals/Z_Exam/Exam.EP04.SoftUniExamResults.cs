using System;
using System.Collections.Generic;
using System.Linq;

namespace EP04.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {

            string consoleInput = string.Empty;

            //"{username}-{language}-{points}" 
            var studentsDictonary = new Dictionary<string, int>();

            //{language} – {submissionsCount}
            var languageDictonary = new Dictionary<string, int>();

            //Main Cycle
            while ((consoleInput = Console.ReadLine()) != "exam finished")
            {
                string[] inputArray = consoleInput.Split("-").ToArray();

                //Check if banned
                if (inputArray.Contains("banned"))
                {
                    string studentName = inputArray[0];

                    if (studentsDictonary.ContainsKey(studentName) == true)
                    {
                        studentsDictonary.Remove(studentName);
                    }
                }
                else
                {
                    string studentName = inputArray[0];
                    string studentLanguage = inputArray[1];
                    int studentPoints = int.Parse(inputArray[2]);

                    //Set Get the name
                    if (studentsDictonary.ContainsKey(studentName) == false)
                    {
                        studentsDictonary.Add(studentName, new int());
                    }

                    //Check the score
                    int lastScore = studentsDictonary[studentName];
                    if (lastScore < studentPoints)
                    {
                        studentsDictonary[studentName] = studentPoints;
                    }

                    //Get the language sumbision count
                    if (languageDictonary.ContainsKey(studentLanguage) == false)
                    {
                        languageDictonary.Add(studentLanguage, new int());
                    }
                    //Increment the count
                    languageDictonary[studentLanguage]++;
                }
            }

            //Print
            Console.WriteLine("Results:");
            foreach (var student in studentsDictonary.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var langauge in languageDictonary.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{langauge.Key} - {langauge.Value}");
            }
        }
    }
}
