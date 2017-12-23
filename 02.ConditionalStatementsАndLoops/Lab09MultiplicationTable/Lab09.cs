using System;

namespace Lab09MultiplicationTable
{
    class Lab09
    {
        static void Main()
        {
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{n} X {i} = {n * i}");
            //}

            // Problem 10. Multiplication Table 2.0
            //var n = int.Parse(Console.ReadLine());
            //var multy = int.Parse(Console.ReadLine());

            //if (multy > 10)
            //{
            //    Console.WriteLine($"{n} X {multy} = {n * multy}");
            //}

            //for (int i=multy;i <= 10; i++, multy++)
            //{   
            //    Console.WriteLine($"{n} X {multy} = {n * multy}");
            //}

            var n = int.Parse(Console.ReadLine());
            var multy = int.Parse(Console.ReadLine());

            if (multy > 10)
            {
                Console.WriteLine($"{n} X {multy} = {n * multy}");
            }

            while(multy<=10)
            {
                Console.WriteLine($"{n} X {multy} = {n * multy}");
                multy++;
            }

        }
    }
}
