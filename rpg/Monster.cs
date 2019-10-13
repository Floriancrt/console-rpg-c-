using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Monster : Entity
    {

        Random random = new Random();

        public Monster(int hp, int dp) : base(hp, dp)
        {

        }

        public void receiveAttack(Entity attacker)
        {
            int alea = random.Next(5, 20);
            this.hp -= alea;
            if (this.hp < 0)
                this.hp = 0;
        }
    }
}
