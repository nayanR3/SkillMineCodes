﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMineCodes.OOPS
{
    /*Create class Book with id, name, author & price(use properties, do not use constructor)*/
    public class Book
    {
        private int id;
        private string name;
        private string author;
        private int price;


        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, \nName : {Name}, \nAuthor : {Author}, \nPrice : {Price}";
        }
    }
}