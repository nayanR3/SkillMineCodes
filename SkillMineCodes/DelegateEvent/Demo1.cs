using System;

namespace SkillMineCodes.DelegateEvent
{
    public delegate int Myd1(int x, int y);

    public delegate string Myd2(string s);

    class Code
    {
        public int m1(int a, int b)
        {
            return a + b;
        }

        public string m2(string s)
        {
            return s.ToUpper();
        }
    }

    class Program{
        static void Main(string[] args)
        {
            Code c= new Code();
            Myd1 d1= new Myd1(c.m1);
            Myd2 d2 = new Myd2(c.m2);

            int sum = d1.Invoke(5,10);
            System.Console.WriteLine(sum);

            string s = d2.Invoke("nayan");
            System.Console.WriteLine(s);
        }
    }
}
