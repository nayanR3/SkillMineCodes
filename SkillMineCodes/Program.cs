using System;
using System.Collections;
using System.Text;

namespace SkillMineCodes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayList al= new ArrayList();
            al.Add(1);
            al.Add(2);
            al.Add(3);

            foreach(var i in al)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();


            Hashtable ht = new Hashtable();
            ht.Add(1,1);
            ht.Add(2,2);
            ht.Add(3,3);

            foreach (DictionaryEntry i in ht)
            {
                Console.Write(i.Key + " "+i.Value);
                Console.WriteLine();
            }
            Console.WriteLine();
        }        
    }
}


