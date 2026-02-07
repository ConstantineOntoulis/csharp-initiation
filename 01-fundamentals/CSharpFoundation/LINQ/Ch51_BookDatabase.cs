using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFoundation.LINQ
{
    public class Ch51_BookDatabase
    {
        public static IEnumerable<Ch51_Book> GetBooksData()
        {
            return new List<Ch51_Book>
            {
                new Ch51_Book(121, "Harry Potter and the Sorcerer's Stone", 20, "J.K. Rowling"),
                new Ch51_Book(186, "Tell Me Your Dreams", 15, "Sidney Sheldon"),
                new Ch51_Book(112, "The Monk Who Sold His Ferrari", 10, "Robin Sharma"),
                new Ch51_Book(145, "Half Girlfriend", 10, "Chetan Bhagat"),
                new Ch51_Book(167, "Harry Potter and the Half-Blood Prince", 20, "J.K. Rowling"),
                new Ch51_Book(133, "Who Will Cry When You Die?", 10, "Robin Sharma"),
                new Ch51_Book(177, "The 7 Habits of Highly Effective People", 25, "Stephen Covey")
            };
        }
    }
}
