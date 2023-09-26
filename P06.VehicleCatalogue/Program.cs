using System;
using System.Collections.Generic;

namespace P06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> listOfVehicles = new List<Vehicle>();

            string[] input = Console.ReadLine().Split();
            while (input[0] != "End") 
            {
                Vehicle vehicle = new Vehicle();
                vehicle.Type = input[0];
                vehicle.Model = input[1];
                vehicle.Color = input[2];
                vehicle.HorsePower = int.Parse(input[3]);
                listOfVehicles.Add(vehicle);
                input = Console.ReadLine().Split();
            }
            List<Vehicle> sorted = new List<Vehicle>();
            input = Console.ReadLine().Split();
            while (input[0] != "Close")
            {
                foreach (Vehicle vehicle in listOfVehicles)
                {
                    if (vehicle.Model == input[0])
                    {
                        if (vehicle.Type == "car")
                        {
                        Console.WriteLine("Type: Car");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        }
                        else if (vehicle.Type == "truck")
                        {
                            Console.WriteLine("Type: Truck");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
            int sumHorsePowerCars = 0;
            int numCars = 0;
            int sumHorsePowerTrucks = 0;
            int numTrucks = 0;

            foreach (Vehicle vehicle in listOfVehicles) 
            {
                if (vehicle.Type == "truck")
                {
                    sumHorsePowerTrucks += vehicle.HorsePower;
                    numTrucks++;
                }
                else if (vehicle.Type == "car")
                {
                    sumHorsePowerCars += vehicle.HorsePower;
                    numCars++;
                }
            }
            double avrgHPcars = (double)sumHorsePowerCars / numCars;
            double avrgHPtrucks = (double)sumHorsePowerTrucks / numTrucks;

 
            Console.WriteLine($"Cars have average horsepower of: {avrgHPcars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrgHPtrucks:f2}.");
        }
        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
    }
}
