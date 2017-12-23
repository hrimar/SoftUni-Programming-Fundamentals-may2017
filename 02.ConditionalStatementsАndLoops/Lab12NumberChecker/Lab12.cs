using System;

namespace Lab12NumberChecker
{
    class Lab12
    {
        static void Main()
        {
            // Решение с Try-Catch:
            try
            {
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
           
                
            // Решение с TryPrase:
            //var input = Console.ReadLine();
            //int n;
            //bool parsed = int.TryParse(input, out n);

            //if (parsed)
            //{
            //    Console.WriteLine("It is a number.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input!");
            //}
        }
    }
}
