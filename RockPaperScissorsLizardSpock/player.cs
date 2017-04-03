using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Player
    {
        public string name;
        public int score;
        public int choice;
        public string optionChoice;
        public int computerChoice;
        public Player()
        {

        }

        public virtual void GetOptionChoice()
        {

        }


        public void GetName()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }

    }
}
