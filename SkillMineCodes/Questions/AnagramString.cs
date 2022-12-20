using System;

namespace SkillMineCodes.Questions
{
    public class AnagramString
    {
        public static void Main(string[] args)
        {
            Console.Write("Eneter string 1 : ");
            string s1 = Console.ReadLine();
            Console.Write("Eneter string 2 : ");
            string s2 = Console.ReadLine();

          //  anagram(s1, s2);
            //another(s1, s2);
        }

        /*public static void anagram(string s1, string s2)
        {
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            Array.Sort(c1);
            Array.Sort(c2);

            int i = 0;
            bool f = true;
            while (i < c1.Length)
            {
                if (c1[i] != c2[i])
                {
                    f = false;
                    break;
                }
                i++;
            }

            if (f == true)
            {
                Console.WriteLine("Strings are Anagram");
            }
            else
            {
                Console.WriteLine("Strings are not anagram");
            }
        }

  */      public static void another(string s1, string s2)
        {
            int l1 = s1.Length;
            int l2 = s2.Length;

            if (l1 != l2)
            {
                Console.WriteLine("NO");
            }
            else
            {
                char[] c1 = s1.ToCharArray();
                char[] c2 = s2.ToCharArray();
                int[] a1 = new int[256];
                int[] a2 = new int[256];

                for (int i = 0; i < l1; i++)
                {
                    a1[c1[i] - 'a']++;
                    a2[c2[i] - 'a']++;
                }

                bool f = true;
                for (int i = 0; i < l1; i++)
                {
                    if (a1[i] != a2[i])
                    {
                        f = false;
                        break;
                    }
                }
                if (f == true)
                {
                    Console.WriteLine("anagram");
                }
                else { Console.WriteLine(); }

            }

        }
    }
}
