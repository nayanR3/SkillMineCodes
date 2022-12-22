using System;

namespace SkillMineCodes.StringFolder
{
    class Demo1
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine (sb);
            sb.Append("welcome to session");
            Console.WriteLine (sb);

            //sb.Remove(0, 4);
            //Console.WriteLine(sb);
            //sb.Clear();
            sb.Replace("all", "everyone");
            Console.WriteLine (sb);
            double price = 45000;
            sb.AppendFormat("price is {0:C}", price);
            Console.WriteLine (sb);
        }
    }

    class Demo2
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello to all");
            Console.WriteLine($"{sb} --> {sb.GetHashCode()}");
            sb.Append("welcome to session");
            Console.WriteLine($"{sb} --> {sb.GetHashCode()}");
            Console.WriteLine("----------string-----------");
            string str = "Hello to all";
            Console.WriteLine($"{str} --> {str.GetHashCode()}");
            str = str + "welcome to session";
            Console.WriteLine($"{str} --> {str.GetHashCode()}");
        }
    }
}
