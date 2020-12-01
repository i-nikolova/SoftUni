using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cars.Add(new Car(data[0], double.Parse(data[1]), double.Parse(data[2])));
            }

            string input = string.Empty;
            while ((input=Console.ReadLine())!="End")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cars[cars.FindIndex(x => x.Model == data[1])].CarDriving(double.Parse(data[2]));
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }


        }
        public class Car
        {
            public string Model { get; set; }
            public double FuelAmount { get; set; }
            public double FuelConsumption { get; set; }
            public double TraveledDistance { get; set; }
            public Car(string model, double fuelAmount, double fuelConsumption)
            {
                this.Model = model;
                this.FuelAmount = fuelAmount;
                this.FuelConsumption = fuelConsumption;
                this.TraveledDistance = 0;
            }
            public void CarDriving(double kmTraveled)
            {
                if (FuelAmount<kmTraveled*FuelConsumption)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                else
                {
                    this.TraveledDistance += kmTraveled;
                    this.FuelAmount -= kmTraveled * this.FuelConsumption;
                }
            }
            public override string ToString()
            {
                return $"{Model} {FuelAmount:f2} {TraveledDistance:f0}";
            }
        }

        

    }
    
}
