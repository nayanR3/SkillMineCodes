using System;
using System.Collections.Generic;

namespace SkillMineCodes.Questions
{
    enum BookCategory
    {
        Comic,
        Biographies,
        Drama
    }

    class Book
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public BookCategory BookCategoryType;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> list =
                new List<Book>()
                {
                    new Book {
                        Name = "Harry Potter",
                        Author = "J. K. Rowling",
                        Price = 5000,
                        BookCategoryType = BookCategory.Drama
                    },
                    new Book {
                        Name = "Cin City",
                        Author = "Frank Miller",
                        Price = 10000,
                        BookCategoryType = BookCategory.Comic
                    },
                    new Book {
                        Name = "Wings of Fire",
                        Author = "A. P. J. Abdul Kalam",
                        Price = 10000,
                        BookCategoryType = BookCategory.Biographies
                    }
                };

            foreach (Book c in list)
            {
                Console
                    .WriteLine($"Book - {c.Name}, Price - {c.Price}, Author - {c.Author}, BookCategoryType - {c.BookCategoryType}");
            }

            Console.WriteLine("\nBook which has price above 5000");
            foreach (Book e in list)
            {
                if (e.Price > 5000)
                {
                    Console
                        .WriteLine(e.Name +
                        " - " +
                        e.BookCategoryType +
                        " - " +
                        e.Price);
                }
            }
            Console.WriteLine();

            Console.WriteLine("\nBook Category ");
            foreach (Book e in list)
            {
                if (e.BookCategoryType == BookCategory.Comic)
                {
                    Console
                        .WriteLine(e.Name +
                        "- " +
                        e.BookCategoryType +
                        " - " +
                        e.Price);
                }
            }
            Console.WriteLine();
        }
    }
}
