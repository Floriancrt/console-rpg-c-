using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Game
    {
        Player player;
        Monster m;


        public Game()
        {
            player = new Player("John");
            m = new Monster(50, 5);
            Run();
        }

        private void Run()
        {
            while (player.hp > 0 && m.hp > 0)
            {
                Console.WriteLine("Player: " + player.hp + " hp");
                Console.WriteLine("Monster: " + m.hp + " hp");
                Console.ReadLine();
                player.receiveAttack(m);
                m.receiveAttack(player);
            }
            if (m.hp <= 0)
                Console.WriteLine("You win!");
            else
                Console.WriteLine("You lose...");
        }
    }
}
