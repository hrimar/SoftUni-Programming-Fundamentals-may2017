using System;
using System.Collections.Generic;
using System.Linq;

namespace Debugg18SequenceofCommands
{
    class Debugg18SequenceofCommands
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine().Split(ArgumentsDelimiter)
                .Select(long.Parse).ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))// over
            {
                //string line = Console.ReadLine().Trim();//?
                int[] args = new int[2];

                if (command.Contains("add") || command.Equals("substract") ||
                    command.Equals("multiply"))
                {
                    string[] stringParams = command.Split(ArgumentsDelimiter);// line.Split
                    string action = stringParams[0]; // az go dobavih
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, action, args);
                }
                               

                PerformAction(array, command, args); 

                PrintArray(array);
                Console.WriteLine('\n');

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;                    break;
                case "add":
                    array[pos] += value;                    break;
                case "subtract":
                    array[pos] -= value;                    break;
                case "lshift":
                    ArrayShiftLeft(array);                  break;
                case "rshift":
                    ArrayShiftRight(array);                 break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
        }

        private static void ArrayShiftLeft(long[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
