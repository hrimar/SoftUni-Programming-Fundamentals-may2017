using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05CalculateTriangleArea
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height =double.Parse(Console.ReadLine());

            double area = (GetTriangleArea(width, height));
            Console.WriteLine(area);
        }

        private static double GetTriangleArea(double width, double height)
        {
            return (height * width)/2;      
        }
    }
}
