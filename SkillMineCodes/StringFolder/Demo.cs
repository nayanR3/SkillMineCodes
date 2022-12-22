using System;

namespace SkillMineCodes.StringFolder
{
    class Demo1
    {
        static void Main(string[] args)
        {
            string str1 = "Hello to all";
            Console.WriteLine(str1.Length);
            string str2 = "welcome to C#";

            //str1.Concat(str2);
            string str = String.Concat(str1, str2);
            Console.WriteLine (str);
            Console.WriteLine (str2);
            bool result = str1.StartsWith("Hello");
            Console.WriteLine (result);
            bool res = str1.EndsWith("everyone");
            bool r = str1.Contains("to");
            Console.WriteLine (r);
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());
            char[] ch = str1.ToCharArray();
            foreach (var item in ch)
            {
                Console.WriteLine (item);
            }
            str1.Trim();
        }
    }

    class Demo2
    {
        static void Main(string[] args)
        {
            string str1 = "Test";
            string str2 = "TEst";
            int a = String.Compare(str1, str2);
            Console.WriteLine (a); // -1 0 1
            // it will compare using ASCII value
            // a- 97 b-98 c-99 d-100 e-101 A- 65
            // e- 101 E- 69
            // 69-101 --> - value
        }
    }

    class Demo3
    {
        static void Main(string[] args)
        {
            string str1 = null;

            string str2 = "TEst";
            int a = String.Compare(str1, str2);
            Console.WriteLine (a); // -1 0 1
            bool res = str1.Equals(str2);
            Console.WriteLine (res);
            bool r1 = String.IsNullOrEmpty(str1);
            Console.WriteLine (r1);
        }
    }

    class Demo4
    {
        static void Main(string[] args)
        {
            string str1 = "test";
            string str2 = str1;
            char[] ch = { 't', 'e', 's', 't' };

            // string str3 = new string(ch);
            object str3 = new String(ch);
            Console.WriteLine (str3);
            bool res = str1.Equals(str3); // focus on content
            Console.WriteLine (res);
            if (
                str1 == str3 // focus on data type
            )
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}
