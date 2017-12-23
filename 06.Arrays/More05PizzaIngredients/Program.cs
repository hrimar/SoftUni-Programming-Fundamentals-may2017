using System;
using System.Collections.Generic;
using System.Linq;

namespace More05PizzaIngredients
{
    class Program
    {
        static void Main()
        {           
            var ingredients = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
            var result = new List<string > ();

            for (int i = 0; i < ingredients.Length; i++)
            {
                if(ingredients[i].Length==n)
                {
                    if(result.Count>=10) // znaqi pri > dava 83/100 !!
                    {
                        break;
                    }
                    result.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                }
            }

            Console.WriteLine($"Made pizza with total of {result.Count} ingredients.");
            string final = string.Join(", ", result);
            Console.WriteLine($"The ingredients are: {final}.");
        }
    }
}
