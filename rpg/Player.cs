using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Player : Entity
    {
        string name;
        
        Random random = new Random();

        public Player(string name) : base(100, 10)
        {
            this.name = name;
        }

        public void receiveAttack(Entity attacker)
        {
            int alea = random.Next(1, 30);
            this.hp -= alea;
            if (this.hp < 0)
                this.hp = 0;
        }

        
    }
}
