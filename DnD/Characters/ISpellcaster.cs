using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Characters
{
    public interface ISpellcaster
    {
        int Mana { get; }

        void CastSpell(IDamagable target);
        void RestoreMana(int amount);
    }
}
