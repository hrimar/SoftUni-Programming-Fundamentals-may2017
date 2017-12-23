using System;
using System.Collections.Generic;
using System.Linq;

namespace _03CirclesIntersection
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
    }
    class Program
    {
        static void Main()
        {
            Point p= new Point();
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

            var distance = CalcDistance(p1, p2);
           
            if(distance<=(p1.R+p2.R))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }            
        }      

        private static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = Math.Abs(p1.X - p2.X);
            int deltaY = Math.Abs(p1.Y - p2.Y);

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        private static Point ReadPoint()
        {
            var input = Console.ReadLine().Split();
            Point point = new Point();
            point.X = int.Parse(input[0]);
            point.Y = int.Parse(input[1]);
            point.R = int.Parse(input[2]);
            return point;
        }
    }
}
