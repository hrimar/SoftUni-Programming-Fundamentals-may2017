using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10PriceChangeAlert
{
    class Program
    {
         static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double border = (double.Parse(Console.ReadLine())) * 100.0;


            double first = double.Parse(Console.ReadLine()); // за да не пита след първото число

            for (int i = 0; i < n - 1; i++)
            {
                double second = double.Parse(Console.ReadLine());
                double div = Proc(first, second);
                bool isSignificantDifference = imaliDif(div, border);

                string message = GetPriceInfo(second, first, div, isSignificantDifference);
                Console.WriteLine(message);

                first = second;
            }
        }

        private static string GetPriceInfo(double second, double first, double razlika, bool etherTrueOrFalse)
        {
            string to = string.Empty;

            if (razlika == 0)
            {
                to = string.Format("NO CHANGE: {0}", second);
            }
            else if (!etherTrueOrFalse)
            {
                to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", first, second, razlika);
            }
            else if (etherTrueOrFalse && (razlika > 0))
            {
                to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", first, second, razlika);
            }
            else if (etherTrueOrFalse && (razlika < 0))
                to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", first, second, razlika);
            return to;
        }
        private static bool imaliDif(double border, double isDiff)
        {
            if (Math.Abs(border) >= isDiff)
            {
                return true;
            }
            return false;
        }

        private static double Proc(double first, double second)
        {
            double percent = (second - first) / first;
            return (percent * 100.00);
        }
    }
}
