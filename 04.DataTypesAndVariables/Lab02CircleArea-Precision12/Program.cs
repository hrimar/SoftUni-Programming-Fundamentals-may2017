using System;

namespace Lab02CircleArea_Precision12
{
    class Program
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius;

            Console.WriteLine($"{area:f12}");
        }
    }
}
