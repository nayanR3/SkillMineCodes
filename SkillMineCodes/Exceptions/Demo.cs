/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Exceptions
{
    // Custom Exception class
    public class MarksException : Exception
    {
        public MarksException(string message) : base(message)
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
                throw new MarksException("Marks can not be greater than 100");
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
            Stud s = new Stud();
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
*/