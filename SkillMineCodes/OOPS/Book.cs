using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.OOPS
{
    /*Create class Book with id, name, author & price(use properties, do not use constructor)*/
    public class Book
    {
        private int id;
        private string name;
        private string author;
        private int price;


        public int Id
        {

            get
            {
                return id;
            }

            set
            {
                id = value;
            }

        }
        public String Name
        {

            get
            {
                return name;
            }

            set
            {
                name = value;
            }

        }
        public String Author
        {

            get
            {
                return author;
            }

            set
            {
                author = value;
            }

        }
        public int Price
        {

            get
            {
                return price;
            }

            set
            {
                price = value;
            }

        }


        static void Main(string[] args)
        {
            Book b = new Book();
            b.Id= 21;
            b.Name = "Harry Potter";
            b.Author = "J. K. Rowling";
            b.Price= 9999;

            Console.WriteLine($"Id {b.Id}, \nName : {b.Name}, \nAuthor : {b.Author}, \nPrice : {b.Price}");
        }
    }

}
