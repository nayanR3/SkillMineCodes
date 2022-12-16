﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.HW.Dec15
{
    public class GenericsSortedListDemo
    {
        static void Main(string[] args)
        {
            SortedList<int,int> sl = new SortedList<int,int>();

            sl.Add(1, 11);
            sl.Add(33, 2);
            sl.Add(678, 9);
            sl.Add(8, 345);
            Console.WriteLine("\nSortedList element");
            foreach (KeyValuePair<int,int> i in sl)
            {
                Console.Write($"key -> {i.Key} & value -> {i.Value}");
                Console.WriteLine();
            }
        }
    }
}
