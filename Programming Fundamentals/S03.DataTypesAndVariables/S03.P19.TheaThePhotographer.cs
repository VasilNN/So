using System;

namespace P19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong picturesTaken = ulong.Parse(Console.ReadLine());
            ulong filterTimeSeconds = ulong.Parse(Console.ReadLine());
            ulong filterFactor = ulong.Parse(Console.ReadLine());
            ulong pictureUploadTime = ulong.Parse(Console.ReadLine());

            ulong filteredPictures = (ulong)Math.Ceiling((1.0 * picturesTaken * filterFactor) / 100);
            ulong filterTime =picturesTaken * filterTimeSeconds;
            ulong totalUploadTime = filteredPictures * pictureUploadTime;
            ulong totalTime = totalUploadTime + filterTime;

            ulong seconds = totalTime % 60;
            ulong minutes = totalTime / 60;
            ulong hours = 0;
            ulong days = 0;

            if (minutes > 59)
            {
                hours = minutes / 60;
                minutes = minutes % 60;
            }

            if (hours > 23)
            {
                days = hours / 24;
                hours = hours % 24;
            }
            
            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
