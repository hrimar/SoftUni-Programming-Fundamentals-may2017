using System;
using System.Collections.Generic;
using System.Linq;

namespace _05CompareCharArrays
{
    class Program
    {
        static void Main()
        {
           var chars1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var chars2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var shortestArray = Math.Min(chars1.Length, chars2.Length);

            var chars1Counter = 0;
            var chars2Counter = 0;

            for (int i = 0; i < chars1.Length; i++)
            {
                chars1Counter += (int)chars1[i];
            }
            //Console.WriteLine(chars1Counter);

            for (int i = 0; i < chars2.Length; i++)
            {
                chars2Counter += (int)chars2[i];
            }
            //Console.WriteLine(chars2Counter);
            if (chars1Counter < chars2Counter)
            {
                Console.WriteLine(string.Join("", chars1));
                Console.WriteLine(string.Join("", chars2));
            }
            else if (chars1Counter > chars2Counter)
            {
                Console.WriteLine(string.Join("", chars2));
                Console.WriteLine(string.Join("", chars1));
            }
            else if (chars1Counter == chars2Counter && chars1.Length > chars2.Length)
            {
                Console.WriteLine(string.Join("", chars2));
                Console.WriteLine(string.Join("", chars1));
            }
            else if (chars1Counter == chars2Counter && chars1.Length < chars2.Length)
            {
                Console.WriteLine(string.Join("", chars1));
                Console.WriteLine(string.Join("", chars2));
            }
            else if (chars1.Length < chars2.Length)
            {
                Console.WriteLine(string.Join("", chars1));
                Console.WriteLine(string.Join("", chars2));
            }
            else if (chars1.Length > chars2.Length)
            {
                Console.WriteLine(string.Join("", chars2));
                Console.WriteLine(string.Join("", chars1));
            }
            else if (chars1.Length == chars2.Length)
            {
                Console.WriteLine(string.Join("", chars2));
                Console.WriteLine(string.Join("", chars1));
            }
        }
    }
}
