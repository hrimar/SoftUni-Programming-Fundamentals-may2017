using System;

namespace _12MasterNumber
{
    class Program
    {
        // помисли и довърши!!!!!!!!!!!
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            CheckMaster(n);

        }

        private static void CheckMaster(int n)
        {
            //if(EventDigirs(n))
            //{
            //    Console.WriteLine(EventDigirs(n));
            //}
            ////SumDevidedBy7(n);
            ////Symetric(n)

        }

        private static bool EventDigirs(int n)
        {
            bool isEvenDigits = false;
            while (n>0)
            {
                int currentDigit = n % 10;
                if (currentDigit % 2 == 0)
                {
                    isEvenDigits=true;
                    Console.WriteLine(currentDigit);
                }
                    n = n / 10;
            }
            return isEvenDigits;
        }

        private static bool SumDevidedBy7(int n)
        {
            throw new NotImplementedException();
        }

        private static bool Symetric(int n)
        {
            throw new NotImplementedException();
        }
    }
}
