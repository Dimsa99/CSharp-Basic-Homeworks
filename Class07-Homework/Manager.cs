using Exercise2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class Manager : Employee
    {
        public Manager(string firstName, string lastName, Role role, double bonus, string department) : base(firstName, lastName, role)
        {
            Bonus=bonus;
            Department=department;
        }
        private double Bonus { get; set; }

        public string Department { get; set; }

        public override double GetSalary()
        {

            return Salary + Bonus;
        }
        public double AddBonus()
        {
            return Bonus;
        }
    }
}
