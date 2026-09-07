using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public abstract class Character : IDamagable
    {
        public string Name { get; }
        public int Level { get; }
        public int MaxHealth { get; }
        public int CurrentHealth { get; private set; }
        protected int BaseDamage { get; }
        public bool IsDefeated
        {
            get
            {
                return CurrentHealth <= 0;
            }
        }

        private List<Item> Inventory;

        public Character(string name, int level, int maxHealth)
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

        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth)
            {
                CurrentHealth = MaxHealth;
            }
        }

        public abstract void Attack(IDamagable target);

        public void GetInventory()
        {
            Console.WriteLine($"{Name}'s Inventory:");

            foreach (Item item in Inventory)
            {
                Console.WriteLine($"- {item.Name}");
            }
        }

        public void AddToInventory(Item item)
        {
            Inventory.Add(item);
        }

        public void RemoveFromInventory(Item item)
        {
            Inventory.Remove(item);
        }

        //level up method for each monster defeat
    }
}
