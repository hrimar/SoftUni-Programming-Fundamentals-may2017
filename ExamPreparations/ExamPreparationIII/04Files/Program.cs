using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04Files
{
    class File
    {
        public string Name { get; set; }
        public string Root { get; set; }
        public decimal Size { get; set; }
        public string Extension { get; set; }
    }

    class Program
    {
        static void Main()
        {
            //  80/100 - проблема е че може да има eднакви файлове в разлячни директории
            // а ние след филтрацията ги махаме
            var n = int.Parse(Console.ReadLine());
            var dirWithFiles = new List<File>();  

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('\\').ToArray();
                var root = input[0]; // ima li root
                var fileSize = input.Last().Split(';').ToArray();
                var name = fileSize[0];
                var extensions = name.Split('.').ToArray();
                var extension = extensions.Last();
                var size = decimal.Parse(fileSize[1]);

                var file = new File
                {
                    Name = name,
                    Root = root,
                    Size = size,
                    Extension=extension
                };

                dirWithFiles.Add(file);

              
            }
            var surcedFiles = Regex.Split(Console.ReadLine(), @"\s+").ToArray();
            var surcedRoot = surcedFiles.Last();
            var surType = surcedFiles[0];

            // Така с .Where(f => f.Root == surcedRoot).Where(f => f.Extension == surType) дава 80/100:
            var reqestedFiles = dirWithFiles.OrderByDescending(a => a.Size).ThenBy(a=>a.Name)
                    .Where(f => f.Root == surcedRoot).Where(f => f.Extension == surType).ToList();

            if (reqestedFiles.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in reqestedFiles)
                    Console.WriteLine($"{item.Name} - {item.Size} KB");
            }
           
            // Така с .Contains дава 70/100 заради време:
            //var requestedFiles = true;
            //foreach (var item in dirWithFiles)
            //{
            //    if (item.Root.Contains(surcedRoot) && item.Extension.Contains(surType))
            //    {
            //            Console.WriteLine($"{item.Name} - {item.Size} KB");
            //        requestedFiles = false; 
            //    }               
            //}
            //if (requestedFiles)
            //{
            //    Console.WriteLine("No");
            //}

        }
    }
}
