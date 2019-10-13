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
            do
            {
                Game g = new Game();
                Console.WriteLine("Voulez-vous rejouer ? (o/n)");
            } while (Console.ReadLine() == "o");
        }
    }
}
