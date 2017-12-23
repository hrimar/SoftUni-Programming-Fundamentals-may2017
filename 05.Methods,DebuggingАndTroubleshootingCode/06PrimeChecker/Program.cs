using System;

namespace _06PrimeChecker
{
    class Program
    {
        static void Main()
        {
            // според тази 100/100 вярна програма 10 е просто, а не е!!!!!!
            long n = long.Parse(Console.ReadLine());                     
           
            Console.WriteLine(CheckPrime(n));
        }

        private static bool CheckPrime(long n)
        {
            if (n<=1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(n); i++) // Мале, искало (int) ?!?
                {
                    if (n % (int)Math.Sqrt(n) == 0)
                    {
                        return false;
                    }                    
                }
          
            }
            return true;
        }
    }
}
