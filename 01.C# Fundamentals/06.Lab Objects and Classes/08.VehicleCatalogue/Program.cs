using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _08.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Catalog catalogVehicle = new Catalog();
            catalogVehicle.Cars = new List<Car>();
            catalogVehicle.Trucks = new List<Truck>();
            while ((input = Console.ReadLine())!= "end")
            {
                string[] data = input.Split("/");
                
                if (data[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = data[1];
                    car.Model = data[2];
                    car.HorsePower = int.Parse(data[3]);
                    catalogVehicle.Cars.Add(car);
                }
                else if (data[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = data[1];
                    truck.Model = data[2];
                    truck.Weight = int.Parse(data[3]);
                    catalogVehicle.Trucks.Add(truck);
                }
                
            }

            List<Car> orderedCars = catalogVehicle.Cars.OrderBy(car => car.Brand).ToList();
            List<Truck> orderedTrucks = catalogVehicle.Trucks.OrderBy(car => car.Brand).ToList();

            if (catalogVehicle.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in orderedCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogVehicle.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in orderedTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        public class Catalog
        {
            public Catalog()
            {
                Car car = new Car();
                Truck truck = new Truck();
            }
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}
