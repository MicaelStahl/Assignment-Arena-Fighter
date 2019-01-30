using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Arena_Fighter
{
    class Round
    {
        static Character CreateAttributes()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);

            int CharStrength = random.Next(1, 9);
            int CharDamage = random.Next(1, 7);
            int CharHealth = random.Next(1, 9);

            return new Character(CharStrength, CharDamage, CharHealth);

        }
    }

}
