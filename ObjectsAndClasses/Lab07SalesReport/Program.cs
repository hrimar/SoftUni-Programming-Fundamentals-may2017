using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab07SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
    class SalesByCity
    {
        public string Town { get; set; }
        public decimal TotalSale { get; set; }
}
   
    class Program
    {
        static void Main()
        {
            // РАЗУЧИ РЕШЕНИЕТО С КЛАСОВЕ ОТ Lab-a!!!!!   Решение с клас:

            // .....................................


            //Решение с речник, без да използвам създадения клас?!
            var allSales = new SortedDictionary<string, decimal>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[0];
                var product = input[1];
                var price = decimal.Parse(input[2]);
                var quantity = decimal.Parse(input[3]);

                var totalSale = price * quantity;
                var sales = new Sale
                {
                    Town = name,
                    Product = product,
                    Price = price,
                    Quantity = quantity
                };
                if (!allSales.ContainsKey(name))
                {
                    allSales[name] = totalSale;
                }
                else
                {
                    allSales[name] += totalSale;
                }
            }
            foreach (var nameSales in allSales)
            {
                Console.WriteLine($"{nameSales.Key} -> {nameSales.Value:f2}");
            }


            // Решение с Класове и методи:
            //    var sales = GetSales();

            //    var allSales = new SortedDictionary<string, decimal>();

            //       foreach (var s in sales)
            //        {
            //            if (!allSales.ContainsKey(s.Town))
            //            {
            //                allSales[s.Town] = s.Price*s.Quantity;
            //            }
            //            else
            //            {
            //                allSales[s.Town] += s.Price * s.Quantity;
            //            }
            //        }
            //    var salesList = new List<string>();

            //    foreach (var nameSales in allSales)
            //    {
            //        Console.WriteLine($"{nameSales.Key} -> {nameSales.Value:f2}");
            //        salesList.Add($"{nameSales.Key} -> {nameSales.Value:f2}");
            //    }

            //    var salesByCity = new SalesByCity();           

            //}

            //private static Sale[] GetSales()
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    Sale[] sales = new Sale[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        var input = Console.ReadLine().Split();
            //        var name = input[0];
            //        var product = input[1];
            //        var price = decimal.Parse(input[2]);
            //        var quantity = decimal.Parse(input[3]);

            //        var totalSale = price * quantity;
            //        sales[i] =new Sale()
            //        {
            //            Town = name,
            //            Product = product,
            //            Price = price,
            //            Quantity = quantity
            //        };
            //    }
            //    return sales;
        }
    }
}
