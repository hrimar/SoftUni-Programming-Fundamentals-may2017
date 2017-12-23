using System;

namespace more03Megapixels
{
    class Program
    {
        static void Main()
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var pixels = (width * height) / 1000000.0;
            Console.WriteLine($"{width}x{height} => {Math.Round(pixels, 1)}MP"); // с :f1 дава 80/100
        }
    }
}
