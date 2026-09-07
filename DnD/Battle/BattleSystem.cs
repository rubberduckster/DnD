using DnD.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.Battle
{
    public class BattleSystem
    {
        // readonly feltet kun kan tildeles en gang enten ved deklarationen eller inde i en constructor.
        // readonly feltet kan ikke ændres efter det er blevet tildelt en værdi.
        private readonly IDiceRoller diceRoller;

        public BattleSystem(IDiceRoller diceRoller)
        {
            this.diceRoller = diceRoller;
        }


        public void StartBattle(Party party, List<Monster> enemies)
        {
            // Implement the battle logic here
        }
        public void RunRound(Party party, List<Monster> monsters)
        {

        }
        public bool IsBattleOver(Party party, List<Monster> monsters)
        {
            // Check if all monsters are defeated
            return false;
        }

        public void PerformAttack(Character attacker, Character target)
        {
            // Implement attack logic here
        }
    }
}
