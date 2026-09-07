using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Items
{
    public abstract class Item
    {

        // Properties for the Item class
        //incapsulate the name and value of the item, so they can be accessed and modified from outside the class
        public string Name { get; set; }
        public int Value { get; set; }


        // Constructor for the Item class
        //så her giver parmiter for at skabe et item med navn og værdi
        protected Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

    }
}
