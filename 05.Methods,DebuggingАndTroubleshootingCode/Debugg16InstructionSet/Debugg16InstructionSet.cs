using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Debugg16InstructionSet
{
    class Debugg16InstructionSet
    {
        static void Main()
        {
            string opCode = Console.ReadLine().ToLower();
            BigInteger result = 0;

            while (opCode != "end")
            {
                string[] codeArgs = opCode.Split(' ');

              
                switch (codeArgs[0])
                {
                    case "inc":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            result = ++operandOne; // !!!
                            break;
                        }
                    case "dec":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            result = --operandOne; // не operandOne-- , а --operandOne !!
                            break;
                        }
                    case "add":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "mla":
                        {
                            BigInteger operandOne = BigInteger.Parse(codeArgs[1]);
                            BigInteger operandTwo = BigInteger.Parse(codeArgs[2]);
                            result = (operandOne * operandTwo);
                            break;
                        }
                      
                }
                Console.WriteLine(result);
                opCode = Console.ReadLine().ToLower(); 
               
            }
             
        }
    }
}
