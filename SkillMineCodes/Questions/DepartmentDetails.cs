using System;
using System.Collections.Generic;

namespace SkillMineCodes.Questions
{
    enum Department
    {
        HR,
        Developer,
        Testing
    }

    class Employee
    {
        public int eId { get; set; }

        public int eSalary { get; set; }

        public string eName { get; set; }

        public Department DepartmentType;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list =
                new List<Employee>()
                {
                    new Employee {
                        eId = 101,
                        eName = "NAYAN",
                        eSalary = 1000,
                        DepartmentType = Department.Developer 
                    },
                    new Employee {
                        eId = 102,
                        eName = "Adi",
                        eSalary = 2000,
                        DepartmentType = Department.HR 
                    },
                    new Employee {
                        eId = 103,
                        eName = "Nomya",
                        eSalary = 1500,
                        DepartmentType = Department.Testing 
                    },
                };

            foreach (Employee c in list)
            {
                Console.WriteLine($"Employee id - {c.eId}, Employee Name - {c.eName}, DepartmentType - {c.DepartmentType}");
            }
            
            Console.WriteLine("\nCondition");
            foreach(Employee e in list){
                if(e.eSalary>1000){
                    Console.Write(e.eName+" ");
                }
            }
            Console.WriteLine();


            foreach(Employee e in list){
                if(e.DepartmentType ==Department.HR){
                    Console.Write(e.eName+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
