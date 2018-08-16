using System;

namespace P11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            double distanceMiles = distanceMeters * 0.06215041;
            int totalSconds = hours * 3600 + minutes * 60 + seconds;
            float meteresPerSecond = (float)(1.0 * distanceMeters / totalSconds);
            float kilometersPerHour = (float)((1.0 * distanceMeters / totalSconds) * 3.6);
            float milesPerHour = (float)(1.0 * distanceMiles / totalSconds * 36);

            Console.WriteLine(meteresPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
