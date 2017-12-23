﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07GreaterofTwoValues
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                var result = GetMax(first, second);
                Console.WriteLine(result);
            }
            else if(type=="char")
            {
               char first  = char.Parse(Console.ReadLine());
               char second = char.Parse(Console.ReadLine());
                var result = GetMax(first, second);
                Console.WriteLine(result);

            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                var result = GetMax(first, second);
                Console.WriteLine(result);
            }


        }

        private static int GetMax(int first, int second)
        {
            if(first>second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        private static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        private static string GetMax(string first,string second)
        {
            var result = string.Compare(first, second);
            if (result>0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
