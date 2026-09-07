using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public interface IDamagable
    {
        int CurrentHealth { get; }
        bool IsDefeated { get; }

        void TakeDamage(int amount);
    }
}
