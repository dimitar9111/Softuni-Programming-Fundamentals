using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _06.Book_Library_Modification
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var bookList = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                var newBook = new Book();
                var input = Console.ReadLine().Split();
                newBook.Name = input[0];
                newBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                bookList.Add(newBook);
            }

            DateTime releaseAfter = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var newBookList = bookList
                .OrderBy(d => d.ReleaseDate)
                .ThenBy(t => t.Name).ToList();

            foreach (var book in newBookList)
            {
                if (book.ReleaseDate > releaseAfter)
                {
                    Console.WriteLine($"{book.Name} -> {book.ReleaseDate:dd.MM.yyyy}");
                }
            }
        }
    }
}
