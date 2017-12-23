using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab02CountSubstringOccurrences
{
    class Lab02CountSubstringOccurrences
    {
        static void Main()
        {
            // Дълго решение:
            //var text = Console.ReadLine().ToLower();
            //var str = Console.ReadLine().ToLower();
            //int count = 0;
            //int lastIndex = -1;

            //while (true)
            //{
            //    var index = text.IndexOf(str, lastIndex + 1);
            //    if (index != -1)
            //    {
            //        count++;
            //        lastIndex = index;
            //        // или lastIndex = index + str.Length-1; - за да няма засичане!
            //    }
            //    else
            //        break;
            //}
            //Console.WriteLine(count);

            // Решение 2:
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = input.IndexOf(pattern);
            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }
            Console.WriteLine(counter);


            // Кратко решение:
            // var text=Console.ReadLine();
            // var str = Console.ReadLine();
            // int count = 0;
            //var  index = -1;
            // while ((index=text.IndexOf(str, index+1) ) != -1)
            // {
            //     count++;
            // }
            // Console.WriteLine(count);
        }
    }
}
