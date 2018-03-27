using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Game
    {
        //member variable
        int winningScore;
        public int playerOnePoint;
        public int playerTwoPoint;
        Player playerOne;
        Player playerTwo;


        //constructor
        public Game()
        {
            winningScore = 5;
        }

        //membermethods
            // choose your players
        public void ChoosePlayers()
        {
            Console.WriteLine("Enter '1' for Single Player or Enter '2' for 2 Players");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    playerOne.GetPlayerName();
                    playerOne.DisplayPlayerName();

                    Console.WriteLine("\n---------- " + playerOne.name + " ---------- VS ---------- " + playerTwo.name + " ----------");
                    break;

                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    playerOne.GetPlayerName();
                    playerOne.DisplayPlayerName();
                    playerTwo.GetPlayerName();
                    playerTwo.DisplayPlayerName();

                    Console.WriteLine("\n---------- " + playerOne.name + " ---------- VS ---------- " + playerTwo.name + " ----------");
                    break;

                default:
                    Console.WriteLine("\nPlease Try again");

                    ChoosePlayers();
                    break;
            }
        }

            // players choose a move
        public void ChooseYourPlay()
        {
            // Console.Clear();
            Console.WriteLine("\n" + playerOne.name + " Choose Your Play");
            playerOne.ChooseOption();
            //  Console.Clear();
            Console.WriteLine("\n" + playerTwo.name + " Choose Your Play");
            playerTwo.ChooseOption();
            //  Console.Clear();
        }

            // figure the winner of a throw and score a point
        public void ScoreWinningThrow()
        {
            if ((playerOne.possibleMove == "Rock" && playerTwo.possibleMove == "Rock") || (playerOne.possibleMove == "Paper" && playerTwo.possibleMove == "Paper") || (playerOne.possibleMove == "Scissors" && playerTwo.possibleMove == "Scissors") || (playerOne.possibleMove == "Lizard" && playerTwo.possibleMove == "Lizard") || (playerOne.possibleMove == "Spock" && playerTwo.possibleMove == "Spock"))
            {
                Console.WriteLine("'Pagh' Its a Draw. 0 Points Awarded");
            }
            else if ((playerOne.possibleMove == "Rock" && playerTwo.possibleMove == "Scissors") || (playerOne.possibleMove == "Rock" && playerTwo.possibleMove == "Lizard") || (playerOne.possibleMove == "Paper" && playerTwo.possibleMove == "Rock") || (playerOne.possibleMove == "Paper" && playerTwo.possibleMove == "Spock") || (playerOne.possibleMove == "Scissors" && playerTwo.possibleMove == "Paper") || (playerOne.possibleMove == "Scissors" && playerTwo.possibleMove == "Lizard") || (playerOne.possibleMove == "Lizard" && playerTwo.possibleMove == "Spock") || (playerOne.possibleMove == "Lizard" && playerTwo.possibleMove == "Paper") || (playerOne.possibleMove == "Spock" && playerTwo.possibleMove == "Scissors") || (playerOne.possibleMove == "Spock" && playerTwo.possibleMove == "Rock"))
            {
                Console.WriteLine("\n" + playerOne.name + " Won This Round and Scored 1 Point");
                playerOnePoint++;
            }
            else
            {
                Console.WriteLine("\n" + playerTwo.name + " Won This Round and Scored 1 Point");
                playerTwoPoint++;
            }
        }

            // display total points for players
        public void ScoreOfMatch()
        {
            Console.WriteLine("\n" + playerOne.name + "'s" + " Score is: " + playerOnePoint + "     " + playerTwo.name + "'s" + " Score is: " + playerTwoPoint);
        }

            // find winner of best of three
        public void FindWinnerOfMatch()
        {
            if (playerOnePoint > 1)
            {
                Console.WriteLine("\n----------" + playerOne.name + "----------" + " Wins The Match");
            }
            else if (playerTwoPoint > 1)
            {
                Console.WriteLine("\n----------" + playerTwo.name + "----------" + " Wins The Match");
            }
        }

            // start game
        public void StartGame()
        {

            Console.Clear();
            do
            {
                ChoosePlayers();

                while (playerOnePoint < winningScore && playerTwoPoint < winningScore)
                {
                    playerOne.ChooseOption();
                    playerTwo.ChooseOption();
                    ScoreWinningThrow();
                    ScoreOfMatch();
                }
                FindWinnerOfMatch();
                //RestartGame();
            }
            while (playerOnePoint == 0 && playerTwoPoint == 0);
        }
        }
}
