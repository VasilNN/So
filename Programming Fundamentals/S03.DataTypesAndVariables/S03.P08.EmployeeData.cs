using System;

namespace P08.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeFirstName = Console.ReadLine();
            string employeeLastName = Console.ReadLine();
            int employeeAge = int.Parse(Console.ReadLine());
            char employeeGender = char.Parse(Console.ReadLine());
            ulong employeePersinalIdNumber = ulong.Parse(Console.ReadLine());
            uint employeeUniqueNumber = uint.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {employeeFirstName}");
            Console.WriteLine($"Last name: {employeeLastName}");
            Console.WriteLine($"Age: {employeeAge}");
            Console.WriteLine($"Gender: {employeeGender}");
            Console.WriteLine($"Personal ID: {employeePersinalIdNumber}");
            Console.WriteLine($"Unique Employee number: {employeeUniqueNumber}");
        }
    }
}
