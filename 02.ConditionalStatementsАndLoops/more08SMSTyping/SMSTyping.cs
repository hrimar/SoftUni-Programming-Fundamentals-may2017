using System;
using System.Linq;
using System.Collections.Generic;

namespace more08SMSTyping
{
    class SMSTyping
    {
        static void Main()
        {
            //ehaaa... 100/100
            var n = int.Parse(Console.ReadLine());
            var ofset = 0;
            var mainDigit = 0;
            char finalIndex = ' ';
            var letters= new List<char>();
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                //CalculateDigits(num); // Number of Digits
                mainDigit = num % 10;
                ofset = (mainDigit - 2) * 3;
                //Console.WriteLine(CalculateDigits(num));
                if(mainDigit==8 || mainDigit==9)
                {
                    ofset = (mainDigit - 2) * 3 +1;
                }
                var letterIndex = ofset + CalculateDigits(num) - 1;
                finalIndex = (char)(letterIndex + 97);

                if (finalIndex == (char)'Z')
                {
                    finalIndex = (char)' ';
                }
                letters.Add(finalIndex);

            }
            foreach (var letter in letters)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
           
        }

        private static int CalculateDigits(int num)
        {
            var digits = 0;
            while (num > 0)
            {
                var last = num % 10;
                num = num / 10;
                digits++;
            }
            return digits;
        }
    }
}
