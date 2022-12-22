using System;

namespace SkillMineCodes.Exceptions
{
    // Custom Exception class
    public class MarksException1 : Exception
    {
        public MarksException1(string message) :
            base(message)
        {
        }
    }

    public class Student
    {
        private int marks;

        public void AcceptMarks(int marks)
        {
            if (marks > 100)
            {
                throw new MarksException1("Marks can not be greater than 100");
            }
            else
            {
                this.marks = marks;
            }
        }
    }

    public class Demo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            try
            {
                s.AcceptMarks(101);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
