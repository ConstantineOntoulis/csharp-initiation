using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFoundation.LINQ;

public static class Ch53_OrderByOperator
{
    public static void Run()
    {
        // OrderBy: Used for ordering the data based on some property
        // var booksCostWise = books.OrderBy(b => b.Price);
        // var booksCostWise = books.OrderByDescending(b => b.Price);

        // OR

        // var booksCostWise = from b in books orderby b.Price select b;
        // var booksCostWise = from b in books orderby b.Price descending select b;

        var books = Ch51_BookDatabase.GetBooksData();

        var booksCostWise = books.OrderBy(b => b.Price);
        // var booksCostWise = books.OrderByDescending(b => b.Price);

        foreach(var item in booksCostWise)
        {
            Console.WriteLine($"{item.Name} - {item.Price}");
        }
    }
}
