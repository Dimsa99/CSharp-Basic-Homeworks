using EX3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myList = new List<Car>
            {
                new Car (5,"Opel","Corsa",Enum.Color.Brown,10000,1999),
                new Car (55,"Honda","Civic",Enum.Color.Red,1000000,2000),
                new Car (53,"Mazda","3",Enum.Color.Yellow,200000,1998),
                new Car (23,"Mazda","CX-3",Enum.Color.Green,10000,2007),
                new Car (15,"Peugeot","208",Enum.Color.Red,333333333,2010),
                new Car (33,"Ford","Punto",Enum.Color.Red,12323,2021)
            };

            //List<Car> redCars = myList.ForEach(car => car.Color = Enum.Color.Red).ToString();
            var redCars = myList.Where(car => car.Color == Enum.Color.Red).ToList();
            foreach(var car in redCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
