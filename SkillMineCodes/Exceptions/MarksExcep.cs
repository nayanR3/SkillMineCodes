using System;

namespace SkillMineCodes.Exceptions
{
    public class MarksException2 : Exception
    {
        public MarksException2(string message) :
            base(message)
        {
        }
    }

    public class Stud
    {
        private int marks;

        public void AcceptMarks(int marks)
        {
            if (marks > 100)
            {
                throw new MarksException2("Marks can not be greater than 100");
            }
            else
            {
                this.marks = marks;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Stud s = new Stud();
            try
            {
                s.AcceptMarks(85);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                System.Console.WriteLine("Accept");
            }
        }
    }
}
