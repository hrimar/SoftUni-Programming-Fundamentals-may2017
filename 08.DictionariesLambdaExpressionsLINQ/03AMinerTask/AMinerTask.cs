using System;
using System.Collections.Generic;
using System.Linq;

namespace _03AMinerTask
{
    class AMinerTask
    {
        static void Main()
        {
            // да опитам пак с Лист в Дикт1!!

            // Задача - подават асе тип и ст-ст и ст-стта се добави всеки път към съотв тип:
            // 75/100 защото нова ст-ст припокрива старата, сег авече е 100/100!
            // Извод: Ако няма такъв ключ да се създаде с нулева ст-ст 
            // и всяка нова ст-ст за този ключ да се добавя към съществуващата!!!
            var type = Console.ReadLine();

            var result = new Dictionary<string, long>();

            while (type != "stop")
            {
                var quantity = long.Parse(Console.ReadLine());

                if ( !result.ContainsKey(type)) // ако няма такъв ключ, 
                {
                    result[type] = 0;           // да се създаде с Value 0-ла и после +=
                }

                result[type] += quantity;

                type = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }

            // а с вложен Лист за сумиранe на ст-сте 25/100 ???
            //var type = Console.ReadLine();

            //var result = new Dictionary<string, List<long>>();
            //var goldQuantity = new List<long>();
            //var silverQuantity = new List<long>();
            //var copperQuantity = new List<long>();

            //while (type!="stop")
            //{   
            //    if(type=="Gold")
            //    {
            //        goldQuantity.Add(long.Parse(Console.ReadLine()));
            //        result[type] = goldQuantity;
            //        //long sumGold = goldQuantity.Sum();
            //    }
            //    else if (type == "Silver")
            //    {
            //        silverQuantity.Add(long.Parse(Console.ReadLine()));
            //        result[type] = silverQuantity;
            //    }
            //    else if (type == "Copper")
            //    {
            //        copperQuantity.Add(long.Parse(Console.ReadLine()));
            //        result[type] = copperQuantity;
            //    }

            //    type = Console.ReadLine();            
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key +" -> "+ item.Value.Sum());
            //}

        }
    }
}
