using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.OOPS
{
    /*Create a Student class & calculate total & percentage(use constructor)*/
    public class Student
    {
        private string name;
        private int age;
        private string address;
        private int phy, chem, maths, bio, total, percentage;

        public Student(string name, int age, string address, int phy, int chem, int maths, int bio )
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.phy = phy;
            this.chem = chem;
            this.maths = maths;
            this.bio = bio;
        }

        public int CalculateTotal()
        {
            total = phy + chem + maths + bio;
            return total;
        }

        public void CalculatePercentage(int total)
        {
            percentage = (total * 100) / 400;
        }

        public override string ToString()
        {
            return $"Name : {name},\nAge : {age}, \nAddress : {address}, \nTotal : {total}, \nPercentage : {percentage}";
        }

    }
}
