using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public class Rogue : Character
    {
        public int CriticalDamage { get; }

        private IDiceRoller diceRoller;

        public Rogue(
            string name,
            int level,
            int maxHealth,
            int criticalDamage,
            IDiceRoller diceRoller)
            : base(name, level, maxHealth)
        {
            CriticalDamage = criticalDamage;
            this.diceRoller = diceRoller;
        }

        public override void Attack(IDamagable target)
        {
            int bonusDamage = diceRoller.Roll(CriticalDamage);

            int damage = BaseDamage + bonusDamage;

            target.TakeDamage(damage);
        }
    }
}
