using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {

        public Human()
        {

        }

        public override void GetOptionChoice()
        {
            base.GetOptionChoice();
            Console.WriteLine("Please choose 0 for Rock, 1 for Paper, 2 for Scissors, 3 for Lizard, or 4 for Spock");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("selected rock");
                    optionChoice = "Rock";
                    break;
                case 1:
                    Console.WriteLine("selected paper");
                    optionChoice = "Paper";
                    break;
                case 2:
                    Console.WriteLine("selected scissors");
                    optionChoice = "Scissors";
                    break;
                case 3:
                    Console.WriteLine("selected lizard");
                    optionChoice = "Lizard";
                    break;
                case 4:
                    Console.WriteLine("selected spock");
                    optionChoice = "Spock";
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;

            }
        }




    }
}
