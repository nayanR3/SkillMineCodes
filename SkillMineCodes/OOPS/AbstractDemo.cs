using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.OOPS
{
    public abstract class AbstractDemo1
    {
        public AbstractDemo1()
        {
        }
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
