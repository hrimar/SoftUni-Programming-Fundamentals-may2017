using System;
using System.Collections.Generic;
using System.Linq;

namespace More08PersonalException
{
    class MyException : Exception
    {
        public MyException() : base("My first exception is awesome!!!")
        {

        }
    }
    class PersonalException
    {
        static void Main()
        {            
            // Напишете Ваш Exception, който се пояшява при подаване на отрицат. число!
            while (true)
            {
                var n = int.Parse(Console.ReadLine());

                try
                {
                    if (n < 0)
                    {
                        throw new MyException();
                    }
                    else
                    {
                        Console.WriteLine(n);
                    }
                }
                catch (MyException my)
                {
                    Console.WriteLine(my.Message);
                    return;
                    //Ако дадем само throw my; ще ни даде обичайния дълъг exception
                }
            }
        }
    }
}
