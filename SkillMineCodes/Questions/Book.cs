using System;

namespace SkillMineCodes.Questions
{

    public class Book
    {
        string name, author;
        double price;

        public Book(string name, string author, double price)
        {
            this.name = name;
            this.author = author;
            this.price = price;
        }

        double dicP = 0.0;
        public void DisPrice()
        {
            dicP = (10 * price) / 100;
            price = price - dicP;
        }

        public override string ToString()
        {
            return $"Book Name - {name} \nBook Author - {author} \nBook Price - {price}";
        }

    }

    public class C1
    {
        public static void Main(string[] args)
        {
            Book b = new Book("Harry Potter", "J. K. Rowling", 999.99);
            Console.WriteLine("Befor Discount");
            Console.WriteLine(b);
            b.DisPrice();
            Console.WriteLine("\nAfter Discount");
            Console.WriteLine(b);
        }
    }
}
