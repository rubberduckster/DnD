using DnD.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Items
{
    public class ManaPotion : Potion
    {
        public int ManaAmount { get; set; }

        public ManaPotion(string name, int value, int manaAmount) : base(name, value)
        {
            ManaAmount = manaAmount;
        }
        public void Use(ISpellcaster target)
        {

        }
    }
}
