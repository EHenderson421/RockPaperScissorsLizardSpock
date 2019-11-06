using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    abstract class Player
    {
        public string name;
        public string possibleMove;
        public List<string> choice;

       public Player()
        {
            choice = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
               
        public abstract void GetPlayerName();
        public abstract void DisplayPlayerName();
        public abstract void ChooseOption();

    }
}
