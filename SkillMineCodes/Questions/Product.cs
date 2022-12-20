using System;
using System.Collections.Generic;

namespace SkillMineCodes.Quetions
{
    public class C2
    {
        public static void Main(string[] args)
        {
            List<Product> l = new List<Product>();

            l.Add(new Product { Id = 1, Name = "Laptop", Price = 52000 });
            l.Add(new Product { Id = 2, Name = "TV", Price = 3500 });
            l.Add(new Product { Id = 3, Name = "Mobile", Price = 1500 });
            l.Add(new Product { Id = 4, Name = "MacBook", Price = 201500 });

            Console.WriteLine("List of items");
            foreach (Product item in l)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nList of item which has price above 2000");
            foreach (Product item in l)
            {
                if (item.Price > 2000)
                    Console.WriteLine(item);
            }

        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Price}";
        }

    }
}
