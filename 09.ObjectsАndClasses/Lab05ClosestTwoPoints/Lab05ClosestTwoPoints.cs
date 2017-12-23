using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05ClosestTwoPoints
{

    // провери защо не смята вярно!!!!!

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Lab05ClosestTwoPoints
    {
        static void Main()
        {
            Point[] points= ReadPoints(); // 1.

            Point[] closestPoints=FindClosestTwoPoints(points);  // 2. 

            PrintDistance(closestPoints);   //   3. 

            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        private static void PrintPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        private static void PrintDistance(Point[] points)
        {
            double distance = CalcDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;

            Point[] closestTwoPoints = null; // ?!?

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    double distance = CalcDistance(points[i], points[j]);

                    if(distance<minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[i], points[j] };
                    }
                }
            }
            return closestTwoPoints;
        }

        private static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = Math.Abs(p1.X - p2.X);
            int deltaY = Math.Abs(p1.Y - p2.Y);
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return distance;
        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n]; // !!!!!!!!!
                        
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        private static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point();
            point.X = pointInfo[0];
            point.Y = pointInfo[1];

            return point;
        }
    }
}
