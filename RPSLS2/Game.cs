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
            
        }

        //membermethods
    
            // choose your players
        public void ChoosePlayers()
        {
            Console.WriteLine("Enter '1' for Single Player or Enter '2' for Two Players");
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
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

            // length of game
        public void LengthOfGame()
        {
            Console.WriteLine("Please Select Length Of Match");
            Console.WriteLine("Enter '3' For Best Of 'THREE' Match");
            Console.WriteLine("Enter '5' For Best Of 'FIVE' Match");
            Console.WriteLine("Enter '7' For Best Of 'SEVEN' Match");
            string matchLength = Console.ReadLine();
            switch (matchLength)
            {
                case "3":
                    winningScore = 2;
                    Console.WriteLine("This Match Is Set For A Best 2 Out Of 3");
                    break;

                case "5":
                    winningScore = 3;
                    Console.WriteLine("This Match Is Set For A Best 3 Out Of 5");
                    break;

                case "7":
                    winningScore = 4;
                    Console.WriteLine("This Match Is Set For A Best 4 Out Of 7");
                    break;

                default:
                    Console.WriteLine("\nPlease Try again");
                    LengthOfGame();
                    break;
            }
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
                Console.WriteLine("\n" + playerOne.name + " Won This Round and Scored '1' Point");
                playerOnePoint++;
            }
            else
            {
                Console.WriteLine("\n" + playerTwo.name + " Won This Round and Scored '1' Point");
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
                Console.WriteLine("\n----------" + playerOne.name + "----------");
                Console.WriteLine("\n----------Wins The Match----------");
            }
            else if (playerTwoPoint > 1)
            {
                Console.WriteLine("\n----------" + playerTwo.name + "----------");
                Console.WriteLine("\n----------Wins The Match----------");
            }
        }

            // restart match yes no
        public void MatchReset()

        {
            Console.WriteLine("\n----------Would you like To Play Again?----------");
            Console.WriteLine("\n----------Type '1' for Yes or '2' for no----------");
            string matchResetYesNo = Console.ReadLine();
            switch (matchResetYesNo)
            {
                case "1":
                    playerOnePoint = 0;
                    playerTwoPoint = 0;
                    BeginGame();
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nPlease Try again");
                    MatchReset();
                    break;
            }
        }

             // start game
        public void BeginGame()
        {

            Console.Clear();
            do
            {
                ChoosePlayers();
                LengthOfGame();
                while (playerOnePoint < winningScore && playerTwoPoint < winningScore)
                {
                    
                    Console.WriteLine("\n" + playerOne.name + " Choose Your Play");
                    playerOne.ChooseOption();
                    Console.Clear();
                    Console.WriteLine("\n" + playerTwo.name + " Choose Your Play");
                    playerTwo.ChooseOption();
                    

                    ScoreWinningThrow();
                    ScoreOfMatch();
                    
                }
                FindWinnerOfMatch();
                MatchReset();
            }
            while (playerOnePoint == 0 && playerTwoPoint == 0);
        }
        }
}
