using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab01MatchFullName
{
    class Lab01MatchFullNamegram
    {
        static void Main()
        {
            //Вариант 1:
            var text = Console.ReadLine();
            var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
      
            var mached = Regex.Matches(text, pattern);
            foreach (Match item in mached)
            {
                Console.Write(item.Value + " "); // защо е item.Value, като може и без Value???
            }
            Console.WriteLine();

            // Вариант 2:
            //var text = Console.ReadLine();
            //var pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            //Regex regex = new Regex(pattern);
            //var mached = regex.Matches(text);
            //foreach (Match item in mached)
            //{
            //    Console.Write(item+" ");
            //}
            //Console.WriteLine();
        }
    }
}
