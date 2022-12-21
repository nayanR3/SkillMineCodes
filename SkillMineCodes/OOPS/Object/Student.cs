using System;
namespace SkillMineCodes.OOPS.Object{
    public class Student
    {
        int rollno;

        string name;

        string address;

        public Student(int rollno, string name, string address)
        {
            this.rollno = rollno;
            this.name = name;
            this.address = address;
        }

        public override string ToString()
        {
            return $"{rollno}, {name}, {address}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student(1,"Nayan","Dapoli");
            Student b = new Student(2,"Adi","Ratnagiri");
            Student c = new Student(3,"Nomya","Kolhapur");
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
        }
    }
}