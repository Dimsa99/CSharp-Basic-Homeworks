using Exercise2.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    public class CEO : Employee
    {
        public CEO(string firstName, string lastName, Role role, List<Employee> employees, int shares,double sharesPrice) : base(firstName, lastName, role)
        {
            Employees=employees;
            Shares=shares;
            _SharesPrice=sharesPrice;
        }

        public List<Employee> Employees { get; set; }

        public int Shares { get; set; }

        private double _SharesPrice; 

        public void AddSharesPrice(double sharesPrice)
        {
            _SharesPrice = sharesPrice;
        }

        public void PrintEmployees()
        {
            Employees.ForEach(Console.WriteLine);
        }

        public override double GetSalary()
        {
            return base.GetSalary() + Shares * _SharesPrice;
        }
    }
}
