using System;

namespace _10CubeProperties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if(type=="face")
            {
                var face=PrintingFace(side);
                Console.WriteLine($"{face:f2}");
            }
            else if (type == "area")
            {
                var area=PrintingArea(side);
                Console.WriteLine($"{area:f2}");
            }
            else if (type == "volume")
            {
               var volume= PrintingVolume(side);
                Console.WriteLine($"{volume:f2}");
            }
            else if (type == "space")
            {
                var space=PrintingSpace(side);
                Console.WriteLine($"{space:f2}");
            }
        }

        private static double PrintingFace(double side)
        {
            double face = Math.Sqrt(side*side*2);// лице
            return face;
        }
        private static double PrintingArea(double side)
        {
            double area = Math.Pow(side, 2)*6.0;// периметер?
            return area;
        }
        private static double PrintingVolume(double side)
        {
            double volume = Math.Pow(side, 3);// обем - OK
            return volume;
        }
        private static double PrintingSpace(double side)
        {
            double space = Math.Sqrt(3 * (side * side));// space ?
            return space;
        }
    }
}
