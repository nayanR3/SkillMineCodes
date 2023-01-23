using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMineCodes.ZobinTest.Week_9
{
    public class removeDuplicateFromList
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');
            var listOfInts = s.Select(Int32.Parse).ToList();
            // Console.WriteLine (listOfInts);

            fnc = new(listOfInts);
        }

        public static void fnc(List<int> listOfInts){
            List<int> result = listOfInts.Distinct().ToList();

            foreach(var i in result)
            System.Console.Write(i+" ");
        }
    }
}
