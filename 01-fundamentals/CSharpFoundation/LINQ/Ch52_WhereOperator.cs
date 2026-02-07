using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFoundation.LINQ;
public static class Ch52_WhereOperator
{
    public static void Run()
    {
        //Where = Used for filtering data from a set of data.
        // var cheapBooks = books.Where(b => b.Price < 20); // Method Based Syntax
        // OR
        // var cheapBooks = from b in books where b.Price < 20 select b; // Query Based Synstax

        var books = Ch51_BookDatabase.GetBooksData(); // Get all the book data:
        
        var cheapBooks = books.Where(b => b.Price < 20);
        //var cheapBooks = from b in books where b.Price < 20 select b;

        foreach (var item in cheapBooks)
        {
            Console.WriteLine($"{item.Name} - {item.Price}");
        }
        
        // if we want only the titles of the books that are under 20, then all we need to do is this:
        /*
        var cheapBooks = books.Where(b => b.Price < 20).Select(b => b.Name);

        foreach (var item in cheapBooks)
        {
            Console.WriteLine($"{item}");
        }
        */
        Console.ReadKey();
    }
}
