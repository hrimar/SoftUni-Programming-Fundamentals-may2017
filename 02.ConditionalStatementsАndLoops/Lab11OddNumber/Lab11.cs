using System;

namespace Lab11OddNumber
{
    class Lab11
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            while (Math.Abs(n) % 2!=1)
            {
                Console.WriteLine("Please write an odd number.");
                n= int.Parse(Console.ReadLine());
            }
            if (Math.Abs(n) % 2==1)
                Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
    }
}
