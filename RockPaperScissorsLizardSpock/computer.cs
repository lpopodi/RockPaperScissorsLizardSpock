using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class computer : Player
    {

        public computer()
        {
            name = "computer";
        }
        public override void GetOptionChoice()

        {
            base.GetOptionChoice();
            Random random = new Random(choice);
            choice = random.Next(0, 5);
            Console.WriteLine($"Computer chose {choice}");

        }
    }
}
