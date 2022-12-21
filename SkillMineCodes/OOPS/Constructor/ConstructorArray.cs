using System;

namespace SkillMineCodes.OOPS.Constructor
{
    public class Student2
    {
        int rollno;

        string name;

        string address;

        public Student2(int rollno, string name, string address)
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
            Console.WriteLine("\nUsing Constructor");
            Student2[] s =
                new Student2[] {
                    new Student2(1, "Nayan", "Dapoli"),
                    new Student2(2, "Adi", "Ratnagiri")
                };

            foreach (Student2 d in s)
            {
                Console.WriteLine (d);
            }
        }
    }
}
