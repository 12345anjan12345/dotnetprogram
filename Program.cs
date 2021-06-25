using System;

namespace EmployeeDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Anjan", "Ghimire", 2000000);
            Console.WriteLine("Name: " + e1.FullName);
            Console.WriteLine("Salary: " + e1.Salary);
            Console.WriteLine("\nSalary incremeneted by(10%): " + e1.IncrementSalary(10) + "\n");
            e1.Display();

            Console.ReadKey();
        }
    }
}
