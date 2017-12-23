using System;
using System.Collections.Generic;
using System.Linq;

namespace Море05ParkingValidation
{
    class More05ParkingValidation
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var carsInfo = Console.ReadLine().Split().ToArray(); ;
                var regUnreg = carsInfo[0];
                var name = carsInfo[1];
                

                if (regUnreg == "register")
                {
                    var car = carsInfo[2];
                    bool isLegal = CarValidator(car);


                    if (result.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {car}");
                    }
                    else if (!isLegal)
                    {
                        Console.WriteLine($"ERROR: invalid license plate {car}");
                    }
                    else if (result.ContainsValue(car))
                    {
                        Console.WriteLine($"ERROR: license plate {car} is busy");
                    }
                    else
                    {
                        result[name] = car;
                        Console.WriteLine($"{name} registered {car} successfully");
                    }


                }

                else if (regUnreg == "unregister")
                {
                    if (!result.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        result.Remove(name);
                        Console.WriteLine($"user {name} unregistered successfully");
                    }
                }
            }
            foreach (var res in result)
            {
                var name = res.Key;
                var car = res.Value;
                Console.WriteLine($"{res.Key} => {car}");
            }
        }

        private static bool CarValidator(string car)
        {
            var isLegal = false;
            //for (int i = 0; i < car.Length; i++)// ооо нямам проверка за бр. символи
            //{
            //    if(char.IsUpper(car[0]) && char.IsUpper(car[1]) && char.IsUpper(car[6]) && char.IsUpper(car[7]))
            //    {
            //        if(char.IsNumber(car[2]) && char.IsNumber(car[3]) && char.IsNumber(car[4]) && char.IsNumber(car[5]))
            //        {
            //            isLegal = true;
            //        }
            //    }
            //}
            if (car.Length == 8
               && car.Take(2).All(char.IsUpper)
               && car.Skip(2).Take(4).All(char.IsDigit)
               && car.Skip(6).Take(2).All(char.IsUpper))
            {
                isLegal = true;
            }
            return isLegal;
        }
    }
}
