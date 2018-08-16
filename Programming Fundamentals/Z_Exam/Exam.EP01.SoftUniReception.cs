using System;
using System.Collections.Generic;

namespace EP01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeCapacity = 0;
            for (int i = 0; i < 3; i++)
            {
                employeeCapacity += int.Parse(Console.ReadLine());
            }
            int studentsCount = int.Parse(Console.ReadLine());

            int workHours = 0;
            int breakHours = 0;

            while (studentsCount > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    studentsCount -= employeeCapacity;
                    workHours++;
                    if (studentsCount <= 0)
                    {
                        break;
                    }
                }
                if (studentsCount > 0)
                {
                    breakHours++;
                }
            }

            int timeTotal = workHours + breakHours;
            Console.WriteLine($"Time needed: {timeTotal}h.");
        }
    }
}
