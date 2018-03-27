using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            //myGame.ChoosePlayers();
            //myGame.ChooseYourPlay();
            //myGame.ScoreWinningThrow();
            //myGame.ScoreOfMatch();
            //myGame.FindWinnerOfMatch();
            myGame.StartGame();
            
            
            // Human myHuman = new Human();
            //myHuman.GetPlayerName();
            //myHuman.DisplayPlayerName();
           // myHuman.ChooseOption();
            // Computer myComputer = new Computer();
           // myComputer.ChooseOption();
            
            Console.ReadLine();
        }
    }
}
