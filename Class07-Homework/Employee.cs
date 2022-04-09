using Exercise2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        protected double Salary;

        public Employee(string firstName, string lastName, Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName}, {LastName}, {Salary} ");

        }
        public virtual double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double salary)
        {
            Salary = salary;
        }

    }
}