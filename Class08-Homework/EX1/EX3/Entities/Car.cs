using EX3.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX3.Entities
{
    public class Car
    {
        public int Id { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public Color Color { get; set; }

        public int DistanceTraveled { get; set; }

        public int DateOfModel { get; set; }

        

        public Car(int id, string brandName, string modelName, Color color, int distanceTraveled, int dateOfModel)
        {
            Id=id;
            BrandName=brandName;
            ModelName=modelName;
            Color=color;
            DistanceTraveled=distanceTraveled;
            DateOfModel=dateOfModel;
        }
        public int CalculatePrice()
        {
            //return (DistanceTraveled * CalculateYear(DateOfModel)) / 3;
            return (DistanceTraveled * DateOfModel) / 3;
        }
        //public int CalculateYear(DateTime year)
        //{
        //    return DateTime.Now.Year - year.Year;
        //}
        //public void RedCars()
        //{
        //    if (Color == Color.Red)
        //    {
        //        foreach (Car car in BrandName )
        //        {
        //            Console.WriteLine(car.Color);
        //        }
        //    }
            
        //}

    }
}
