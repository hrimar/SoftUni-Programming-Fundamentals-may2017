using System;

namespace _08CenterPodouble
{
    class Program
    {
        static void Main()
        {
            // задача с преизползване на 1 метод с разл. параметри:
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double distance1= GetClosest(x1, y1);

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double distance2 = GetClosest(x2, y2);

            if(distance1<distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else if (distance1 > distance2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
           else if (distance1 == distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        private static double GetClosest(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2)); // смята хипотенизата т.е разсточнието

            return distance;
        }
    }
}
