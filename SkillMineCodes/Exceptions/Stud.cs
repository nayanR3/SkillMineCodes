using System;

namespace SkillMineCodes.Exceptions
{
    public class Stud
    {
        private int marks;

        public void AcceptMarks(int marks)
        {
            if (marks > 100)
            {
                throw new MarksException("Marks can not be greater than 100");
            }
            else
            {
                this.marks = marks;
            }
        }
    }

    public class Program1
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
