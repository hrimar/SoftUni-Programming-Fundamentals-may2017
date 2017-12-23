using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Numerics;

namespace _02CommandInterpreter
{
    class Program
    {
        static void Main()
        {
            // виж 70-100 ред за бързите методи на въртене на ляво и дясно!!!!!

            // бях 55/100 значи масива не трябваше да го парсвам за да приема и върти и стрингове
            // гърмях защото бях дал startIndex + count >= nums.Length, а не startIndex + count > nums.Length
             // Сега съм 95/100 и ми гърми 1 тест за време!!! ??? 

            // Извод: при масиви всичко е в дребния детал за излизането от масиав и >, >=, < i <= !!!
            string str = Console.ReadLine().Trim();
                var nums = str.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var input = Console.ReadLine();

                while (input != "end")
                {
                    var comandnds = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var command = comandnds[0];

                // Оттук е добре да се изведат в метод всички if-ове
                // и излизаме от метода при грешен парам с RETURN!!!
                if (command == "reverse")
                {
                    var startIndex = int.Parse(comandnds[2]);
                    var count = int.Parse(comandnds[4]);

                    if (startIndex < 0 || startIndex >= nums.Length || startIndex + count > nums.Length || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        //continue;
                    }
                    else
                    {
                        //Array.Reverse(nums, startIndex, count); // - но това го няма точно така  в Lists!!!

                        // или
                        var end = startIndex + count - 1;
                        while(startIndex < end)
                        {
                            var oldItem = nums[startIndex];
                            nums[startIndex] = nums[end];
                            nums[end] = oldItem;
                            startIndex++;
                            end--;
                        }
                    }

                }
                else if (command == "sort")
                {
                    var startIndex = int.Parse(comandnds[2]);
                    var count = int.Parse(comandnds[4]);

                    if (startIndex < 0 || startIndex >= nums.Length || startIndex + count > nums.Length || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        // continue;                  
                    }
                    else
                    {
                        Array.Sort(nums, startIndex, count);
                    }
                }
                else if (command == "rollLeft" || command == "rollRight")
                {
                    // rollLeft е всъщност rollRight с count=-count !!!
                    var count = long.Parse(comandnds[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {

                        // универсален начин за бързо ротиране:!
                      
                        if(command == "rollLeft")
                        {
                            count =count*(-1);
                        }
                        //1.LINQ:
                        //for (int i = 0; i < count; i++)
                        //{
                        //    var first = nums[0];
                        //    var newNums = nums.Skip(1).Take(nums.Length - 1).ToList();
                        //    newNums.Add(first);
                        //    nums = newNums.ToArray();
                        //}
                        // 2. 
                        var result = new string[nums.Length];
                        for (int oldIndex = 0; oldIndex < nums.Length; oldIndex++)
                        {
                            var newIndex = oldIndex + count;
                            newIndex = newIndex % nums.Length;
                            if (newIndex < 0)
                                newIndex += nums.Length;
                            result[newIndex] = nums[oldIndex];
                        }
                        for (int i = 0; i < nums.Length; i++)
                        {
                            nums[i] = result[i];
                        }
                    }
                }
                    //else if (command == "rollLeft")
                    //{
                    //// rollLeft е всъщност rollRight с count=-count !!!
                    //    var count = BigInteger.Parse(comandnds[1]);
                    //    if (count < 0)
                    //    {
                    //        Console.WriteLine("Invalid input parameters.");
                    //    }
                    //    else
                    //    {
                    //        for (int i = 0; i < count % nums.Length; i++)
                    //        {
                    //           var temp = nums[0];
                    //            for (int j = 1; j < nums.Length; j++)
                    //            {
                    //                nums[j - 1] = nums[j];
                    //            }
                    //            nums[nums.Length - 1] = temp;
                    //        }
                    //    }

                    //}
                    //else if (command == "rollRight")
                    //{
                    //    var count = BigInteger.Parse(comandnds[1]);
                    //    if (count < 0)
                    //    {
                    //        Console.WriteLine("Invalid input parameters.");
                    //    }
                    //    else
                    //    {
                    //        for (int i = 0; i < count; i++)
                    //        {
                    //           var temp = nums[nums.Length - 1];
                    //            for (int j = nums.Length - 1; j >= 1; j--)
                    //            {
                    //                nums[j] = nums[j - 1];
                    //            }
                    //            nums[0] = temp;
                    //        }
                    //    }
                    //}
                    input = Console.ReadLine();
                } //while       

                Console.WriteLine("[" + string.Join(", ", nums) + "]");
           
        }
    }
}
