using System;

namespace SkillMineCodes.OOPS.Properties
{
    /*Create class Book with id, name, author & price(use properties, do not use constructor)*/
    public class Book
    {
        private int id;

        private string name;

        private string author;

        private int price;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, \nName : {Name}, \nAuthor : {Author}, \nPrice : {Price}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.Id = 21;
            b.Name = "Harry Potter";
            b.Author = "J. K. Rowling";
            b.Price = 9999;
            Console.WriteLine(b);
        }
    }

}
