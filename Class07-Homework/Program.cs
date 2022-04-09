using System;
using System.Collections.Generic;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> company = new List<Employee>
            {
                new Contractor("Dimitar","Josifovski",Enum.Role.Sales,35,5),
                new Contractor("Stefan","Josifovski",Enum.Role.Manager,40,6),
                new Manager("David","Shumanski",Enum.Role.Other,6,"public relations"),
                new Manager("Michael","Shumacher",Enum.Role.Sales,5,"HR"),
                new SalesPerson("Jeff","Bezos",Enum.Role.Manager,10,5)
            };

            CEO ceo = new CEO("Chris", "Metzen", Enum.Role.Manager, company, 10, 15);
            ceo.PrintInfo();
            Console.WriteLine("CEO");
            Console.WriteLine($"First name {ceo.FirstName}, last name : {ceo.LastName}, and his salary is: {ceo.GetSalary()}");
            ceo.PrintEmployees();
        }
    }
}
