using Exercise2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName, Role role, double salary, double successSaleRevenue) : base(firstName, lastName, role)
        {
            role = Role.Sales;
            Salary = 500;
            SuccessSaleRevenue = successSaleRevenue;
        }

        private double SuccessSaleRevenue { get; set; }

        public double AddSuccessRevenue(double number)
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return Salary += 500;
            }
            else if (SuccessSaleRevenue > 2000 || SuccessSaleRevenue <= 5000)
            {
                return Salary += 1000;
            }
            else if (SuccessSaleRevenue > 5000)
            {
                return Salary += 1500;
            }
            else { Console.WriteLine("Invalid input"); }
            return number;
        }
        public override double GetSalary()
        {
            return Salary + SuccessSaleRevenue;
            
        }
    }
}