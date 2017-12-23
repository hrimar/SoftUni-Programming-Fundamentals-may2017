using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04DrawaFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopAndBottom(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintMiddle(n);
            }
            PrintTopAndBottom(n);         
        }
        private static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        private static void PrintMiddle(int n)
        {           
                Console.Write('-');
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
     
        }   
    }
}
