using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05MagicExchangeableWords
{
    class Program
    {
        static void Main()
        {
            //var strings = Console.ReadLine().Split()
            //    .Select(a=> a.ToCharArray().Distinct().ToArray()).ToArray();

            //var firstLength = strings.First().Length; // ???
            //Console.WriteLine(strings.All(a=>a.Length==firstLength).ToString().ToLower());

            // dovyrwi.... gosho hapka
            var str = Console.ReadLine().Split();
            var str1 = str[0].ToCharArray();
            var str2 = str[1].ToCharArray();
            var abc = new Dictionary<char, char>();
            bool exchange = false;

            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (!abc.ContainsKey(str2[i]))
                    {
                        abc[str2[i]] = str1[i];
                        exchange = true;
                    }
                    else
                    {
                        if (str1[i] != abc[str1[i]])
                        {
                            exchange = false;
                            break;
                        }
                    }

                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (!abc.ContainsKey(str1[i]))
                    {
                        abc[str1[i]] = str2[i];
                        exchange = true;
                    }
                    else
                    {
                        if (abc[str1[i]] != str2[i])//
                        {                            
                            exchange = false;
                            break;
                        }
                    }
                }
            }
            else if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (!abc.ContainsKey(str1[i]))
                    {
                        abc[str1[i]] = str2[i];
                        exchange = true;
                    }
                    else
                    {
                        if (abc[str1[i]] != str2[i])
                        {                          
                            exchange = false;
                            break;
                        }

                    }

                }
            }
            Console.WriteLine(exchange.ToString().ToLower());

        }
    }
}
