using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06MathPower
{
    class Program
    {
        static void Main()
        {

            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result= GetPower(number, power);
            Console.WriteLine(result);
        }

        private static double GetPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
