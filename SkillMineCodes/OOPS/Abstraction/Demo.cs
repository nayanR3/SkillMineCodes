using System;

namespace SkillMineCodes.OOPS.Abstraction
{
    public abstract class AbstractDemo1
    {
        public void m1()
        {
            Console.WriteLine("Hello m1");
        }
        public abstract void m2();
    }

    class AbstractDemo2 : AbstractDemo1
    {
        public override void m2()
        {
            Console.WriteLine("Hello m2");
        }
        static void Main(string[] args)
        {
            AbstractDemo2 i = new AbstractDemo2();
            i.m1();
            i.m2();
        }
    }
}
