using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04DistanceBetweenPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Lab04DistanceBetweenPoints
    {
        static void Main()
        {
            //Point p = new Point() { X = 5, Y = 7 };
            //Console.WriteLine($"Point: {p.X}, {p.Y}");
            Point p = new Point();

            Point p1 = ReadPoint();
            Point p2 = ReadPoint();
            var distance=CalcDistance(p1, p2);

            Console.WriteLine($"{distance:f3}");
        }

        static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point=new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = Math.Abs(p1.X - p2.X);
            int deltaY = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }
    }
}
