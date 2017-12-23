using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }


    class Libraly
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
    class AutorInfo
    {
        public string Author { get; set; }
        public decimal Sales { get; set; }
    }

    class BookLibrary
    {
        static void Main()
        {
            var libraly = new Libraly()
            {
                Name = "Prosveta",
                Books = new List<Book>() // за да добавяме книги, трябва 1-во да го инициа-ме така!
            };
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var title = inputLine[0];
                var autor = inputLine[1];
                var publisher = inputLine[2];
                var releaseData = DateTime.ParseExact(inputLine[3], "d.M.yyyy", CultureInfo.InvariantCulture);
                var Isbn = inputLine[4];
                var price = decimal.Parse(inputLine[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = autor,
                    Publisher=publisher,
                    ReleaseDate=releaseData,
                    Price=price
                };

                libraly.Books.Add(book);
            }
            var autors = libraly.Books.Select(a => a.Author).Distinct().ToArray();

            var autorSales = new List<AutorInfo>();

            foreach (var autor in autors)
            {
                var sales = libraly.Books.Where(a => a.Author == autor).Sum(a=>a.Price); // autorBooks

                var authorInfo=new AutorInfo
                {
                    Author = autor,
                    Sales = sales
                };
                autorSales.Add(authorInfo);

                autorSales = autorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();

               
            }
            foreach (var autorInformation in autorSales)
            {
                Console.WriteLine($"{autorInformation.Author} -> {autorInformation.Sales:f2}");
            }

        }
    }
}

 