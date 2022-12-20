using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.ArrayQuestions
{
    internal class EvenNo
    {
        public void EvenFind(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }


        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            EvenNo o = new EvenNo();
            o.EvenFind(a);
        }

    }
}
