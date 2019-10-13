using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace RPG
{
    class Game
    {
        Player player;
        Monster m;
        Boss b;
        Random random = new Random();




        
        public Game(int Num)
        {
            
            Console.Write("Quel votre prénom ==> ");
            string pseudo = Console.ReadLine();
            Console.WriteLine("=============== \n");
            Console.WriteLine("Veuillez choisir votre lieu \n");
            Console.WriteLine("1 - Terre \n");
            Console.WriteLine("2 - Lune \n");
            Console.WriteLine("3 - Mars \n");

            Console.Write("Votre choix :  ");
            
            string location = Console.ReadLine();

            switch (location)
            {
                case "1":

                    Console.WriteLine("Bonjour " + pseudo + ", bienvenue sur Terre", Environment.NewLine);
                    break;

                case "2":
                    Console.WriteLine("Bonjour " + pseudo + ", bienvenue sur la Lune", Environment.NewLine);
                    break;

                case "3":
                    Console.WriteLine("Bonjour " + pseudo + ", Bienvenue sur Mars", Environment.NewLine);
                    break;

            }

            if (Num ==1)
            {
                player = new Player(pseudo);
                m = new Monster(100, 10);
                MonsterGame(pseudo);
                string line = Console.ReadLine(); // Get string from user
                
            }
            else
            {
                player = new Player(pseudo);
                b = new Boss(100, 10);
                BossGame(pseudo);
            }

            
            
        }

        
        
        
        
        private void MonsterGame(string pseudo)
        {

            int count = 0;

            
            while (player.hp > 0 && m.hp > 0)
            {

                Console.WriteLine($"{pseudo} : {player.hp} hp");
                Console.WriteLine("Monster: " + m.hp + " hp");
                Console.ReadLine();
                player.receiveAttack(m);
                m.receiveAttack(player);
                Console.WriteLine("===============");



                if (player.hp <= 40 && count == 0)
                {
                    
                    int r = random.Next(1, 30);
                    int perliusPV = random.Next(1, 30);
                    int meliaPV = random.Next(1, 20);
                    int floraPV = random.Next(10,25);

                    Console.WriteLine("===============");
                    Console.WriteLine("Vous voulez: ");
                    Console.WriteLine("1 - Reprendre");
                    Console.WriteLine("2 - Allez à la base");
                    Console.WriteLine("3 - Allez à la boutique");
                    Console.WriteLine("4 - Quitter");

                    Console.Write("Votre choix :  ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {


                        case "1":

                            count = count + 1;
                            continue;

                        case "2":

                            Console.WriteLine("Vous aviez " + player.hp + " points, et vous avez gagné " + r + " points");
                            player.hp = player.hp + r;
                            count = count + 1;
                            continue;
                        case "3":

                            Console.WriteLine("Vous prenez quelle potion ?");
                            Console.WriteLine("1/ perlius");
                            Console.WriteLine("2/ melia");
                            Console.WriteLine("3/ flora");

                            Console.Write("Votre choix :  ");

                            string answer = Console.ReadLine();

                            switch (answer)
                            {
                                case "1":
                                    if(perliusPV < 15)
                                    {
                                        Console.WriteLine("Vous aviez "+player.hp+" points, Dommage vous n'avez gagné que " + perliusPV + " points");
                                        player.hp = player.hp + perliusPV;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Bravo vous avez gagné " + perliusPV + " points");
                                        player.hp = player.hp + perliusPV;
                                    }
                                    count = count + 1;
                                    continue;

                                case "2":
                                    if (meliaPV < 10)
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Dommage vous n'avez gagné que " + meliaPV + " points");
                                        player.hp = player.hp + meliaPV;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Bravo vous avez gagné " + meliaPV + " points");
                                        player.hp = player.hp + meliaPV;
                                    }
                                    count = count + 1;
                                    continue;

                                case "3":
                                    if (floraPV < 17)
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Dommage vous n'avez gagné que " + floraPV + " points");
                                        player.hp = player.hp + floraPV;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Bravo vous avez gagné " + floraPV + " points");
                                        player.hp = player.hp + floraPV;
                                    }
                                    count = count + 1;
                                    continue;
                            }
                            count = count + 1;
                            continue;


                        case "4":

                            Environment.Exit(0);
                            break;

                    }

                }
 
            }
            if (m.hp <= 0)
                Console.WriteLine("T'a gagné !!!");
            else
                Console.WriteLine("Loser :(");

             
               
            

            

        }

    


        private void BossGame(string pseudo)
        {

            int count = 0;

            while (player.hp > 0 && b.hp > 0)
            {
                Console.WriteLine($"{pseudo} : {player.hp} hp");
                Console.WriteLine("Boss : " + b.hp + "hp");
                Console.ReadLine();
                player.receiveAttack(b);
                b.receiveAttack(player);

                if (player.hp <= 40 && count == 0)
                {
                    int r = random.Next(1, 20);
                    int perliusPV = random.Next(1, 30);
                    int meliaPV = random.Next(1, 20);
                    int floraPV = random.Next(10,25);

                    Console.WriteLine("===============");
                    Console.WriteLine("Vous voulez: ");
                    Console.WriteLine("1 - Reprendre");
                    Console.WriteLine("2 - Allez à la base");
                    Console.WriteLine("3 - Allez a la boutique");
                    Console.WriteLine("4 - Quitter");

                    Console.Write("Votre choix :  ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {


                        case "1":

                            count = count + 1;
                            continue;

                        case "2":


                            Console.WriteLine("Vous aviez "+player.hp+ " points, et vous avez gagné " + r + " points");
                            player.hp = player.hp + r;
                            count = count + 1;
                            continue;
                        case "3":

                            Console.WriteLine("Vous prenez quelle potion ?");
                            Console.WriteLine("1/ perlius");
                            Console.WriteLine("2/ melia");
                            Console.WriteLine("3/ flora");
                            string answer = Console.ReadLine();

                            switch(answer)
                            {
                                case "1":
                                    if (perliusPV < 15)
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Dommage vous n'avez gagné que " + perliusPV + " points");
                                        player.hp = player.hp + perliusPV;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Bravo vous avez gagné " + perliusPV + " points");
                                        player.hp = player.hp + perliusPV;
                                    }
                                    count = count + 1;
                                    continue;

                                case "2":
                                    if (meliaPV < 10)
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Dommage vous n'avez gagné que " + meliaPV + " points");
                                        player.hp = player.hp + meliaPV;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Bravo vous avez gagné " + meliaPV + " points");
                                        player.hp = player.hp + meliaPV;
                                    }
                                    count = count + 1;
                                    continue;

                                case "3":
                                    if (floraPV < 17)
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Dommage vous n'avez gagné que " + floraPV + " points");
                                        player.hp = player.hp + floraPV;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vous aviez " + player.hp + " points, Bravo vous avez gagné " + floraPV + " points");
                                        player.hp = player.hp + floraPV;
                                    }
                                    count = count + 1;
                                    continue;
                            }
                            count = count + 1;
                            continue;

                        case "4":

                            Environment.Exit(0);
                            break;

                    }

                }




            }



            if (b.hp <= 0)
                Console.WriteLine("T'a gagné !!!");
            else
                Console.WriteLine("Loser :(");
        }
    }
}
