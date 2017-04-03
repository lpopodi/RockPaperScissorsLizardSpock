using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Player PlayerOne;
        Player PlayerTwo;
        Player PlayerComputer;
        public int playerOneScore;
        public int playerTwoScore;
        public int score;
        public string name;
        public int choice;
        public int computerSelection;

        public Game()
        {


        }
        public void StartGame()
        {
            Welcome();
            GamePlayers();
            for (int i = 0; i < 3; i++) // it will be  three games
            {
                PlayerOne.GetOptionChoice();
                PlayerTwo.GetOptionChoice();
                Draw();
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Spock Lizard");
        }

        private void GamePlayers()
        {
            Console.WriteLine("\nChoose A Game:\n1. Play Against Computer\n2. Play Another Person");
            string response = (Console.ReadLine());
            switch (response)
            {
                case "1":
                    PlayerOne = new Human();
                    PlayerTwo = (PlayerComputer = new computer());
                    PlayerOne.GetName();
                    break;
                case "2":
                    PlayerOne = new Human();
                    PlayerTwo = new Human();
                    PlayerOne.GetName();
                    PlayerTwo.GetName();
                    break;
                default:
                    Console.WriteLine("Invalid entry");
                    GamePlayers();
                    break;
            }

        }



        public void Draw() //based on the algorithm from link provided
        {

            int result = (5 + (PlayerOne.choice - PlayerTwo.choice)) % 5;
            if (result == 1 || result == 3)
            {//announce winner and add point to winner
                Console.WriteLine("Player 1 wins!");
                PlayerOne.score++;
                if (PlayerOne.score == 2)

                {
                    Console.WriteLine("Player 1 wins the game!");
                }
                //if a = 1 or 3, player one wins 
            }
            if (result == 2 || result == 4)
            {
                Console.WriteLine("Player 2 wins!");
                Console.WriteLine("Computer wins!");
                PlayerTwo.score++;
                if (PlayerTwo.score == 2)

                {
                    Console.WriteLine("Player 2 wins the game!");
                    Console.WriteLine("Computer wins the game!");
                }
                //if b = 2 or 4, player two wins
            }
            else if (result == 0)
            {
                Console.WriteLine("Players tied. Play round again");
            }
            
            Console.WriteLine(PlayerOne.name + " score: " + PlayerOne.score);
            Console.WriteLine(PlayerTwo.name + " score: " + PlayerTwo.score);
            Console.ReadLine();
        }//end draw



    }//end game
}//end namespace
