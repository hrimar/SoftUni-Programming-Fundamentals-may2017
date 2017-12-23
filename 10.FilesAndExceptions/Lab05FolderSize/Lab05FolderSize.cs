using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab05FolderSize
{
    class Lab05FolderSize
    {
        static void Main()
        {        
            // Дасе сумират всички файлове от папка TestFolder и сумата да се запише в файл:   
            var sizeDir = Directory.GetFiles("TestFolder");
            var sum = 0.0;
            foreach (var item in sizeDir)
            {
                FileInfo info = new FileInfo(item);
                sum += info.Length;
            }
            Console.WriteLine(sum/1024/1024);
            File.WriteAllText("Megabites.txt", (sum/1024/1024).ToString());
        }
    }
}
