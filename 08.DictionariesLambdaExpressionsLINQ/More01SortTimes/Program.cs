using System;
using System.Collections.Generic;
using System.Linq;

namespace More01SortTimes
{
    class Program
    {
        static void Main()
        {
            // Извод: Ако не кажа .ToArray(), за да създаде нова кол-я не получавам желания резултат!
            // Дори не се наложи да казвам , че са DataTime !?
            var times = Console.ReadLine().Split().OrderBy(a=>a).ToArray();

            Console.WriteLine(string.Join(", ", times));
        }
    }
}
