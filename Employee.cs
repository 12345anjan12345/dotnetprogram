using System;

namespace EmployeeDisplay
{
    class Employee
    {
        string firstName;
        string lastName;
        double salary;

        public Employee(string first_name, string last_name, double salary)
        {
            firstName = first_name;
            lastName = last_name;
            this.salary = salary;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public string FullName => firstName + " " + lastName;

        public double IncrementSalary(double s)
        {
            double increment = (s / 100) * salary;
            salary = salary + increment;

            return increment;
        }

        public void Display()
        {
            Console.WriteLine("Name: \"" + FullName + "\" | Salary: " + salary);
        }
    }
}
