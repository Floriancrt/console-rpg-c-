using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bonjour");
            Console.WriteLine("===============");
            Console.WriteLine("Veuillez choisir votre mode de jeu :");
            Console.WriteLine("1 : Contre les monstres");
            Console.WriteLine("2 : Contre le boss");

            string choiceEnemies = Console.ReadLine();

            switch(choiceEnemies)
            {
                case "1":
                    do
                    {
                        Game g = new Game(1);
                        Console.WriteLine("Voulez-vous rejouer ? (o/n)");
                    } while (Console.ReadLine() == "o");

                    break;

                case "2":

                    do
                    {
                        Game g = new Game(2);
                        Console.WriteLine("Voulez-vous rejouer ? (o/n)");
                    } while (Console.ReadLine() == "o");

                    break;


            }


            
        }
    }
}
