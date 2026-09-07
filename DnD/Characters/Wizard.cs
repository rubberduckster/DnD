using DnD.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public class Wizard : Character, ISpellcaster
    {
        public int Mana { get; private set; }

        public Wizard(
            string name, 
            int level, 
            int maxHealth, 
            int mana) 
            : base(name, level, maxHealth)
        {
            Mana = mana;
        }

        public override void Attack(IDamagable target)
        {
            int damage = BaseDamage;
            target.TakeDamage(damage);
        }

        public void CastSpell(IDamagable target)
        {
            int manaCost = 10;

            if (Mana < manaCost)
            {
                throw new InsufficientManaException(
                    $"{Name} doesn't have enough mana!"
                );
            }

            Mana -= manaCost;

            int damage = BaseDamage + Level * 2;
            target.TakeDamage(damage);
        }

        public void RestoreMana(int amount)
        {
            Mana += amount;
        }
    }
}
