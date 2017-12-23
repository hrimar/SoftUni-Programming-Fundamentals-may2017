using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Lab04MergeFiles
{
    class Lab04MergeFiles
    {
        static void Main()
        {
            var arr1 = File.ReadAllLines("Input1.txt").ToList();
            var arr2 = File.ReadAllLines("Input2.txt").ToList();
            var arr3 = new List<string>();

            // Така вкарва 1 ред от 1-ния файл и после от другия:
            for (int i = 0; i < arr1.Count; i++)
            {
                arr3.Add(arr1[i] + "\r\n" + arr2[i]);
            }
            Console.WriteLine(string.Join("\r\n", arr3));
            File.WriteAllLines("Output.txt", arr3);

            // Така е за да добави 2-рия след 1-вия:
            //var concatFiles = arr1.Concat(arr2);
            //File.WriteAllLines("Output.txt", concatFiles);
            //Console.WriteLine(string.Join("\r\n", concatFiles));
        }
    }
}
