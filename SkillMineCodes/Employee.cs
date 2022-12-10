using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes
{
    internal class Employee
    {
        private string name;
        private string addree;
        private int salary;

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
            return $"Empid: {Empid}, Name: {Name}, Address: {Address}, Salary: {Salary}";
        }
    }
}
