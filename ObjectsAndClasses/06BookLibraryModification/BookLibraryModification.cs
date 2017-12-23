using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;


namespace _06BookLibraryModification
{
    class Program
    {
        static void Main()
        {

            // РЕШИ ЗАДАЧАТА И С КЛАСОВЕ!!! ТЕ ДАВАТ ПОВЕЧЕ СВОБОДА !


            // Решение с Dictionary, но даде 63/100:
            var books = ReadAllBooks();

            var date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            foreach (var bookDate in books.OrderBy(r=>r.Value).Where(r=>r.Value>date))
            {
                Console.WriteLine($"{bookDate.Key} -> {bookDate.Value:dd.MM.yyyy}");
            }
        }

        private static Dictionary<string, DateTime> ReadAllBooks()
        {
            var result = new Dictionary<string, DateTime>();
            var n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var bookName = input[0];
                var date = DateTime.ParseExact(input[3], "d.M.yyyy", CultureInfo.InvariantCulture);

                if(!result.ContainsKey(bookName))
                {
                    result[bookName] = date;
                }
            }
            return result;
        }
    }
}
