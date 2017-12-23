using System;

namespace Lab05ForeignLanguages
{
    class Lab05
    {
        static void Main()
        {
            //var country = Console.ReadLine().ToLower();
            //if(country=="usa" || country=="england")
            //{
            //    Console.WriteLine("English");
            //}
            //else if(country == "spain" || country == "argentina" || country == "mexico")
            //{
            //    Console.WriteLine("Spanish");
            //}
            //else
            //    Console.WriteLine("unknown");

            var country = Console.ReadLine().ToLower();
            switch (country)
            {
                case "england":
                case "usa":            
                Console.WriteLine("English");       break;
                case ("spain"):
                case "mexico":
                case "argentina":
                Console.WriteLine("Spanish"); break;
                default:
                Console.WriteLine("unknown"); break;
        }


        }
    }
}
