using System;

namespace SkillMineCodes.OOPS.Properties
{
    public class Employee2
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
            Employee2[] emp = new Employee2[]{
                new Employee2{EmpId=101,EmpName="Steve",EmpSalary=100000},
                new Employee2{EmpId=102,EmpName="Adam",EmpSalary=20000},
                new Employee2{EmpId=103,EmpName="Mark",EmpSalary=30000},
            };

            Console.WriteLine("Using Property");
            foreach (var i in emp)
            {
                Console.WriteLine($"{i.EmpId} , {i.EmpName}, {i.EmpSalary}");
            }
        }
    }
}