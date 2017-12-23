using System;

namespace _02ChooseaDrink2._0
{
    class Program
    {
        static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var price = -1.0;
            var type = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    price = 0.70;      break;
                case "Businessman":
                case "Businesswoman":
                    price = 1.00; break;
                case "SoftUni Student":
                    price = 1.70; break;
                default:
                    price = 1.20; break;
            }
            Console.WriteLine($"The {profession} has to pay {price*quantity:f2}.");
        }
    }
}
