using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more07TrainingHallEquipment
{
    class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var numberItems = int.Parse(Console.ReadLine());
            var current = budget;
            var subtotal = 0.0;

            for (int i = 0; i < numberItems; i++)
            {
                var itemName = Console.ReadLine();
                var itemPrice = double.Parse(Console.ReadLine());
                var itemCount = int.Parse(Console.ReadLine());

                if(itemCount==1)
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                else
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                subtotal += itemPrice * itemCount;
                if (budget - (itemPrice * itemCount)<0)
                {
                    Console.WriteLine($"Subtotal: ${subtotal:f2}");
                    Console.WriteLine($"Not enough. We need ${Math.Abs(budget - (itemPrice * itemCount)):f2} more.");
                    return;
                }
              
                budget -= (itemPrice*itemCount);


            }
            Console.WriteLine($"Subtotal: ${current-budget:f2}");
            Console.WriteLine($"Money left: ${budget:f2}");

        }
    }
}
