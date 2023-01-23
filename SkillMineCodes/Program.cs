using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

namespace SkillMineCodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string s = "abcccc";
            // fnc(s);


            List<string> ItemList = new List<string>();
            for (int i = 0; i < 5; i++) 
            {
                var ListInput = Console.ReadLine(); 
                ItemList.Add(ListInput);
            }
        }

        public static void fnc(string s)
        {
            int n = s.Length;
            int[] freq = new int[26];
            int[] f2 = new int[26];

            for (int i = 0; i < n; i++)
            {
                freq[s[i] - 'a']++;
                f2[s[i] - 'a']++;
            }

            int sm = m(f2);

            Console.WriteLine(sm);

            for (int i = 0; i < freq.Length; i++)
                if (freq[i] == sm)
                    Console.WriteLine((char)(i + 'a') + " " + freq[i]);
        }


        public static int m(int[] freq)
        {
            
            Array.Sort(freq);

            return freq[25];
        }
    

    }
}
