using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitJenkinsTest
{
    public class Player
    {
        public int currentHitpoints { get; private set; }

        public Player(int hitpoints)
        {
            currentHitpoints = hitpoints;
        }

        public void receiveDamage(int hitpointsOfDamage)
        {
            if (hitpointsOfDamage < 0)
            {
                return;
            }
            currentHitpoints = (currentHitpoints - hitpointsOfDamage);

            if (currentHitpoints < 0)
            {
                currentHitpoints = 0;
            }
        }
    }
}
