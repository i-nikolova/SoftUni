using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfEmployees = int.Parse(Console.ReadLine());
            List<Department> departments = new List<Department>();
            for (int i = 0; i < numbersOfEmployees; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!departments.Any(x => x.Name == data[2]))
                {
                    departments.Add(new Department(data[2]));
                }
                departments.Find(x => x.Name == data[2]).AddNewEmploye(data[0], double.Parse(data[1]));
            }

            Department bestDepartmet = departments.OrderByDescending(x => x.TotalSalary / x.Employees.Count()).First();
            Console.WriteLine($"Highest Average Salary: {bestDepartmet.Name}");

            foreach (var employee in bestDepartmet.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }
            public Employee(string name, double salary)
            {
                this.Name = name;
                this.Salary = salary;
            }
        }

        public class Department
        {
            public string Name { get; set; }
            public List<Employee> Employees { get; set; } = new List<Employee>();
            public double TotalSalary { get; set; }

            public void AddNewEmploye(string employeeName, double employeeSalary)
            {
                this.TotalSalary += employeeSalary;
                this.Employees.Add(new Employee(employeeName, employeeSalary));
                

            }
            public Department(string name)
            {
                this.Name = name;
                 
            }
        }

    }
}
