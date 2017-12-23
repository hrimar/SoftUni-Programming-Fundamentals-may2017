using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class ArrayManipulator
{

    static void Main()
    {
         // vse si e 60/100 трябва си внимателно да се прегледа

        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }
            var inputData = input.Split();
            var command = inputData[0];
            if (command == "exchange")
            {
                nums=ExchangeArray(nums, inputData);
            }
            else if (command == "max")
            {
                var evenOrOdd = GetIndexOfMaxEvenOrOdd(nums, inputData);
                if (evenOrOdd == -555)
                    Console.WriteLine("No matches");
                else
                    Console.WriteLine(evenOrOdd);
            }
            else if (command == "min")
            {
                var evenOrOdd = GetIndexOfMinEvenOrOdd(nums, inputData);
                if (evenOrOdd == -555)
                    Console.WriteLine("No matches");
                else
                    Console.WriteLine(evenOrOdd);
            }
            else if (command == "first" || command == "last")
            {
                var firstOrLast = GetFirstOrLast(nums, inputData); // sled invalid count da ne se printira

            }

        }

        Console.WriteLine('[' + string.Join(", ", nums) + ']');
    }

    private static int[] ExchangeArray(int[] nums, string[] inputData)
    {
        var command = inputData[0];
        var index = int.Parse(inputData[1]);
        if (index < 0 || index > nums.Length - 1)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            //var count = nums.Length - index;
            //List<int> arr1 = nums.ToList().GetRange(index + 1, count - 1);
            //var arr2 = nums.ToList().GetRange(0, index + 1);
            //var result = new List<int>();
            //result.AddRange(arr1);
            //result.AddRange(arr2);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = result[i];
            //}

            // или
            var arrLeft = nums.Take(index + 1).ToArray();
            var arrRight = nums.Skip(index + 1).ToArray();
            var concatenatedArr = arrRight.Concat(arrLeft).ToArray(); // !!!!! Concate!
            nums = concatenatedArr;
        }
        return nums;
    }

    static int GetIndexOfMaxEvenOrOdd(int[] nums, string[] inputData)
    {
        var indefOfEvenOrOdd = -555;
        var command = inputData[0];
        var typeEvenOrOdd = (inputData[1]);
        if (typeEvenOrOdd == "even")
        {
            try
            {
                var even = nums.Where(a => a % 2 == 0).Max();
                indefOfEvenOrOdd = Array.LastIndexOf(nums, even);
            }
            catch { }

        }
        else if (typeEvenOrOdd == "odd")
        {
            try
            {
                var even = nums.Where(a => a % 2 == 1).Max();
                indefOfEvenOrOdd = Array.IndexOf(nums, even);
            }
            catch { }
        }

        return indefOfEvenOrOdd;
    }

    static int GetIndexOfMinEvenOrOdd(int[] nums, string[] inputData)
    {
        var indefOfEvenOrOdd = -555;
        var command = inputData[0];
        var typeEvenOrOdd = (inputData[1]);
        if (typeEvenOrOdd == "even")
        {
            try
            {
                var even = nums.Where(a => a % 2 == 0).Min();
                indefOfEvenOrOdd = Array.LastIndexOf(nums, even);
            }
            catch { }

        }
        else if (typeEvenOrOdd == "odd")
        {
            try
            {
                var even = nums.Where(a => a % 2 == 1).Min();
                indefOfEvenOrOdd = Array.IndexOf(nums, even);
            }
            catch { }
        }

        return indefOfEvenOrOdd;
    }
    static int[] GetFirstOrLast(int[] nums, string[] inputData)
    {

        var command = inputData[0];
        var count = int.Parse(inputData[1]);
        if (count < 0 || count > nums.Length)
        {
            Console.WriteLine("Invalid count");
        }
        else
        {
            var type = inputData[2];
            if (command == "first" || command == "last")
            {
                if (command == "first" && type == "even")
                {
                    nums = nums.Where(a => a % 2 == 0).ToArray();
                    // !!!!
                    nums = nums.Take(count).ToArray();
                }
                if (command == "first" && type == "odd")
                {
                    nums = nums.Where(a => a % 2 == 1).ToArray();
                    nums = nums.Take(count).ToArray();
                }
                else if (command == "last" && type == "even")
                {
                    nums = nums.Where(a => a % 2 == 0).ToArray();
                    var skiped = nums.Length - count;
                    nums = nums.Skip(skiped).ToArray();
                }
                else if (command == "last" && type == "odd")
                {
                    nums = nums.Where(a => a % 2 == 1).ToArray();
                    var skiped = nums.Length - count;
                    nums = nums.Skip(skiped).ToArray();
                }
            }
            Console.WriteLine('[' + string.Join(", ", nums) + "]"); // firstOrLast
        }

        return nums;
    }

        //static void Main()
        //{
        //    //  Bre 60/100
        //    var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        //    while (true)
        //    {
        //        var input = Console.ReadLine();
        //        if(input=="end")
        //        { 
        //            break;
        //        }
        //        var inputData = input.Split();
        //        var command = inputData[0];
        //        if (command == "exchange")
        //        {
        //            nums=ExchangeArray(nums, inputData);
        //        }
        //        else if (command == "max")
        //        {
        //            //този if също може да е с void метод и там да принтира 2-те съобщения!
        //            var evenOrOdd = GetIndexOfMaxEvenOrOdd(nums, inputData);
        //            if (evenOrOdd == -555)
        //                Console.WriteLine("No matches");
        //            else
        //                Console.WriteLine(evenOrOdd);
        //        }
        //        else if (command == "min")
        //        {
        //            var evenOrOdd = GetIndexOfMinEvenOrOdd(nums, inputData);
        //            if (evenOrOdd == -555)
        //                Console.WriteLine("No matches");
        //            else
        //                Console.WriteLine(evenOrOdd);
        //        }
        //        else if (command == "first" || command == "last")
        //        {
        //            var firstOrLast=GetFirstOrLast(nums, inputData); // sled invalid count da ne se printir
        //        }
        //    }

        //         Console.WriteLine('['+string.Join(", ", nums)+']');
        //}

        //private static int[] ExchangeArray(int[] nums, string[] inputData)
        //{
        //    var command = inputData[0];
        //    var index = int.Parse(inputData[1]);
        //    if (index < 0 || index > nums.Length - 1)
        //    {
        //        Console.WriteLine("Invalid index");
        //    }
        //    else
        //    {
        //        //var count = nums.Length - index;
        //        //List<int> arr1 = nums.ToList().GetRange(index + 1, count - 1);
        //        //var arr2 = nums.ToList().GetRange(0, index + 1);
        //         //var result = new List<int>();
        //        //result.AddRange(arr1);
        //        //result.AddRange(arr2);            
        //        //for (int i = 0; i < nums.Length; i++)
        //        //{
        //        //    nums[i] = result[i];
        //        //}


        //        // или
        //        var arrLeft = nums.Take(index + 1).ToArray();
        //        var arrRight = nums.Skip(index + 1).ToArray();
        //        var concatenatedArr = arrRight.Concat(arrLeft).ToArray(); // !!!!! Concate!
        //        nums = concatenatedArr;            
        //    }
        //   return nums;
        //}

        //static int GetIndexOfMaxEvenOrOdd(int[] nums, string[] inputData)
        //{
        //    var indefOfEvenOrOdd = -555;
        //    var command = inputData[0];
        //    var typeEvenOrOdd = (inputData[1]);
        //    if(typeEvenOrOdd=="even")
        //    {
        //        //var even = nums.Where(a => a % 2 == 0).ToArray();
        //        //if(!even.Any()) // т.е. ако няма никой там
        //        //{
        //        //    Console.WriteLine("No matches");
        //        //}

        //        try
        //        {
        //            var even = nums.Where(a => a % 2 == 0).Max();
        //            indefOfEvenOrOdd = Array.LastIndexOf(nums, even);
        //        }
        //        catch { }

        //    }
        //    else if (typeEvenOrOdd == "odd")
        //    {
        //        try
        //        {
        //            var even = nums.Where(a => a % 2 == 1).Max();
        //             indefOfEvenOrOdd = Array.IndexOf(nums, even);
        //        }
        //        catch { }
        //    }

        //    return indefOfEvenOrOdd;
        //}

        //static int GetIndexOfMinEvenOrOdd(int[] nums, string[] inputData)
        //{
        //    var indefOfEvenOrOdd = -555;
        //    var command = inputData[0];
        //    var typeEvenOrOdd = (inputData[1]);
        //    if (typeEvenOrOdd == "even")
        //    {
        //        try
        //        {
        //            var even = nums.Where(a => a % 2 == 0).Min();
        //         indefOfEvenOrOdd = Array.LastIndexOf(nums, even);
        //        }
        //        catch { }

        //    }
        //    else if (typeEvenOrOdd == "odd")
        //    {
        //        try
        //        {
        //            var even = nums.Where(a => a % 2 == 1).Min();
        //        indefOfEvenOrOdd = Array.IndexOf(nums, even);
        //        }
        //        catch { }
        //    }

        //    return indefOfEvenOrOdd;
        //}
        //static int[] GetFirstOrLast(int[] nums, string[] inputData)
        //{

        //    var command = inputData[0];
        //    var count = int.Parse(inputData[1]);
        //    if (count < 0 || count > nums.Length-1) // tov ami e gre[kata!!!!!
        //    {
        //        Console.WriteLine("Invalid count");
        //    }
        //    else
        //    {
        //        var type = inputData[2];
        //        if (command == "first" || command == "last")
        //        {
        //            if (command == "first" && type == "even")
        //            {
        //                nums = nums.Where(a => a % 2 == 0).ToArray();
        //                // !!!!
        //                nums = nums.Take(count).ToArray();
        //            }
        //            if (command == "first" && type == "odd")
        //            {
        //                nums = nums.Where(a => a % 2 == 1).ToArray();
        //                nums = nums.Take(count).ToArray();
        //            }
        //            else if (command == "last" && type == "even")
        //            {
        //                nums = nums.Where(a => a % 2 == 0).ToArray();
        //                var skiped = nums.Length - count;
        //                nums = nums.Skip(skiped).ToArray();
        //            }
        //            else if (command == "last" && type == "odd")
        //            {
        //                nums = nums.Where(a => a % 2 == 1).ToArray();
        //                var skiped = nums.Length - count;
        //                nums = nums.Skip(skiped).ToArray();
        //            }
        //        }
        //        Console.WriteLine('[' + string.Join(", ", nums) + "]"); // firstOrLast
        //    }

        //    return nums;
        // }
    }

