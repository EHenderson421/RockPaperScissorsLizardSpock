using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    
    class Computer : Player
    {
        //member variable
        
        
        // constructor
        public Computer()
        {
            name = "Dr. Cooper";
        }

        //member methods
        public override void GetPlayerName()
        {
           

           // name = "Dr. Cooper";

        }

        public override void DisplayPlayerName()
        {
            Console.WriteLine("\nWelcome to the game " + name);
        }




        public override void ChooseOption()
        {
            Random random = new Random();

            possibleMove = choice[random.Next(0, 5)];
            Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
        }

    }
}
