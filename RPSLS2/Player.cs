using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    abstract class Player
    {
        //member variable
        public string name;
        public string possibleMove;
        public Random RandomPossibleMove = new Random();        
        protected List<string> choice;

        //constructor
        public Player()
        {
            choice = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
        
        //member methods
            // call methods for game        
        public abstract void GetPlayerName();
        public abstract void DisplayPlayerName();
        public abstract void ChooseOption();



    }
}
