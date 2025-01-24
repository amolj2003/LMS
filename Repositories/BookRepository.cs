

using LMS_MAIN.Models;
using System.Collections.Generic;

namespace LMS_MAIN.Repositories
{
    public class BookRepository
    {
        // In-memory list of books, initialized with some sample data
        public static List<Book> Books = new List<Book>()
        {
            new Book { ISBN = "978-0131103627", Title = "The C Programming Language", Author = "Brian W. Kernighan, Dennis M. Ritchie", Available = true },
            new Book { ISBN = "978-0201633610", Title = "Design Patterns: Elements of Reusable Object-Oriented Software", Author = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides", Available = false },
            new Book { ISBN = "978-0132350884", Title = "Clean Code: A Handbook of Agile Software Craftsmanship", Author = "Robert C. Martin", Available = true },
            new Book { ISBN = "978-0321125217", Title = "Domain-Driven Design: Tackling Complexity in the Heart of Software", Author = "Eric Evans", Available = true },
            new Book { ISBN = "978-0262033848", Title = "Introduction to the Theory of Computation", Author = "Michael Sipser", Available = false }

        };
    }
}
