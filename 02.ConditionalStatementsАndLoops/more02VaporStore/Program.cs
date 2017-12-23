using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more02VaporStore
{
    class Program
    {
        static void Main()
        {
            // Bati 50/100 ??? where is the problem???
            var balance = double.Parse(Console.ReadLine());
            var film = Console.ReadLine();
            var money = 0.0;
            var totalMoney = 0.0;
            while (film != "Game Time")
            {
                switch (film)
                {
                    case "OutFall 4":
                        money = 39.99;
                        if (balance - money < 0)
                            Console.WriteLine("Too Expensive");
                        else
                        {

                            balance -= money;
                            Console.WriteLine("Bought OutFall 4");
                            totalMoney += money;
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        money = 39.99;
                        if (balance - money < 0)
                            Console.WriteLine("Too Expensive");
                        else
                        {

                            balance -= money;
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                            totalMoney += money;
                        }
                        break;

                    case "CS: OG4":
                        money = 15.99;

                        if (balance - money < 0)
                            Console.WriteLine("Too Expensive");
                        else
                        {

                            balance -= money;
                            Console.WriteLine("Bought CS: OG4");
                            totalMoney += money;
                        }
                        break;
                    case "Zplinter Zell":
                        money = 19.99;

                        if (balance - money < 0)
                            Console.WriteLine("Too Expensive");
                        else
                        {

                            balance -= money;
                            Console.WriteLine("Bought Zplinter Zell");
                            totalMoney += money;
                        }
                        break;
                    case "Honored 2":
                        money = 59.99;

                        if (balance - money < 0)
                            Console.WriteLine("Too Expensive");
                        else
                        {

                            balance -= money;
                            Console.WriteLine("Bought Honored 2");
                            totalMoney += money;
                        }
                        break;
                    case "RoverWatch":
                        money = 29.99;

                        if (balance - money < 0)
                            Console.WriteLine("Too Expensive");
                        else
                        {

                            balance -= money;
                            Console.WriteLine("Bought RoverWatch");
                            totalMoney += money;
                        }
                        break;
                    default:
                        Console.WriteLine("Not Found"); break;
                }
                if (balance == 0) // !!!
                {
                    Console.WriteLine("Out of money!");
                    return; // !!!
                }


                film = Console.ReadLine();
            }
            //if (balance > 0)
                Console.WriteLine($"Total spent: ${totalMoney:f2}. Remaining: ${balance:f2}");


            // Решение с Dictionary - ВИЖ ГО!!!:
            //var currentBalance = decimal.Parse(Console.ReadLine());

            //var totalMoney = currentBalance;

            //var buyingOrder = Console.ReadLine();

            //var gamesDictionary = new Dictionary<string, decimal>()
            //{
            //    {"OutFall 4" , 39.99m},
            //    {"CS: OG" , 15.99m},
            //    {"Zplinter Zell" , 19.99m},
            //    {"Honored 2" , 59.99m},
            //    {"RoverWatch" , 29.99m},
            //    {"RoverWatch Origins Edition" , 39.99m},
            //};

            //var isGamePresent = false;

            //while (buyingOrder != "Game Time")
            //{

            //    foreach (var game in gamesDictionary)
            //    {
            //        if (game.Key == buyingOrder)
            //        {
            //            isGamePresent = true;

            //            if (currentBalance >= game.Value)
            //            {
            //                currentBalance -= game.Value;
            //                Console.WriteLine($"Bought {game.Key}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Too Expensive");
            //            }
            //            if (currentBalance == 0)
            //            {
            //                Console.WriteLine("Out of money!");
            //                return;
            //            }
            //        }
            //    }

            //    if (!isGamePresent)
            //    {
            //        Console.WriteLine("Not Found");
            //    }

            //    buyingOrder = Console.ReadLine();
            //    isGamePresent = false;
            //}

            //var remainingMoney = totalMoney - currentBalance;
            //Console.WriteLine($"Total spent: ${remainingMoney:F2}. Remaining: ${currentBalance:F2}");

        }

    }
}
