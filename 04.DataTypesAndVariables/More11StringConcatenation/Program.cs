using System;

namespace More11StringConcatenation
{
    class Program
    {
        static void Main()
        {
            // Izvod: Използвай вградените в string класове - Remove!
            char delimiter = char.Parse(Console.ReadLine());
            string evenOdd = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string resultEven = string.Empty;
            string resultOdd = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                if (i%2==0)// even
                {
                    //if(i==n-1) // не така!!!
                    //{
                    //    resultEven += word;
                    //}
                    //else
                    //{
                        resultEven += word + delimiter;
                    //}
                }
                else if (i%2==1) // odd
                {
                    //if (i == n-1)
                    //{
                    //    resultOdd += word;
                    //}
                    //else
                    //{
                        resultOdd += word + delimiter;
                    //}
                 
                }
            }
            if (evenOdd == "even")
            {
                Console.WriteLine(resultEven.Remove(resultEven.Length-1));
            }
            else if (evenOdd == "odd")
            {
                Console.WriteLine(resultOdd.Remove(resultOdd.Length - 1));
            }
        }
    }
}
