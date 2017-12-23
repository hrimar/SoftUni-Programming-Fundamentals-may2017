using System;
using System.Collections.Generic;
using System.Linq;

namespace _03EnduranceRally
{
    class Program
    {
        static void Main()
        {
            // Хитро решение 2 :
            // 1. да се умножат по  -1 непосочените индекси от първия масив!!!
            // т.е. с фор цикъл по zones всеки *-1 или Select(z=>z*-1) 
            // 2. После foreach (var i in indexes)
            //          zones[i]*= -1;
            // 3. 

            // Решение 1: даваше 70/100 - Няма * следователно не гърми а дава грешен изход, 
            // защото не трябва да се подадат еднакви индекси в indexes. Цлагаш Distinct и 100/100
            var drivers = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Where(a=>a.Length>0).Select(double.Parse).ToArray();
            var indexes = Console.ReadLine().Split().Where(a=>a.Length>0).Select(double.Parse).Distinct().ToArray(); ;
            // .Where(a=>a.Length>0) Трябва да сложим за да се подсигурим при празен вход!!!

            for (int i = 0; i < drivers.Length; i++)
            {
                var driver = drivers[i];
                double fuel = (int)driver.First();

                for (int z = 0; z < zones.Length; z++)
                {
                   bool ok = true;
                    for (int j = 0; j < indexes.Length; j++)
                    {                        
                        if (z==indexes[j] )
                        {
                             fuel += zones[z];
                            ok = false;
                        }                          
                    }
                    if(ok)
                    {
                        fuel -= zones[z];
                    }
                          

                    if(fuel<=0)
                    {
                        Console.WriteLine($"{driver} - reached {z}");
                        break;
                    }      
                }
                if(fuel>0)
                Console.WriteLine($"{driver} - fuel left {fuel:f2}");
            }

        }
    }
}
