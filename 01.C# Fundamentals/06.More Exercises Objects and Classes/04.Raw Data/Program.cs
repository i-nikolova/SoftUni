using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Raw_Data
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
                cars.Add(new Car(data[0], 
                    new Engine(int.Parse(data[1]), int.Parse(data[2])), 
                    new Cargo(int.Parse(data[3]), data[4])));

            }

            string input = Console.ReadLine();
            if (input == "fragile")
            {
                List<Car> fragile = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000).ToList();

                if (fragile.Count>0)
                {
                    foreach (var car in fragile)
                    {
                        Console.WriteLine(car.ToString());
                    }
                }
            }
            else
            {
                List<Car> flamable = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
                foreach (var car in flamable)
                {
                    Console.WriteLine(car.ToString());
                }

            }
        }

        public class Car
        {
            public string Model { get; set; }
            public Engine Engine { get; set; }

            public Cargo Cargo { get; set; }

            public Car(string model, Engine engine,Cargo cargo)
            {
                this.Model = model;
                this.Engine = engine;
                this.Cargo = cargo;
            }

            public override string ToString()
            {
                return $"{Model}";
            }
        }

        public class Engine
        {
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }

            public Engine(int speed,int power)
            {
                this.EnginePower = power;
                this.EngineSpeed = speed;
            }
        }
        public class Cargo
        {
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }

            public Cargo(int weight,string type)
            {
                this.CargoType = type;
                this.CargoWeight = weight;
            }
        }
    }
}
