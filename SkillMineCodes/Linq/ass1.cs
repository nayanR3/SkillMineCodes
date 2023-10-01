using System;
using System.Linq;
using System.Collections.Generic;

namespace SkillMineCodes.Linq
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Department { get; set; }


        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {Department}";
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee{Id=1, Name="Adam", Salary=25000, Department="Development"},
                new Employee{Id=2, Name="Steve", Salary=35000, Department="Sales"},
                new Employee{Id=3, Name="Mark", Salary=150000, Department="Marketing"},
                new Employee{Id=4, Name="Devid", Salary=25000, Department="Development"},
                new Employee{Id=5, Name="Ricky", Salary=150000, Department="Marketing"},
                new Employee{Id=6, Name="Jack", Salary=35000, Department="Hr"},
                new Employee{Id=7, Name="Carlos", Salary=150000, Department="Marketing"},
                new Employee{Id=8, Name="John", Salary=35000, Department="Development"},
                new Employee{Id=9, Name="Tim", Salary=50000, Department="Hr"},
                new Employee{Id=10, Name="Stuart", Salary=25000, Department="Sales"}
            };


            // Q1. Display all employee
            // select * from employee
            var r1 = from emp in empList
                     select emp;

            // foreach (Employee e in r1)
            // {
            //     Console.WriteLine(e);
            // }


            // Q2. Display emp from hr dept
            // select * from employee where dept = hr
            var r2 = from emp in empList
                     where emp.Department == "Hr"
                     select emp;

            // foreach (Employee e in r2)
            // {
            //     Console.WriteLine(e);
            // }


            // Q3. Display emp Salary in desc order
            // select * from employee order by salary desc
            var r3 = from emp in empList
                     orderby emp.Salary descending
                     select emp;
            // foreach (Employee e in r3)
            // {
            //     Console.WriteLine(e);
            // }

            // Q4. Display emp whose name start with p
            var r4 = from emp in empList
                     where emp.Name.StartsWith("S")
                     orderby emp.Name ascending
                     select emp;

            // foreach (Employee e in r4)
            // {
            //     Console.WriteLine(e);
            // }

            // Display emp whose dept is development & sort the list by name asc
            var r5 = from e in empList
                     where e.Department == "Development"
                     orderby e.Name ascending
                     select e;

            // foreach (Employee e in r5)
            // {
            //     Console.WriteLine(e);
            // }

            // Display emp whose Salary is in between 25000 to 35000
            var r6 = from e in empList
                     where e.Salary >= 30000 && e.Salary <= 35000
                     orderby e.Salary ascending
                     select e;

            // foreach (Employee e in r6)
            // {
            //     Console.WriteLine(e);
            // }

        }
    }
}