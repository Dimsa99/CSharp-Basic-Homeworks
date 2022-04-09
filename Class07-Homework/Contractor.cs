using Exercise2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Contractor : Employee
    {
        public Contractor(string firstName, string lastName, Role role, double workHours, int payPerHour ) : base(firstName, lastName, role)
        {
            WorkHours=workHours;
            PayPerHour=payPerHour;
            
        }

        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager Responsible { get; set; }

        public override double GetSalary()
        {

            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public string CurrentPosition()
        {
            return Responsible.Department;
        }

    }
}
