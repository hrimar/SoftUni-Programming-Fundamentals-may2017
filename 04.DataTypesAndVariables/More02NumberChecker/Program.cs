using System;

namespace More02NumberChecker
{
    class Program
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());

            if (n % 1 == 0)
            {
                Console.WriteLine("integer");
            }
            else
                Console.WriteLine("floating-point");
        
    
        }
    }
}
