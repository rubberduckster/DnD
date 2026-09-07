using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public class Monster : IDamagable
    {
        public string Name { get; }
        public int Level { get; }
        public int MaxHealth { get; }
        public int CurrentHealth { get; private set; }
        public bool IsDefeated
        {
            get
            {
                return CurrentHealth <= 0;
            }
        }

        public Monster(string name, int level, int maxHealth)
        {
            Name = name;
            Level = level;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(int amount)
        {
            CurrentHealth -= amount;
            if (CurrentHealth < 0)
            {
                CurrentHealth = 0;
            }
        }

        public void Attack(IDamagable target)
        {
            int damage = Level * 2;
            target.TakeDamage(damage);
        }

    }
}
