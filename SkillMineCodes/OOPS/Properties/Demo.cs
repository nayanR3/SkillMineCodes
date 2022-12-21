using System;

namespace SkillMineCodes.OOPS.Properties
{
    public class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public int EmpSalary { get; set; }

        public override string ToString()
        {
            return $"{EmpId}, {EmpName}, {EmpSalary}";
        }
    }

    public class Program{
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.EmpId=1;
            e.EmpName="Adam";
            e.EmpSalary=10000;
            System.Console.WriteLine(e);
        }
    }
}
