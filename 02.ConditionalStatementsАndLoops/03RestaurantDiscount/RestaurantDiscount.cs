using System;

namespace _03RestaurantDiscount
{
class RestaurantDiscount
{
    // Решение с МЕТОД (важно е къде връща резултата): 
    // Трябваше 1-во д аго напиша без и после със, а ТРЯБВА в процеса на работа да създавам методите!!!
    private static double CheckingPackage(string package, int price, double discount, double totalPrice)
    {
        if (package == "Gold")
        {
            totalPrice = price + 750;
            discount = 10.0;
            discount = totalPrice - (totalPrice * 10) / 100.0;
        }
        else if (package == "Normal")
        {
            totalPrice = price + 500;
            discount = 5.0;
            discount = totalPrice - (totalPrice * 5.0) / 100.0;
        }
        else if (package == "Platinum")
        {
            totalPrice = price + 1000;
            discount = 15.0;
            discount = totalPrice - (totalPrice * 15.0) / 100.0;
        }
        return discount;
    }
    static void Main()
    {
        var groupSize = int.Parse(Console.ReadLine());
        var package = Console.ReadLine();
        var price = -1;
        var discount = -1.0;
        var totalPrice = -1.0;
        var hall = string.Empty;

        if (groupSize > 0 && groupSize <= 50)
        {
            hall = "Small Hall";
            price = 2500;
        }
        else if (groupSize > 50 && groupSize <= 100)
        {
            hall = "Terrace";
            price = 5000;
        }
        else if (groupSize > 100 && groupSize <= 120)
        {
            hall = "Great Hall";
            price = 7500;                
        }
        else if (groupSize > 120)
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return; // !!! ХИТРО !!!
        }
        var pricePerPerson = CheckingPackage(package, price, discount, totalPrice) / groupSize; // !!!

        Console.WriteLine($"We can offer you the {hall}");
        Console.WriteLine($"The price per person is {pricePerPerson:f2}$");


            
            // Решение без Метод:
        //var groupSize = int.Parse(Console.ReadLine());
        //var package = Console.ReadLine();
        //var price = -1;
        //var discount = -1.0;
        //var totalPrice = -1.0;
        //var hall = string.Empty;

        //if(groupSize>0 && groupSize<=50)
        //{
        //    hall = "Small Hall";
        //    price = 2500;
        //    if (package == "Gold")
        //    {
        //        totalPrice = price + 750;
        //        discount = 10.0;
        //        discount = totalPrice - (totalPrice * 10)/100.0;                    
        //    }
        //    else if (package == "Normal")
        //    {
        //        totalPrice = price + 500;
        //        discount = 5.0;
        //        discount = totalPrice - (totalPrice * 5.0) / 100.0;
        //    }
        //    else if (package == "Platinum")
        //    {
        //        totalPrice = price + 1000;
        //        discount = 15.0;
        //        discount = totalPrice - (totalPrice * 15.0) / 100.0;
        //    }
        //}
        //else if (groupSize > 50 && groupSize <= 100)
        //{
        //    hall = "Terrace";
        //    price = 5000;
        //    if (package == "Gold")
        //    {
        //        totalPrice = price + 750;
        //        discount = 10.0;
        //        discount = totalPrice - (totalPrice * 10) / 100.0;
        //    }
        //    else if (package == "Normal")
        //    {
        //        totalPrice = price + 500;
        //        discount = 5.0;
        //        discount = totalPrice - (totalPrice * 5.0) / 100.0;
        //    }
        //    else if (package == "Platinum")
        //    {
        //        totalPrice = price + 1000;
        //        discount = 15.0;
        //        discount = totalPrice - (totalPrice * 15.0) / 100.0;
        //    }
        //}
        //else if (groupSize > 100 && groupSize <= 120)
        //{
        //    hall = "Great Hall";
        //    price = 7500;
        //    if (package == "Gold")
        //    {
        //        totalPrice = price + 750;
        //        discount = 10.0;
        //        discount = totalPrice - (totalPrice * 10) / 100.0;
        //    }
        //    else if (package == "Normal")
        //    {
        //        totalPrice = price + 500;
        //        discount = 5.0;
        //        discount = totalPrice - (totalPrice * 5.0) / 100.0;
        //    }
        //    else if (package == "Platinum")
        //    {
        //        totalPrice = price + 1000;
        //        discount = 15.0;
        //        discount = totalPrice - (totalPrice * 15.0) / 100.0;
        //    }
        //}
        //else if(groupSize > 120)
        //{
        //    Console.WriteLine("We do not have an appropriate hall.");
        //    return;
        //}
        //var pricePerPerson = discount / groupSize;
        //Console.WriteLine($"We can offer you the {hall}");
        //Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
    }

       
}
}
