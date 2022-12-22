using System;

namespace SkillMineCodes.StringFolder
{
    public class CharToggle
    {
        public static void Main(String[] args)
        {
            String s = "hello WORLD";
            char[] arr = s.ToCharArray();
            fun(arr);
            Console.WriteLine("String after toggle ");
            Console.WriteLine();
            Console.WriteLine(String.Join("", arr));
        }

        static void fun(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    str[i] = (char)(str[i] + 'a' - 'A');
                else if (str[i] >= 'a' && str[i] <= 'z')
                    str[i] = (char)(str[i] + 'A' - 'a');
            }
        }
    }
}
