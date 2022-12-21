using System;

namespace SkillMineCodes.OOPS.Inheritance
{
    /*Q1.create student class, 
	student has different different properties, declare that properties with different different modifier
    and their is some methods with different access modifiers
    Access this student data in same class, in another class and inside the sub-class.*/
    class Student
    {
        internal string name = "Nayan";

        int rollno;

        public string address;

        protected int phone;
    }

    class StudInfo : Student
    {
        static void Main(string[] args)
        {
            StudInfo so = new StudInfo();
            so.address = "Dapoli";
            so.phone = 1111111;

            Console.WriteLine(so.name + " " + so.address + " " + so.phone);
        }
    }
}
