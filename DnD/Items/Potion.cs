using DnD.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DnD.Items
{
    public abstract class Potion : Item
    {

        // Constructor for the Potion class
        public Potion(string name, int value)
            : base(name, value)
        {
        }
    }
}
