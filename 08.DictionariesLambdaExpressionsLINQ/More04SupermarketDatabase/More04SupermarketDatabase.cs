using System;
using System.Collections.Generic;
using System.Linq;

namespace More04SupermarketDatabase
{
    class More04SupermarketDatabase
    {
        static void Main()
        {
            // 1. Решение с 2 речника (продукт-цена и продукт-количество:
            var products = Console.ReadLine();         
            var namePrice = new Dictionary<string, double>();
            var nameQuant = new Dictionary<string, double>();

            var totalAmount = 0.0;

            while (products != "stocked")
            {
                var product = products.Split().ToArray();
                var name = product[0];
                var price = double.Parse(product[1]);
                var quantity = double.Parse(product[2]);

                if (!namePrice.ContainsKey(name) || !nameQuant.ContainsKey(name))
                {
                    namePrice[name] = 0.0;
                    nameQuant[name] = 0.0;

                }
                namePrice[name] = price;
                nameQuant[name] += quantity;

                products = Console.ReadLine();
            }
            foreach (var namePriceQuantity in namePrice)    // Важно за принтирането!!!
            {
                foreach (var nameQ in nameQuant)
                {
                    if(namePriceQuantity.Key==nameQ.Key)
                    {
                        var name = namePriceQuantity.Key;
                        var price = namePriceQuantity.Value;
                        var quantity = nameQ.Value;
                        totalAmount += (quantity * price);

                        Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${quantity * price:f2}");

                    }
                }
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${totalAmount:f2}");


            // 2. Решение с вложени речници. Ред 40 е важен за да даде 100/100 !!!
            //var products = Console.ReadLine();
            //var result = new Dictionary<string, Dictionary<double, double>>();
            //var totalAmount = 0.0;

            //            while (products != "stocked")
            //{
            //    var product = products.Split().ToArray();
            //    var name = product[0];
            //    var price = double.Parse(product[1]);
            //    var quantity = double.Parse(product[2]);

            //    if (!result.ContainsKey(name))
            //    {
            //        result[name] = new Dictionary<double, double>();

            //    }
            //    if (!result[name].ContainsKey(price)) 
            //    {
            //        result[name][price] = 0;         
            //    }

            //    result[name][price]+= quantity;

            //    products = Console.ReadLine();
            //}
            //foreach (var namePriceQuantity in result)
            //{
            //    var name = namePriceQuantity.Key;
            //    var price = namePriceQuantity.Value.Keys.Last();
            //    var quantity = namePriceQuantity.Value.Values.Sum();
            //    totalAmount += (quantity * price);

            //    Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${quantity * price:f2}");

            //}
            //Console.WriteLine("------------------------------");
            //Console.WriteLine($"Grand Total: ${totalAmount:f2}");


            // 3. При това решение не се добавя кол-то на продукта !???
            //var products = Console.ReadLine();
            //var result = new Dictionary<string, string>();
            //var totalAmount = 0.0;


            //while (products!="stocked")
            //{

            //    var product = products.Split().ToArray();
            //    var name = product[0];
            //   var price = double.Parse(product[1]);
            //    var quantity = double.Parse(product[2]);

            //    if (!result.ContainsKey(name))
            //    {
            //        result[name] = string.Empty;
            //    }

            //    result[name] =$" ${price:f2} * {quantity} = ${quantity*price:f2}";
            //    totalAmount += quantity * price;
            //    products = Console.ReadLine();
            //}
            //foreach (var nameTotal in result)
            //{
            //    Console.WriteLine($"{nameTotal.Key}: {nameTotal.Value:f2}");
            //}
            //Console.WriteLine("------------------------------");
            //Console.WriteLine($"Grand Total: ${totalAmount:f2}");
        }
    }
}
