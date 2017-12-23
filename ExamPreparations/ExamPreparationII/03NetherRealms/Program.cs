using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03NetherRealms
{
    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        internal static Demon Parse(string demonStr)
        {
            var name = demonStr;
            var healtRegex = new Regex(@"[^\d\+\-\*\/\.]");
            var damageReex= new Regex(@"-?\d+(?:\.\d+)?"); 
            

            var health = healtRegex.Matches(demonStr).Cast<Match>()
                .Select(a => (int)char.Parse(a.Value)).Sum(); // !!!!!!!!!!!
            var damage=damageReex.Matches(demonStr).Cast<Match>()
                .Select(a => decimal.Parse(a.Value)).Sum();                   // !!!!!!!!!!

            var multypplayCount = demonStr.Count(a => a == '*');
            var divideCount = demonStr.Count(a => a == '/');

       
                damage *=(decimal)Math.Pow(2, multypplayCount);
                damage /= (decimal)Math.Pow(2, divideCount);

            var demon = new Demon()
            {
                Name=name,
                Damage=damage,
                Health=health
            };
            return demon;
        }
    }
    class Program
    {
        static void Main()
        {
            
            //    // Извод: щом търсия да извадиш текст от стринг по шаблон - RegEx
            //    // и за да ползваш всички матчове трябва да ги катснеш с Cast<Matc>() !!!
            
  // Гадна и нечестна задача от 30/100 до 100/100  разликата е, че може да има -2,566656666222222222225555555555
            
            // Хитро Решение 3:
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse).OrderBy(a=>a.Name).ToArray();  // парсваме с метод деклариран в класа Демон!!!


            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health:f0} health, {demon.Damage:f2} damage");
            }

            

            //    //20/100 явно в засуканото условие пропускам нещо
            //    var input = Regex.Split(Console.ReadLine(), @"\s*,\s*");

            //    var result = new SortedDictionary<string, string>();

            //    foreach (var item in input)
            //    {
            //        var health = CalcHealt(item);
            //        var damage = CalcDemage(item); 
            //        //Console.WriteLine(health);
            //        //Console.WriteLine(damage);

            //        result[item] = $"{health} health, {damage:f2} damage";
            //    }

            //    foreach (var res in result)
            //    {
            //        Console.WriteLine($"{res.Key} - {res.Value}");
            //    }

            // Решение 2 с класове 20/100:
            //var input = Regex.Split(Console.ReadLine(), @"\s*,\s*");

            //var result = new SortedDictionary<string, Demon>();

            //foreach (var item in input)
            //{
            //    decimal health = CalcHealt(item);
            //    decimal damage = CalcDemage(item);

            //    var demon = new Demon()
            //    {
            //        Name = item,
            //        Health=health,
            //        Damage=damage
            //    };

            //    if(!result.ContainsKey(item))
            //    {
            //        result[item] = demon;
            //    }

            //}

            //foreach (var res in result)
            //{
            //    Console.WriteLine($"{res.Key} - {res.Value.Health:f0} health, {res.Value.Damage:f2} damage");
            //}


        }

        //private static decimal CalcDemage(string item)
        //{
        //    var sum = 0.0m;
        //    var onlyNums = Regex.Matches(item, @"-?\d\.?\d?"); /// ili @"-?\d(?:\.\d)?" - ne e tova
        //    var castMatchedNums = onlyNums.Cast<Match>().Select(a => a.Value.Trim()).ToArray();                       
        //    var numsArray = onlyNums.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        //    foreach (var n in castMatchedNums)
        //    {

        //        sum += decimal.Parse(n);
        //    }           
        //    var onlySimbols = "";

        //    // за * & /:
        //    for (int i = 0; i < item.Length; i++)
        //    {                
        //            if (item[i] == '*' || item[i] == '/')
        //            {
        //                onlySimbols += item[i];
        //            }
        //    }

        //    var totalSum = 0.0m;
        //    for (int i = 0; i < onlySimbols.Length; i++)
        //    {
        //        if(onlySimbols[i]=='*')
        //        {
        //            totalSum+=sum*2;
        //        }
        //        else if (onlySimbols[i] == '/')
        //        {
        //            if(sum==0)
        //            {
        //                totalSum = sum;
        //            }
        //            else
        //            {
        //              totalSum+=sum/2;
        //            }

        //        }
        //    }      
        //        return totalSum;
        //}

        //private static decimal CalcHealt(string item)
        //{
        //    var sum = 0.0m;
        //    for (int i = 0; i < item.Length; i++)
        //    {
        //       if(char.IsLetter(item[i]))
        //       //    if ((!char.IsDigit(item[i]) && (item[i]!='+') && (item[i] != '+')) && (item[i] != '*')
        //         //       && (item[i] != '/') && (item[i] != '.'))
        //        {
        //            var letter = item[i];
        //            sum += (int)item[i];
        //        }               
        //    }
        //    return sum; // ok
        //}
    }
}
