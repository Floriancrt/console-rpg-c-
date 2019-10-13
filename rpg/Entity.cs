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

        Random random = new Random();
        
        public Entity(int hp, int dp)
        {
            
            this.hp = hp;
            this.dp = dp;
        }

        
    }
}
