using System;
using Task1.Entities;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = { new Car(new Driver("Dimitar", 5),"Opel",50),
            new Car(new Driver("Tanja", 3),"Peugeot",150),
            new Car(new Driver("Marko", 4),"Honda",110),
            new Car(new Driver("Ceko", 2),"Ford",88)};
            Console.WriteLine("Choose your first vehicle:");
            PrintCars(cars);
            bool isParsedCarOne = int.TryParse(Console.ReadLine(), out int inputCarOne);
            if (!CheckInput(isParsedCarOne, inputCarOne)) return;

            Console.WriteLine("Choose your first driver:");
            PrintDriver(cars);
            bool isParsedDriverOne = int.TryParse(Console.ReadLine(), out int inputDriverOne);
            if (!CheckInput(isParsedDriverOne, inputDriverOne)) return;

            Console.WriteLine("Choose your second vehicle:");
            PrintCars(cars);
            bool isParsedCarTwo = int.TryParse(Console.ReadLine(), out int inputCarTwo);
            if(!CheckInput(isParsedCarTwo, inputCarTwo)) return;
            if(!CheckIdenticalCar(inputCarOne, inputCarTwo)) return;

            Console.WriteLine("Choose your second driver:");
            PrintDriver(cars);
            bool isParsedDriverTwo = int.TryParse(Console.ReadLine(), out int inputDriverTwo);
            if(!CheckInput(isParsedDriverTwo, inputDriverTwo)) return;
            if(!CheckIdenticalDriver(inputDriverTwo,inputDriverOne)) return;

            RaceCars(cars, inputCarOne, inputDriverOne, inputCarTwo, inputDriverTwo);





        }

        static void RaceCars(Car[] cars, int carOne, int driverOne, int carTwo, int driverTwo)
        {
            if (cars[carOne - 1].CalculateSpeed(cars[carOne - 1].Speed, cars[driverOne - 1].Drivers.Skill) > cars[carTwo - 1].CalculateSpeed(cars[carTwo - 1].Speed, cars[driverTwo - 1].Drivers.Skill))
            {
                Console.WriteLine($"WINNER: \nModel: {cars[carOne - 1].Model} \nSpeed: {cars[carOne - 1].Speed}km\\h \nDriver: {cars[driverOne - 1].Drivers.Name}");
            }
            else Console.WriteLine($"WINNER: \nModel: {cars[carTwo - 1].Model} \nSpeed: {cars[carTwo - 1].Speed}km\\h \nDriver: {cars[driverTwo - 1].Drivers.Name}");
        }
        static void PrintCars(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
        }
        static void PrintDriver(Car[] driver)
        {
            for (int i = 0; i < driver.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {driver[i].Drivers.Name}");
            }
        }
        static bool CheckInput(bool parse, int input)
        {
            if (!parse || input > 4)
            {
                Console.WriteLine("Invalid input");
                return false;
            }
            else { return true; };
        }
        static bool CheckIdenticalDriver(int firstInput,int secondInput)
        {
            if(firstInput == secondInput)
            {
                Console.WriteLine("Can't pick the same driver!");
                return false;

            }
            else { return true; }
        }
        static bool CheckIdenticalCar(int firstInput, int secondInput)
        {
            if (firstInput == secondInput)
            {
                Console.WriteLine("Can't pick the same car!");
                return false;

            }
            else { return true; }
        }
    }
}
