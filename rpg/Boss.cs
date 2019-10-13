using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Boss : Entity
    {
        string name;

        Random random = new Random();

        public Boss(int hp, int dp) : base(hp, dp)
        {

        }

        public void receiveAttack(Entity attacker)
        {
            int alea = random.Next(1, 10);
            this.hp -= alea;
            if (this.hp < 0)
                this.hp = 0;
        }
    }
}
