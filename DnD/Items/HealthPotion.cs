using DnD.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Items
{
    public class HealthPotion : Potion
    {
        public int HealAmount { get; set; }
        public HealthPotion(string name, int value, int healAmount) : base(name, value)
        {
            HealAmount = healAmount;
        }
        public void Use(ICharacter target)
        {

        }
    }
}
