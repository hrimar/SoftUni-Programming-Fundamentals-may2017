using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03Trainegram
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                var input = Console.ReadLine();
                if(input== "Traincode!")
                {
                    break;
                }

            var matched = Regex.Match(input, @"^(<\[[^a-zA-Z0-9]*?\]\.)(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?(\.\[[a-zA-Z0-9]*\]\.)?");
                if(input == matched.ToString())
                {
                     Console.WriteLine(input);
                }

            }
        
        }
    }
}
