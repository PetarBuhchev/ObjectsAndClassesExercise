using System;
using System.Collections.Generic;

namespace P06.VehicleCatalogue2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            string[] input = Console.ReadLine().Split();

            int carsNum = 0;
            int trucksNum = 0;
            double carsHP = 0;
            double trucksHP = 0;

            while (input[0] != "End")
            {
                Vehicle vehicle = new Vehicle(input[0], input[1], input[2], int.Parse(input[3]));
                if (input[0] == "car")
                {
                    carsNum++;
                    carsHP += int.Parse(input[3]);
                }
                if (input[0] == "truck")
                {
                    trucksNum++;
                    trucksHP += int.Parse(input[3]);
                }
                vehicles.Add(vehicle);
                input = Console.ReadLine().Split();
            }
            double avrgHPcars = carsHP / carsNum;
            double avrgHPtrucks = trucksHP / trucksNum;

            input = Console.ReadLine().Split();
            while (string.Join(" ", input) != "Close the Catalogue")
            {
                foreach (Vehicle vehicle in vehicles) 
                {
                    if (input[0] == vehicle.Model)
                    {
                        if (vehicle.Type == "car")
                        {
                            Console.WriteLine("Type: Car");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                            break;
                        }
                        if (vehicle.Type == "truck")
                        {
                            Console.WriteLine("Type: Truck");
                            Console.WriteLine($"Model: {vehicle.Model}");
                            Console.WriteLine($"Color: {vehicle.Color}");
                            Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                            break;
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
            if (carsNum == 0)
            {
                avrgHPcars = 0;
                Console.WriteLine($"Cars have average horsepower of: {avrgHPcars:f2}.");
            }
            if (trucksNum == 0)
            {
                avrgHPtrucks = 0;
                Console.WriteLine($"Trucks have average horsepower of: {avrgHPtrucks:f2}.");
            }
            else
            {
            Console.WriteLine($"Cars have average horsepower of: {avrgHPcars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avrgHPtrucks:f2}.");
            }
        }
        public class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
    }
}
