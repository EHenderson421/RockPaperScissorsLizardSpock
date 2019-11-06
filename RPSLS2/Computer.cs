using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS3
{
   class Computer : Player
    {
        public Computer()
        {
            name = "Dr. Cooper";
        }

        public override void GetPlayerName()
        {

        }

        public override void DisplayPlayerName()
        {
            Console.WriteLine("\nWelcome to the game " + name);
        }

        public override void ChooseOption()
        {
            Random random = new Random();
            possibleMove = choice[random.Next(0, choice.Count)];
            Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
        }

    }
}
