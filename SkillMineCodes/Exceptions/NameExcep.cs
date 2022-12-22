using System;

namespace SkillMineCodes.Exceptions
{
    public class Stud2
    {
        private string name;

        public void AcceptName(string name)
        {
            if (name == null || name == "")
            {
                throw new NameException("Name can not be null or empty");
            }
            else
            {
                this.name = name;
            }
        }

        public override string ToString()
        {
            return $"{this.name}";
        }
    }

    public class NameException : Exception
    {
        public NameException(string message) :
            base(message)
        {
        }
    }

    public class Program2
    {
        static void Main(string[] args)
        {
            Stud2 s = new Stud2();
            try
            {
                s.AcceptName(name: null);
                System.Console.WriteLine (s);
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
