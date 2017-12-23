using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Ladybugs
{
    class Program
    {
        //private static void MoveLadyBug(int[] ladyBugs, int ladyBugIndex, string directions, int count)
        //{
        //    if (directions == "left")
        //    {
        //        count = -count;
        //    }
        //    var nextIndex = ladyBugIndex + count;
        //    ladyBugs[ladyBugIndex] = 0;
        //    var hasLeftArrayOrFoundPlace = false;
        //    while (!hasLeftArrayOrFoundPlace)
        //    {
        //        if (nextIndex < 0 || nextIndex > ladyBugs.Length - 1)
        //        {
        //            hasLeftArrayOrFoundPlace = true;
        //            continue;
        //        }
        //        var ladyBugExistOnIndex = ladyBugs[nextIndex] == 1;
        //        if (ladyBugExistOnIndex)
        //        {
        //            nextIndex += count;
        //            continue;
        //        }

        //        ladyBugs[nextIndex] = 1;
        //        hasLeftArrayOrFoundPlace = true;
        //    }
        //}

        static void Main()
        {
            // Решение 3: вярно!
           
           
                int fieldSize = int.Parse(Console.ReadLine());
                int[] indexesWithBugs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int[] field = new int[fieldSize];

                for (int i = 0; i < fieldSize; i++)
                {
                    if (indexesWithBugs.Contains(i))
                    {
                        field[i] = 1;
                    }
                    else
                    {
                        field[i] = 0;
                    }
                }

                string[] command = Console.ReadLine().Split(' ').ToArray();
                while (command[0] != "end")
                {
                    int index = int.Parse(command[0]);
                    int moving = int.Parse(command[2]);
                    if (index < 0 || index >= field.Length)
                    {
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else if (field[index] == 0)
                    {
                        command = Console.ReadLine().Split();
                        continue;
                    }
                    else if (field[index] == 1)
                    {
                        if (command[1] == "right")
                        {
                            index = int.Parse(command[0]);
                            moving = int.Parse(command[2]);

                            if (moving > 0)
                            {
                                MoveRight(field, index, moving);
                            }
                            else if (moving < 0)
                            {
                                MoveLeft(field, index, Math.Abs(moving));
                            }
                        }

                        else if (command[1] == "left")
                        {
                            if (moving > 0)
                            {
                                MoveLeft(field, index, moving);
                            }
                            else if (moving < 0)
                            {
                                MoveRight(field, index, Math.Abs(moving));
                            }
                        }

                        command = Console.ReadLine().Split(' ').ToArray();
                    }

                } // End of the loop

                Console.WriteLine(string.Join(" ", field));

            } // End of Main method

            static void MoveRight(int[] field, int index, int moving)
            {

                if (index + moving >= field.Length)
                {
                    field[index] = 0;
                }
                else
                {
                    field[index] = 0;
                    for (int i = index + moving; i < field.Length; i += moving)
                    {
                        if (field[i] == 1)
                        {
                            continue;
                        }

                        else
                        {
                            field[i] = 1;
                            break;
                        }
                    }
                }
                return;
            }

            static void MoveLeft(int[] field, int index, int moving)
            {

                if (index - moving < 0)
                {
                    field[index] = 0;
                }
                else
                {
                    field[index] = 0;

                    for (int i = index - moving; i > -1; i -= moving)
                    {
                        if (field[i] == 1)
                        {
                            continue;
                        }
                        else
                        {
                            field[i] = 1;
                            break;
                        }
                    }
                }
                return;
  



    //    // този вариант има грешка - намери я !!!
    //    var fieldSize = int.Parse(Console.ReadLine());
    //    var ladyBugIndexes = Console.ReadLine().Split().Select(int.Parse)
    //        .Where(a=>a>=0 && a>fieldSize).ToArray(); //т.е. още тук ограничаваме подаваните индекси!

    //    var ladyBugs = new int[fieldSize];

    //    foreach (var ladibugIndex in ladyBugIndexes)
    //    {
    //        ladyBugs[ladibugIndex] = 1;
    //    }

    //    while (true)
    //    {
    //        var line = Console.ReadLine();
    //        if (line == "end")
    //            break;

    //        var tokens = line.Split();
    //        var ladyBugIndex = int.Parse(tokens[0]);
    //        var directions = tokens[1];
    //        var count= int.Parse(tokens[2]);

    //        var isInsideArray = ladyBugIndex >= 0 && ladyBugIndex < ladyBugs.Length;

    //        if(!isInsideArray)
    //        {
    //            continue;
    //        }
    //        var ladyBugExist = ladyBugs[ladyBugIndex] == 1;  // ???!!!
    //        if(!ladyBugExist)
    //        {
    //            continue;
    //        }

    //        MoveLadyBug(ladyBugs, ladyBugIndex, directions, count);

    //    }

    //    Console.WriteLine(string.Join(" ", ladyBugs));


    // 40/100
    //var n = int.Parse(Console.ReadLine());
    //var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray(); // have to check inside or not!!
    //var field = new int[n];
    //for (int i = 0; i < indexes.Length; i++)
    //{
    //    if (indexes[i] >= 0 && indexes[i] < field.Length)
    //    {
    //        var check = field[indexes[i]];
    //        field[indexes[i]] = 1;
    //    }
    //}            

    //while(true)
    //{
    //    var command = Console.ReadLine();
    //    if(command=="end")
    //    {
    //        break;
    //    }
    //    var commands = command.Split();
    //    var index = int.Parse(commands[0]);
    //    var direction = commands[1];
    //    var flyLength=int.Parse(commands[2]);


    //    for (int i = 0; i < field.Length; i++)
    //    {
    //        if (index == i && field[i] == 1)
    //        {
    //            field[i] = 0; // flyaway отлита и остава празно поле
    //            if (direction == "right" && i + flyLength < field.Length) // !!!
    //            {
    //                field[i + flyLength] = 1;
    //                if (field[i + flyLength] == 1 && i + flyLength * 2 < field.Length)
    //                {//
    //                    while(i + flyLength * 2 < field.Length)///////////// Проблем ае тук

    //                    field[i + flyLength * 2] = 1;
    //                }
    //                else
    //                {
    //                    field[i + flyLength] = 1;
    //                }
    //            }
    //            else if (direction == "left" && i - flyLength > 0) // !!!
    //            {

    //                if (field[i - flyLength] == 1 && i - flyLength * 2 < 0)
    //                {
    //                    field[i - flyLength * 2] = 1;
    //                }
    //                else
    //                {
    //                    field[i - flyLength] = 1;
    //                }
    //            }

    //        }

    //    }

    //}
    //Console.WriteLine(string.Join(" ", field));

}
    }
}
