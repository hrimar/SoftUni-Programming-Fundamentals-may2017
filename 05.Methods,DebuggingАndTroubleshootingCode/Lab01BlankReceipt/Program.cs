using System;
using System.Text;

namespace _01BlankReceipt
{
    class Program
    {

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
      
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PrintReceipt();
        }
    }
}
