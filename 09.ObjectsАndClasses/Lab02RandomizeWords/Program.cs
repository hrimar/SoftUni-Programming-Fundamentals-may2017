using System;
using System.Collections.Generic;

namespace Lab02RandomizeWords
{
    class Program
    {
        static void Main()
        {
            // не разбрах, значи само избираен 1-ва Random word???
            var words = Console.ReadLine().Split();
            Random r = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                var pos2 = r.Next(words.Length);
                var temp = pos1;
                pos1 = pos2;
                pos1 = temp;

                //Console.WriteLine(word);
            }
            Console.WriteLine(string.Join("\n", words));
        }
    }
}
