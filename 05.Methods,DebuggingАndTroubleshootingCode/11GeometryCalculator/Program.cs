using System;

namespace _11GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            var type = Console.ReadLine();

            CheckType(type);

        }

        private static void CheckType(string type)
        {
            if (type == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = CalculatingTriangleArea(side, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = CalculatingSquareArea(side);
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "rectangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = CalculatingRectangleArea(side, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var area = CalculatingCircleArea(radius);
                Console.WriteLine($"{area:f2}");
            }
        }

        private static double CalculatingCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private static double CalculatingRectangleArea(double side, double height)
        {
            return side * height;
        }

        private static double CalculatingSquareArea(double side)
        {
            return (side * side);
        }

        private static double CalculatingTriangleArea(double side, double height)
        {
           return (side*height)/ 2;
        }
    }
}
