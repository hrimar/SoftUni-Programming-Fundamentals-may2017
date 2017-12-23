using System;

namespace _07CakeIngredients
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var counter = 0;
            

            while (input!="Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                counter++;
                input = Console.ReadLine();
            }
            // string gredient = counter == 1 ? "ingredient" : "ingredients";
            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}
