using System;

namespace SkillMineCodes.OOPS.Properties
{
    public class Employee
    {
        static int count = 0;

        public int Empid
        {
            get
            {
                count++;
                return count;
            }
        }

        public string Name { get; set; }

        public string Address { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $"Empid: {Empid}, Name: {Name}, Address: {Address}, Salary: {
                Salary}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Name = "NAYAN";
            e1.Address = "Dapoli";
            e1.Salary = 10000;
            Console.WriteLine (e1);

            Employee e2 = new Employee();
            e2.Name = "Adi";
            e2.Address = "Khed";
            e2.Salary = 90000;
            Console.WriteLine (e2);

            Employee e3 = new Employee();
            e3.Name = "NR";
            e3.Address = "Ratnagiri";
            e3.Salary = 100000;
            Console.WriteLine (e3);
        }
    }
}
