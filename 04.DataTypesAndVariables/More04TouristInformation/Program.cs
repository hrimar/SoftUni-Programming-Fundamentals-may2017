using System;

namespace More04TouristInformation
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            switch (type)
            {
                case "miles":                
                    Console.WriteLine($"{count} miles = {(count*1.6):f2} kilometers"); break;
                case "inches":               
                    Console.WriteLine($"{count} inches = {(2.54*count):f2} centimeters"); break;
                case "feet":              
                    Console.WriteLine($"{count} feet = {(count*30.0):f2} centimeters"); break;
                case "yards":                
                    Console.WriteLine($"{count} yards = {(0.91*count):f2} meters"); break;
                case "gallons":        
                    Console.WriteLine($"{count} gallons = {(count * 3.8):f2} liters"); break;
            }

        }
    }
}
