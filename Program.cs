using System;

namespace MultilevelInheritanceDemo
{
    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }

        public Employee(string name, int employeeId) : base(name)
        {
            EmployeeId = employeeId;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
        }
    }

    class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string name, int employeeId, string department) : base(name, employeeId)
        {
            Department = department;
        }

        public void DisplayManager()
        {
            Console.WriteLine($"Department: {Department}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("John", 123, "HR");
            manager.Display(); // Output: Name: John
            manager.DisplayEmployee(); // Output: Employee ID: 123
            manager.DisplayManager(); // Output: Department: HR
        }
    }
}

