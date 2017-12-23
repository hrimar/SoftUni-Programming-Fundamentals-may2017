using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06RectanglePosition
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        int CalcArea()
        {
            return Width * Height;
        }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }


    class Lab06RectanglePosition
    {
        static void Main()
        {
            Rectangle r1 = ReadRectangle(), r2 = ReadRectangle();
            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
        }

        private static Rectangle ReadRectangle()
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse);
            Rectangle rectangle = new Rectangle()
            {
                Left = sizes.First(),
                Top = sizes.Skip(1).First(),
                Width = sizes.Skip(2).First(),
                Height = sizes.Skip(3).First()
            };
            return rectangle;
        }
    }
}
