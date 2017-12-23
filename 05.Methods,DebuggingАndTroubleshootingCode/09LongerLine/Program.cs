using System;

namespace _09LongerLine
{
    class Program
    {
        static void Main()
        {
            // задача с преизползване на 1 метод с разл. параметри:
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double closes1 = GetClosest(x1, y1);
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double closes2 = GetClosest(x2, y2);
            double distance1 = GetDistance(x1, y1, x2, y2);

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double closes3 = GetClosest(x3, y3);
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double closes4 = GetClosest(x4, y4);
            double distance2 = GetDistance(x3, y3, x4, y4);

            if (distance1 >= distance2)
            {
                if (closes1 <= closes2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else if (closes1 > closes2)
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else if (distance1 < distance2)
            {
                if (closes3 <= closes4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else if (closes3 > closes4)
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
           
        }

        private static double GetDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // смята хипотенизата т.е разсточнието

            return distance;

        }
        private static double GetClosest(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)); // смята хипотенизата т.е разсточнието

            return distance;
        }

    }
}
