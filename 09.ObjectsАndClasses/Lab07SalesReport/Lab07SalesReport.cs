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
        public decimal Sales { get; set; }
    }

    class Lab07SalesReport
    {
        static void Main()
        {
            // Разделяма програмата на парчета и 
            // всяка стъпка какво трябва да вземе като вход и какво да върне!
             var sales = ReadSales();        // 1.
            var salesByCity = CalcSalesByCity(sales); // 2.
            foreach (var item in salesByCity.OrderBy(n=>n.Town))       // 3.
            {
                Console.WriteLine($"{item.Town} -> {item.Sales:f2}");
            }

        }

        private static List<SalesByCity> CalcSalesByCity(Sale[] sales)
        {
            var salesByCity = new Dictionary<string, decimal>();// всеки ред от Дикт се трансформира до клас SalesByCity()

            foreach (var s in sales)
            { 
                if (!salesByCity.ContainsKey(s.Town))
                {
                    salesByCity[s.Town] = 0;
                }
                salesByCity[s.Town] += s.Price * s.Quantity;                    
            }
            var salesList = salesByCity.Select(s => new SalesByCity()
            { Town=s.Key, Sales=s.Value}).ToList();

            return salesList;
        }

        private static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];             // !!!
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();
                sales[i] = new Sale()
                {
                    Town = inputLine.First(),   //inputLine[0],
                    Product = inputLine[1],
                    Price = decimal.Parse(inputLine[2]),
                    Quantity = decimal.Parse(inputLine[3])
                };
            }
            return sales;
        }
    }
}
