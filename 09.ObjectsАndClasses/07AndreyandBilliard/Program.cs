using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AndreyandBilliard
{

    // мдаааа много труден материал, трябва пак да прегледам зад-те до тук и да довърша тази!!!
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var shop = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                if(!shop.ContainsKey(input[0]))
                {
                    shop[input[0]] = 0;
                }
                else
                {
                shop[input[0]] = decimal.Parse(input[1]);
                }              
            }

            List<Customer> allCustomers = new List<Customer>();

            var orders = Console.ReadLine();
            while(orders!= "end of clients")
            {
                var ordersInfo = Console.ReadLine().Split('-', ',');
                var name = ordersInfo[0];
                var product = ordersInfo[1];
                var quantity = double.Parse(ordersInfo[2]);

                Customer client = new Customer();
                client.ShopList = new Dictionary<string, double>();
                client.Name = name;
                client.ShopList[product] = quantity;

                if(allCustomers.Any(a=>a.Name==name))
                {
                    Customer allCustomer = allCustomers.First(a => a.Name == name);
                    if(!allCustomer.ShopList.ContainsKey(product))
                    {
                        allCustomer.ShopList[product] = quantity;
                    }
                    else
                    {
                        allCustomer.ShopList[product] += quantity;
                    }
                }
                else
                {
                    allCustomers.Add(client);
                }
            }

            foreach (var customer in allCustomers)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine("Bill: {0:f2}", customer.Bill);

            }
            Console.WriteLine("Total bill: {0:f2}", allCustomers.Sum(c => c.Bill));
        }
    }
    //namespace _7.Andrey_and_billiard - Решение:
    //{
    //    class Customer
    //    {
    //        public string Name { get; set; }
    //        public Dictionary<string, double> ShopList { get; set; }
    //        public double Bill { get; set; }

    //    }
    //    class Program
    //    {
    //        static void Main()
    //        {

    //            Dictionary<string, double> menu = new Dictionary<string, double>();
    //            int numberOfItems = int.Parse(Console.ReadLine());
    //            for (int i = 0; i < numberOfItems; i++)
    //            {
    //                string[] input = Console.ReadLine().Split('-');
    //                if (!menu.ContainsKey(input[0]))
    //                {
    //                    menu.Add(input[0], double.Parse(input[1]));
    //                }
    //                else
    //                {
    //                    menu[input[0]] = double.Parse(input[1]);
    //                }

    //            }
    //            List<Customer> allCustomers = new List<Customer>();
    //            while (true)
    //            {
    //                string info = Console.ReadLine();
    //                if (info == "end of clients")
    //                {
    //                    break;
    //                }
    //                string[] clientInfo = info.Split('-', ',');
    //                string customerName = clientInfo[0];
    //                string product = clientInfo[1];
    //                double quantity = double.Parse(clientInfo[2]);

    //                if (!menu.ContainsKey(product)) { continue; }

    //                Customer client = new Customer();
    //                client.ShopList = new Dictionary<string, double>();
    //                client.Name = clientInfo[0];
    //                client.ShopList.Add(product, quantity);

    //                if (allCustomers.Any(c => c.Name == customerName))
    //                {
    //                    Customer existingCustomer = allCustomers.First(c => c.Name == customerName);
    //                    if (existingCustomer.ShopList.ContainsKey(product))
    //                    {
    //                        existingCustomer.ShopList[product] += quantity;
    //                    }
    //                    else
    //                    {
    //                        existingCustomer.ShopList[product] = quantity;
    //                    }
    //                }
    //                else
    //                {
    //                    allCustomers.Add(client);
    //                }
    //            }
    //            /// Това го правим само за да направим bill-a:
    //            foreach (var customer in allCustomers)
    //            {
    //                foreach (var item in customer.ShopList)
    //                {

    //                    foreach (var product in menu)
    //                    {
    //                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
    //                    }
    //                }
    //            }
    //            var ordered = allCustomers
    //                            .OrderBy(x => x.Name)
    //                            .ThenBy(x => x.Bill)
    //                            .ToList();
    //            foreach (var customer in ordered)
    //            {
    //                Console.WriteLine(customer.Name);
    //                foreach (KeyValuePair<string, double> item in customer.ShopList)
    //                {
    //                    Console.WriteLine($"-- {item.Key} - {item.Value}");
    //                }
    //                Console.WriteLine("Bill: {0:f2}", customer.Bill);

    //            }
    //            Console.WriteLine("Total bill: {0:F2}", allCustomers.Sum(c => c.Bill));
    //        }
    //    }
    //}
 }
