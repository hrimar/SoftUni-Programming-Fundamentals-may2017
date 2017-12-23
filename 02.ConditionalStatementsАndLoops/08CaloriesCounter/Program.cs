using System;

namespace _08CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var calories = 0;

            for (int i = 0; i < n; i++)
            {
                var product = Console.ReadLine().ToLower();

                switch(product)
                {
                    case "cheese":
                        calories += 500; break;
                    case "tomato sauce":
                        calories += 150; break;
                    case "salami":
                        calories += 600; break;
                    case "pepper":
                        calories += 50; break;
                }

            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
