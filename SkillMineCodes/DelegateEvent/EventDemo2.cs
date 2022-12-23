using System;

namespace killMineCodes.DelegateEvent
{
    public delegate void MyD1();

    public class Stud
    {
        public event MyD1 Pass; // declaration of event

        public event MyD1 Fail;

        public void Accept(int marks)
        {
            if (marks >= 40)
            {
                Pass(); //raise an event
            }
            else
            {
                Fail();
            }
        }
    }

    public static class Message
    {
        public static void PassMessage()
        {
            Console.WriteLine("Great ! you are pass");
        }

        public static void FailMessage()
        {
            Console.WriteLine("Sorry ! you are Fail");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Stud s1 = new Stud();

            s1.Pass += new MyD1(Message.PassMessage); // bind event with delegate
            s1.Fail += new MyD1(Message.FailMessage);

            s1.Accept(38);
        }
    }
}
