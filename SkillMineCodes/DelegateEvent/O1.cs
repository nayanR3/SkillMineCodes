using System;

namespace SkillMineCodes.DelegateEvent
{
    public delegate void D1();

    class Student
    {
        public event D1 Counter;

        int

                id,
                c;

        string

                name,
                address;

        public Student(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public Count()
        {
            c++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] s =
                new Student[] {
                    new Student(1, "Nayan", "Dapoli"),
                    new Student(2, "Adi", "Ratnagiri")
                };

                s.D
        }
    }
}
