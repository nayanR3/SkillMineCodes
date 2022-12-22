using System;
using System.Collections;

namespace SkillMineCodes.CollectionsFolder
{
    class SLDemo1
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "USA");
            sortedList.Add(2, "UK");
            sortedList.Add(91, "IND");
            sortedList.Add(4, "AUS");
            sortedList.Add(7, "KANADA");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
