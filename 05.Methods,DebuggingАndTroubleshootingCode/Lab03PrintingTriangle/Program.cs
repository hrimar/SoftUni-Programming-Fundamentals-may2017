using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03PrintingTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            PrintTriangle(1, n);
        }

        private static void PrintTriangle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                PrintLine(i);
                Console.WriteLine();
            }
            for (int i = end-1; i > start-1; i--)
            {
                PrintLine(i);
                Console.WriteLine();
            }    
        }

        private static void PrintLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
        }
    }
}
