using System;
using SkillMineCodes.WrittenTest.Dec10;

namespace SkillMineCodes
{
    public class Program
    {
        /*static void Main(string[] args)
        {
            Book b = new Book();
            b.Id = 21;
            b.Name = "Harry Potter";
            b.Author = "J. K. Rowling";
            b.Price = 9999;
            Console.WriteLine(b);


            //Console.WriteLine($"Id {b.Id}, \nName : {b.Name}, \nAuthor : {b.Author}, \nPrice : {b.Price}");
        }*/


        /*static void Main(string[] args)
        {
            Student s = new Student("Nayan", 24, "Dapoli", 75, 80, 85, 90);
            int t = s.CalculateTotal();
            s.CalculatePercentage(t);
            Console.WriteLine(s);
        }*/


       /* static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.Name = "Nr";
            e1.Address = "Dapoli";
            e1.Salary = 10000;

            Console.WriteLine(e1);


            Employee e2 = new Employee();

            e2.Name = "Adi";
            e2.Address = "Khed";
            e2.Salary = 90000;

            Console.WriteLine(e2);
        }*/


        static void Main(string[] args)
        {
            DecQ2 o = new DecQ2();
            o.A = 10;
            o.B = 20;
            Console.WriteLine("Before swap");
            Console.WriteLine(o);
            o.Cal();
            Console.WriteLine("After swap");
            Console.WriteLine(o);
        }

    }
}
