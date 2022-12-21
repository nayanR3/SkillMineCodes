using System;
namespace SkillMineCodes.OOPS.Constructor{
    public class Student1
    {
        int rollno;

        string name;

        string address;

        public Student1(int rollno, string name, string address)
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
            Student1 a = new Student1(1,"Nayan","Dapoli");
            Student1 b = new Student1(2,"Adi","Ratnagiri");
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
        }
    }
}