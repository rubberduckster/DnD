using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Items
{
    internal class Armor : Item
    {
        public int Defanse { get; set; }

        public Armor(string name, int value, int defanse) : base(name, value)
        {
            Defanse = defanse;
        }
    }
}
