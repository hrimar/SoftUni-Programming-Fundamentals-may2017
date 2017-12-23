using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04WinningTicket
{
    class Program
    {
        private static string FindMaxSeq(string leftSide)
        {
            // правим събстринг от повтарящите се елементи:
            var bestStart = leftSide[0].ToString();
            var max = 1;
            for (int i = 0; i < leftSide.Length-1; i++)
            {
                var ch = leftSide[i];
                var count = 1;
                while(i+count<leftSide.Length && leftSide[i+count]==leftSide[i])
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                        bestStart = leftSide.Substring(i, count);
                    }
                }
            }
            return bestStart;
        }
        static void Main()
        {
            //Да се намери най-дългия събстринг от еднакви букви, повече от 6:

            //Решение 1: Разделщме всеки тикет на лява и дясна част с Substring!!!
            string[] tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*");

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    var leftSide = ticket.Substring(0, 10);
                    var rightSide = ticket.Substring(10);
                    string leftLongestSeq = FindMaxSeq(leftSide);
                    var rightLongestSeq = FindMaxSeq(rightSide);
                    if (leftLongestSeq.Length >= 6 && rightLongestSeq.Length >= 6
                        && leftLongestSeq[0] == rightLongestSeq[0]
                        && "@#$^".Contains(leftLongestSeq[0]))
                    {
                        var length = Math.Min(leftLongestSeq.Length, rightLongestSeq.Length);

                        if (length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {length}{leftLongestSeq[0]} Jackpot!");
                        }
                        else
                            Console.WriteLine($"ticket \"{ticket}\" - {length}{leftLongestSeq[0]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }


            // Moe Решение 2: 70/100 -  Дори и с Регекс пак е добр еда се раздели билета на 2 -ляв и десен        
            //string[] tickets = Regex.Split(Console.ReadLine(), @"\s*,\s*");
            //var pattern6 = @"(?<six>[#$^@]){6}";
            //var pattern7 = @"(?<seven>[#$^@]){7}";
            //var pattern10 = @"(?<ten>[#$^@]){10}";
            //var mached6 = new Regex(@"(?<six>[#$^@]){6}");


            //foreach (var ticket in tickets)
            //{
            //    var regex6 = Regex.Match(ticket, pattern6);
            //    var regex7 = Regex.Match(ticket, pattern7);
            //    var regex10 = Regex.Match(ticket, pattern10);
            //    if (ticket.Length != 20)
            //    {
            //        Console.WriteLine("invalid ticket");
            //      continue;
            //    }

            //    if (regex10.Success)
            //    {
            //        Console.WriteLine($"ticket \"{ticket}\" - {regex10.Length}{regex10.Groups["ten"].Value[0]} Jackpot!");
            //    }
            //    else if (regex7.Success)
            //    {
            //        Console.WriteLine($"ticket \"{ticket}\" - {regex7.Length}{regex7.Groups["seven"].Value[0]}");
            //    }
            //    else if (regex6.Success)
            //    {
            //        Console.WriteLine($"ticket \"{ticket}\" - {regex6.Length}{regex6.Groups["six"].Value[0]}");
            //    }        
            //    else
            //    {
            //        Console.WriteLine($"ticket \"{ticket}\" - no match");
            //    }
            //}

        }


    }
}
