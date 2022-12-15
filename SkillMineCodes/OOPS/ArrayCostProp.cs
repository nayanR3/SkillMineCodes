using SkillMineCodes.OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.OOPS
{
    public class EmployeeProperty
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empSalary { get; set; }        
    }



    public class StudentConstructor
    {
        int rollno;
        string name;
        string address;

        public StudentConstructor(int rollno, string name, string address)
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
}



/*static void Main(string[] args)
{
    EmployeeProperty[] e = new EmployeeProperty[]
    {
                new EmployeeProperty{empId=101,empName="Stive",empSalary=100000},
                new EmployeeProperty{empId=102,empName="Adam",empSalary=20000},
                new EmployeeProperty{empId=103,empName="Mark",empSalary=30000},
    };

    Console.WriteLine("Using Property");
    foreach (var i in e)
    {
        Console.WriteLine($"{i.empId} , {i.empName}, {i.empSalary}");
    }



    Console.WriteLine("\nUsing Constuctor");
    StudentConstructor[] stud = new StudentConstructor[]
    {
                new StudentConstructor(1,"Nayan","Dapoli"),
                new StudentConstructor(2,"Adi","Ratnagiri")
    };

    foreach (var d in stud)
    {
        Console.WriteLine(d);
    }

}*/