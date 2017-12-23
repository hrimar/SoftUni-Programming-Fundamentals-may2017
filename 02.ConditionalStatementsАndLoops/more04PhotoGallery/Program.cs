using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more04PhotoGallery
{
    class Program
    {
        static void Main()
        {
            var photoNumber = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month=int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var photoBytes = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var kb = 0.0;
            var type = string.Empty;

            var orientation= string.Empty;

            if (photoBytes >= 1500000)
            {
                kb = photoBytes / 1000000.0;
                type = "MB";
            }
            else if (photoBytes>= 1000) // 500000
            {
                kb = photoBytes / 1000.0;
                type = "KB";
            }
            else
            {
                kb = photoBytes;
                type = "B";
            }

            if(width>height)
            {
                orientation = "landscape";
            }
            else if(width == height)
            {
                orientation = "square";
            }
            else
            {
                orientation = "portrait";
            }
            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {kb}{type}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");

        }
    }
}
