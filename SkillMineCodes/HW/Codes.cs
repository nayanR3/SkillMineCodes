using System;
using System.Collections.Generic;

namespace SkillMineCodes.HW
{
    public class program
    {
        /*public static void Main(string[] args)
        {
            Book b = new Book("Harry Potter", "J. K. Rowling", 999.99);
            Console.WriteLine("Befor Discount");
            Console.WriteLine(b);
            b.DisPrice();
            Console.WriteLine("After Discount");
            Console.WriteLine(b);
        }*/
    }

    /*
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
            return $"\nBook Name - {name} \nBook Author - {author} \nBook Price - {price}";
        }

    }*/




    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }

        public static void Main(string[] args)
        {
            List<Product> l = new List<Product>();

            l.Add(new Product { Id = 1, Name = "Laptop", Price = 52000 });
            l.Add(new Product { Id = 2, Name = "TV", Price = 3500 });

            foreach (Product item in l)
            {
                Console.WriteLine(item);
            }
        }
    }
}
