using System;

namespace _01ChooseaDrink
{
    class Program
    {
        static void Main()
        {         
            var profession = Console.ReadLine();

            switch (profession)
            {
                case "athlete":          
                Console.WriteLine("Water"); break;
                case "Businessman":
                case "Businesswoman":        
                Console.WriteLine("Coffee"); break;
                case "SoftUni Student":
                Console.WriteLine("Beer"); break;
                default:       
                Console.WriteLine("Tea"); break;
            }
            //var profession = Console.ReadLine();
            //if(profession=="athlete")
            //{
            //    Console.WriteLine("Water");
            //}
            //else if(profession== "Businessman" || profession=="Businesswoman")
            //{
            //    Console.WriteLine("Coffee");
            //}
            //else if(profession== "SoftUni Student")
            //    {
            //    Console.WriteLine("Beer");
            //}
            //else 
            //{
            //    Console.WriteLine("Tea");
            //}

        }
    }
}
