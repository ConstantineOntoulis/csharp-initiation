using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFoundation.LINQ;

public static class Ch51_SelectOperator
{
    public static void Run()
    {
        // Chapter 51: NestedLoops
        // Language Integrated Query
        // 2 synstaxes: Method Based and Query Based
        // LINQ applications: LINQ to Objects (collections, files, Strings, etc.)
        //                    LINQ to Entities (Entity Framework conceptual model)
        //                    LINQ to XML (XML Documents)
        //                    LINQ to DataSets (ADO.Net Data Sets)

        //-----------------------------------------------------------------------------

        // LINQ Extension Method based Syntax
        // var output = books.Where(condition)
        //                   .OrderBy(property)
        //                   .Select(property);

        // LINQ Query Operator based Syntax
        // var output = from b in books
        //                     where condition
        //                     orderby property
        //                     select property;

        // SELECT Operator

        // Used for selecting a particular propert out of an object
        // SELECT Operator also allows to define a new type with selected property

        // var authors = books.Select(b => b.Author);
        
        //OR

        // var authors = from b in books select b.Author;

        // Defining a new type using Select
        /*
        var data = books.Select(b => new
        {
            BookName = b.Name,
            Cost = b.Prices
        });
        */

        var books = Ch51_BookDatabase.GetBooksData();

        var data = from b in books select b.Author;

        // OR

        // var data = books.Select(b => b.Author);
        /*
        var data1 = books.Select(b => new
        {
            BookName = b.Name,
            Cost = b.Price
        });
        */

        /*
        var data1 = from b in books select new
        {
            BookName = b.Name,
            Price = b.Price
        };
        */

        // OR If you don't want to use "new", you can use Tuples

        // var data1 = books.Select(b => (BookName: b.Name, BookPrice: b.Price));
        var data1 = books.Select(b => (BookName: b.Name, BookPrice: b.Price)).ToList();

        foreach (var book in data) {
            Console.WriteLine(book);
        }

        Console.WriteLine();
        // If you don't wanna use a foreach, there is another way (a shortcut) but that way ONLY works with lists.
        // In this case, we will have to convert our data1 from enumerable to list.

        /*
        foreach (var item in data1)
        {
            Console.WriteLine($"{item.BookPrice} Euros - {item.BookName}");
        }
        */

        data1.ForEach(b=> Console.WriteLine($"{b.BookPrice} Euros - {b.BookName}"));

        Console.WriteLine();

        Console.ReadKey();
    }
}
