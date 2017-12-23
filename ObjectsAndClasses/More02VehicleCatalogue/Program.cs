using System;
using System.Collections.Generic;
using System.Linq;

namespace More02VehicleCatalogue
{
    class CarTruck
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsPower { get; set; }
    }
    //class Truck
    //{       
    //    public string Model { get; set; }
    //    public string Color { get; set; }
    //    public int HorsPower { get; set; }
    //}
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var carTruckList = new List<CarTruck>();
            // var truckList = new List<Truck>();
            while (input != "End")
            {
                var inputDetails = input.Split();
                var type = inputDetails[0][0].ToString().ToUpper() + inputDetails[0].Substring(1);
                var model = inputDetails[1];
                var color = inputDetails[2];
                var power = int.Parse(inputDetails[3]);

                var carTruck = new CarTruck()
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    HorsPower = power
                };
                carTruckList.Add(carTruck);
                input = Console.ReadLine();
            }


            string order = Console.ReadLine();

            while (order != "Close the Catalogue")
            {

                var orderedCarTrucks = carTruckList.Where(a => a.Model == order).First(); //!!! .First()
                Console.WriteLine($"Type: {orderedCarTrucks.Type}");//
                Console.WriteLine($"Model: {orderedCarTrucks.Model}");
                Console.WriteLine($"Color: {orderedCarTrucks.Color}");
                Console.WriteLine($"Horsepower: {orderedCarTrucks.HorsPower}");
                order = Console.ReadLine();
            }
            if (carTruckList.Where(a => a.Type == "Car").Count() > 0)
            {
                var carsPower = carTruckList.Where(a => a.Type == "Car" || a.Type == "car")
                                .Select(a => a.HorsPower).Average();
                Console.WriteLine($"Cars have average horsepower of: {carsPower:f2}.");
            }
            else
                Console.WriteLine($"Cars have average horsepower of: {0.00:f2}.");
        
            if (carTruckList.Where(a => a.Type == "Truck"|| a.Type == "truck").Count() > 0)
            {
                var averagePowerTrucks = carTruckList.Where(a => a.Type == "Truck")
                               .Select(a => a.HorsPower).Average();
                Console.WriteLine($"Trucks have average horsepower of: {averagePowerTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0.00:f2}.");
            }

        }
    }
}
