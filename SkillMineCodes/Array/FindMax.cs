using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.Array
{
    internal class FindMax
    {
        public void Max(int[] a)
        {
            int m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (m < a[i])
                {
                    m = a[i];
                }
            }
            Console.WriteLine(m);
        }


        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            FindMax f = new FindMax();
            f.Max(a);
        }
    }
}
