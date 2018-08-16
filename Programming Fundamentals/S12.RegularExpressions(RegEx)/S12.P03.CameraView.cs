using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace P03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string strInput = Console.ReadLine();
            string pattern = @"(\|<)(\w*)";

            List<string> locaions = new List<string>();

            Regex regex = new Regex(pattern);
            var sets = regex.Matches(strInput);

            foreach (Match item in sets)
            {
                string place = item.Groups[2].ToString();

                if (arrInput[0] + arrInput[1] > place.Length)
                {
                    locaions.Add(place.Substring(arrInput[0]));
                }
                else
                {
                    locaions.Add(place.Substring(arrInput[0],arrInput[1]));
                }
            }

            Console.WriteLine(string.Join(", ", locaions));
        }
    }
}
