using System;

namespace _04NumbersinReversedOrder
{
    class NumbersinReversedOrder
    {
        // интересна задача за обръщане на числа от 1.12 -> 21.1 !!!

        //1. Решение с масив:
        //static void Main()
        //{       
        //    decimal n = decimal.Parse(Console.ReadLine());
        //    string reversedN= RecersingDidits(n);
        //    Console.WriteLine(reversedN);
        //}

        //private static string RecersingDidits(decimal n)
        //{
        //    string number = n.ToString();
        //    char[] digitsArray = number.ToCharArray();
        //    Array.Reverse(digitsArray); 

        //    return new string(digitsArray);          
        //}

        //   // 2. Решение със стринг и цикъл по чаровете му:
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            GetLastDigit(number);
        }
        private static void GetLastDigit(string number)
        {
            string result = string.Empty;
            for (int i = number.Length-1; i >= 0; i--)
            {
                char digit = number[i]; // Започваме от последната цифра
                result += digit;               
            }
            Console.WriteLine(result);
        }
    }
}
