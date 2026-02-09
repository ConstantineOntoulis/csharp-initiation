using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFoundation.LINQ;

public static class Ch55_GroupByOperator
{
    public static void Run()
    {
        // GroupBy Operator
        // Used for grouping data based on any property

        // var groupedBooks = books.GroupBy(b => b.Author);

        // OR

        // var groupedBooks = from b in books group b by b.Author

        var books = Ch51_BookDatabase.GetBooksData();

        var groupedBooks = books.GroupBy(b => b.Author);
        /*
        foreach(var item in groupedBooks) // Set of books associated with Author Key. This printing method makes it 
        {                                 // Difficult to preview the data 
            Console.WriteLine($"{item.Key}");
        }
        */
        // Grouped data can be put into new list with the Grouped Key and other data
        // Grouping and putting into new list

        // var output = books.GroupBy(b => b.Author).Select(g => new
        //              {
        //                  Author = g.Key,
        //                  BookCount = g.Count() // Count() is an extension LINQ method
        //              });

        // OR

        // var output = from b in books
        //                          group b by b.Author into g
        //                          select new 
        //                          {
        //                              Author = g.Key,
        //                              BookCount = g.Count()
        //                          };
        /*
        var output = books.GroupBy(b => b.Author).Select(g => new
        {
            Author = g.Key,
            BookCount = g.Count()
        }).OrderByDescending(b => b.BookCount);
        */

        var output = books.GroupBy(b => b.Author).Select(g => new
        {
            Author = g.Key,
            Books = g.Select(book => book)
        });

        // var output = from b in books group b by b.Author into g select new
        // {
        //      Author = g.Key,
        //      BookCount = g.Count()
        // };
        /*
        foreach (var item in output)
        {
            Console.WriteLine($"{item.Author} - {item.BookCount}");
        }
        */
        /*
        foreach (var item in output)
        {
            Console.WriteLine($"{item.Author}");
            foreach(var book in item.Books)
            {
                Console.WriteLine($"    {book.Name} - {book.Price}");
            }
        }
        */
        // -----------------------------------------------------------------------------

        var data = books.Where(b => b.Price < 15).GroupBy(b => b.Author).Select(g => new
        {
            Author = g.Key,
            Books = g.Select(book => book.Name)
        }).OrderBy(t => t.Author);

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Author}");
            foreach (var book in item.Books)
            {
                Console.WriteLine($"    {book}");
            }
        }

        Console.ReadKey();
    }
}
