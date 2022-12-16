using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.HW.Dec15
{
    public class GenericsHashTableDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("phy", 70);
            d1.Add("chem", 77);
            d1.Add("bio", 55);
            d1.Add("maths", 60);

            Console.WriteLine("dictionary");

            foreach (KeyValuePair<string, int> i in d1)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            


        }
    }
}
