using System;

namespace More12BeerKegs
{
    class Program
    {
        static void Main()
        {
            // Бре???
            int n = int.Parse(Console.ReadLine());
            double volume = 0;
            double result = 0;
            string bigestType = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string type = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * height;
                           
                if (volume > result)
                {
                    result = volume;
                    bigestType = type;
                }
            }
           
           Console.WriteLine($"{bigestType}");
        }
    }
}
