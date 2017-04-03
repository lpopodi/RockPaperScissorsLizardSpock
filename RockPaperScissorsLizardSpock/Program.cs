using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++) // it will be  three games
            {
                Game game = new Game();
                game.StartGame();
            }
        }
    }
}
