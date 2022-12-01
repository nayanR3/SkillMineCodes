using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SkillMineCodes.Array
{

    /*Q4.Frequency of given element.*/
    class Q4
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(System.Console.ReadLine());
            Q4 o = new Q4();
            o.frequency(a,x);
        }

        public void frequency(int[] a, int x)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] == x)
                    count++;

            Console.WriteLine("Frequency of "+x+" is "+count);
        }
    }
}
