using System.Runtime.CompilerServices;
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
        public int m2(int a, int b)
        {
            return a - b;
        }public int m3(int a, int b)
        {
            return a * b;
        }public int m4(int a, int b)
        {
            return a / b;
        }

        public string m5(string s)
        {
            return s.ToUpper();
        }
        public string m6(string s)
        {
            return s.ToLower();
        }
    }

    class Program{
        static void Main(string[] args)
        {
            Code c= new Code();
            Myd1 d1= new Myd1(c.m1);
            d1+=new Myd1(c.m2);
            d1+=new Myd1(c.m3);
            d1+=new Myd1(c.m4);

            Delegate[] list1= d1.GetInvocationList();
            foreach(Delegate item in list1){
                System.Console.WriteLine("\n"+item.Method);
                System.Console.WriteLine(item.DynamicInvoke(20,5));
            }
            
            Myd2 d2 = new Myd2(c.m5);
            d2+=new Myd2(c.m6);
            Delegate[] list2= d2.GetInvocationList();
            foreach(Delegate item in list2){
                System.Console.WriteLine("\n"+item.Method);
                System.Console.WriteLine(item.DynamicInvoke("NaYan"));
            }            
        }
    }
}
