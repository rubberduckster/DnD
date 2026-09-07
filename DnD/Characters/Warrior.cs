using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public class Warrior : Character
    {
        public int Strength { get; }

        public Warrior(
            string name,
            int level,
            int maxHealth,
            int strength)
            : base(name, level, maxHealth)
        {
            Strength = strength;
        }

        public override void Attack(IDamagable target)
        {
            int damage = BaseDamage + Strength;
            target.TakeDamage(damage);
        }
    }
}