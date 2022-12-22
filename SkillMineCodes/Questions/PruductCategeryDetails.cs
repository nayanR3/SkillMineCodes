using System;
using System.Collections.Generic;

namespace SkillMineCodes.Questions
{
    enum Category
    {
        furniture,
        mobile,
    }

    class Product
    {
        public int Price { get; set; }

        public string Name { get; set; }

        public Category CategoryType;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list =
                new List<Product>()
                {
                    new Product {
                        Name = "SOfa",
                        Price = 25000,
                        CategoryType = Category.furniture 
                    },
                    new Product {
                        Name = "Chair",
                        Price =1000,
                        CategoryType = Category.furniture 
                    },
                    new Product {
                        Name = "Iphone 14plus",
                        Price = 140000,
                        CategoryType = Category.mobile 
                    },
                    new Product {
                        Name = "Study Table",
                        Price =5000,
                        CategoryType = Category.furniture 
                    },
                    new Product {
                        Name = "Dining Table",
                        Price =10000,
                        CategoryType = Category.furniture 
                    },
                    new Product {
                        Name = "One plus 10",
                        Price = 60000,
                        CategoryType = Category.mobile 
                    },
                };

            foreach (Product c in list)
            {
                Console.WriteLine($"Product - {c.Name}, Price - {c.Price}, CategoryType - {c.CategoryType}");
            }
            
            Console.WriteLine("\nProduct which has price above 10000");
            foreach(Product e in list){
                if(e.Price>10000){
                    Console.WriteLine(e.Name+" - "+e.CategoryType+" - "+e.Price);
                }
            }
            Console.WriteLine();

            Console.WriteLine("\nMobile Category Product");
            foreach(Product e in list){
                if(e.CategoryType == Category.mobile){
                    Console.WriteLine(e.Name+"- "+e.CategoryType+" - "+e.Price);
                }
            }
            Console.WriteLine();
        }
    }
}
