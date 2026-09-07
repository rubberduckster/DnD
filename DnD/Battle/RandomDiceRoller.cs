using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD.IDiceRoller
{
    public class RandomDiceRoller : IDiceRoller
    {
        private readonly Random random = new();

        public int Rolle(int sides)
        {
            // Generate a random number between 1 and the number of sides on the die
            // minimum value is 1, maximum value is sides (inclusive)
            return random.Next(1, sides + 1);
        }
    }
}
