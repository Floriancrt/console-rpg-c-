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

        public Player(string name) : base(100, 10)
        {
            this.name = name;
        }
    }
}
