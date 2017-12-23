using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04CubicMessages
{
    class Program
    {
        static void Main()
        {            
                var input = Console.ReadLine();

                while (input != "Over!")
                {
                    var result = new StringBuilder();
                    var n = int.Parse(Console.ReadLine());
              
                    var pattern = @"^(\d+)(?<text>[a-zA-Z]+)([^a-zA-Z]*)$";
                    var regex = Regex.Match(input, pattern);
                    var text = string.Empty;
                    if (regex.Success)
                    {
                        text = regex.Groups["text"].Value;
                        var nums1 = regex.Groups["1"].Value.ToCharArray().Where(a => Char.IsDigit(a)).ToArray();
                    var nums2 = regex.Groups["2"].Value.ToCharArray().Where(a => Char.IsDigit(a)).ToArray();

                    if (text.Length == n)
                    {                       
                        for (int i = 0; i < nums1.Length; i++)
                        {
                            int digit = int.Parse(nums1[i].ToString());
                            int teksta = text.Length - 1;
                            if (digit < 0 || digit > teksta)
                            {
                                result.Append(' ');
                            }
                            else
                            {
                                result.Append(text[digit]);
                            }
                        }
                        for (int i = 0; i < nums2.Length; i++)
                        {
                            int digit = int.Parse(nums2[i].ToString());
                            int teksta = text.Length - 1;
                            if (digit >= 0 && digit <= teksta)
                            {
                                result.Append(text[digit]);
                            }
                            else
                            {
                                result.Append(' ');
                            }
                        }
                        Console.WriteLine($"{text} == {result}");
                    }
                    }

                    input = Console.ReadLine();
                }
      
        }
    }
}
