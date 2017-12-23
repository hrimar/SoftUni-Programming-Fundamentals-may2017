using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03TextFilter
{
    class Lab03TextFilter
    {
        static void Main()
        {
            var separators = ",. !?".ToCharArray();
            var surched = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine(); // .Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var word in surched)
            {
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            // Пример за Trim:
            //var text = "@ @!toto---@! ";
            //text = text.Trim('@', '!', ' ', '-');
            //Console.WriteLine(text);
        }
    }
}
