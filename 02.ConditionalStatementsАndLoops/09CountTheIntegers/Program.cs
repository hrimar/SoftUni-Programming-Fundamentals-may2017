using System;

namespace _09CountTheIntegers
{
    class Program
    {
        static void Main()
        {
            var counter = -1;
            bool parsed = false;

            do
            {
                var input = Console.ReadLine();
                int num;
                parsed = int.TryParse(input, out num);
                counter++;
            } while (parsed);

            if(!parsed)
            Console.WriteLine(counter);

            //var counter = 0;
            //try
            //{
            //    while (true)
            //    {
            //        var n = int.Parse(Console.ReadLine());
            //        counter++;
            //    }
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine(counter);       
            //}

        }
    }
}
