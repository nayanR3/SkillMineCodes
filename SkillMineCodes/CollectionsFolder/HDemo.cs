using System;
using System.Collections;

namespace SkillMineCodes.CollectionsFolder
{
    class HDemo1
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "USA");
            hashtable.Add(2, "UK");
            hashtable.Add(91, "IND");
            hashtable.Add(4, "AUS");
            hashtable.Add(7, "KANADA");
            hashtable.Add("Test", 200);
            hashtable.Remove("Test");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
