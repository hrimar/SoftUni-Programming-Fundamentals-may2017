using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09MelrahShake
{
    class Program
    {
        static void Main()
        {
            var item = Console.ReadLine();
            var pattern = Console.ReadLine();
            var result = string.Empty;

            while (true)
            {
                var firstIndex = item.IndexOf(pattern);
                var lastIndex = item.LastIndexOf(pattern);
                if (lastIndex != -1 && firstIndex != -1 && 
                    lastIndex != firstIndex && pattern.Length>0)
                {
                   item = item.Remove(lastIndex, pattern.Length);
                    item = item.Remove(firstIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    Console.WriteLine("Shaked it.");

                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(item);
                    break;
                }
            }
            
        }
    }
}
