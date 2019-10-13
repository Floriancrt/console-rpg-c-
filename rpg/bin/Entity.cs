using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Entity
    {
        public int hp { get; set; }
        public int dp { get; }

        public Entity(int hp, int dp)
        {
            this.hp = hp;
            this.dp = dp;
        }

        public void receiveAttack(Entity attacker)
        {
            this.hp -= attacker.dp;
            if (this.hp < 0)
                this.hp = 0;
        }
    }
}
