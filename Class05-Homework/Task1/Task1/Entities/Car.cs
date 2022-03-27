using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Entities
{
    public class Car
    {
        public Driver Drivers;
        public string Model { get; set; }

        public int Speed { get; set; }
        

        public int CalculateSpeed(int speed,int skill)
        {
            return speed * skill;
        }

        public Car(Driver driver, string model, int speed)
        {
            Drivers = driver;
            Model = model;
            Speed = speed;
            CalculateSpeed(Speed, Drivers.Skill);
        }
    }
}
