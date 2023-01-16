using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.ZobinTest.Week_8
{
    // find max length of sub-array which consists equal no. of zero's and one's
    public class Q2
    {
        static void Main(string[] args)
        {
            int[] a = new int[6];
            for (int i = 0; i < 6; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            fun (a);
        }

        public static void fun(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    ArrayList al = new ArrayList();
                    for (int k = i; k <= j; k++)
                    {
                        al.Add(arr[k]);
                    }

                    int cMax = check(al);
                    if (max < cMax)
                    {
                        max = cMax;
                    }
                }
            }
            Console.WriteLine (max);
        }

        public static int check(ArrayList al)
        {
            int[] arr = al.ToArray(typeof (int)) as int[];
            int[] ta = al.ToArray(typeof (int)) as int[];

            int len = 0;
            int n = arr.Length;
            if (n % 2 == 0)
            {
                int
                    zero = 0,
                    one = 0;
                Array.Sort (ta);
                for (int i = 0; i < n; i++)
                {
                    if (ta[i] == 0)
                        zero++;
                    else
                        one++;
                }
                if (zero == one)
                {
                    for (int i = 0; i < n; i += 2)
                    {
                        int j = i + 1;
                        if (arr[i] == 0 && arr[j] == 1) len += 2;
                    }
                }
            }
            return len;
        }
    }
}

/*
        0 1 2 3       <-- index
        8 3 9 7       <-- element

        8
        8 3
        8 3 9
        8 3 9 7
        3
        3 9
        3 9 7
        9
        9 7
        7
*/
