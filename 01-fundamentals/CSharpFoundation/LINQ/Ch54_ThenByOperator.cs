using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpFoundation.LINQ;

public static class Ch54_ThenByOperator
{
    public static void Run()
    {
        // Multiple OrderBy
        // After pplying one OrderBy, if there are same value records for that property,
        // Another ordering can be done based on some other property.

        // var booksCostWise = books.OrderBy(b => b.Price).ThenBy(b => b.Quantity);
        
        // OR

        // var booksCostWise = from b in books orderby b.Price, b.Quantity select b;

        var books = Ch51_BookDatabase.GetBooksData();

        var data = books.OrderBy(b => b.Price).ThenBy(b => b.Name);
        // var data = books.OrderByDescending(b => b.Price).ThenBy(b => b.Name);
        // var data = from b in books orderby b.Price, b.Name select b;
        // var data = from b in books orderby b.Price, b.Name descending select b;

        foreach (var item in data)
        {
            Console.WriteLine($"{item.Name} - {item.Price} Euros"); 
        }

        Console.ReadKey();
    }
}
