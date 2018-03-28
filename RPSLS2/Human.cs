using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Human : Player
    {
        public Human()
        {
        
        }

        public override void GetPlayerName()
        {
            Console.WriteLine("\nPlease Enter Your Name.");
            string userInput = Console.ReadLine();
            name = userInput;
        }
        
        public override void DisplayPlayerName()
        {
            Console.WriteLine("\nWelcome to the game " + name);
        }

        public override void ChooseOption()
        {
            Console.WriteLine("\nYour choices are: '1' Rock, '2' Paper, '3' Scissors, '4' Lizard, '5' Spock,");
            possibleMove = Console.ReadLine();
            switch (possibleMove)
            {
                case "1":
                    possibleMove = choice[(0)];
                    Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
                    break;

                case "2":
                    possibleMove = choice[(1)];
                    Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
                    break;

                case "3":
                    possibleMove = choice[(2)];
                    Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
                    break;

                case "4":
                    possibleMove = choice[(3)];
                    Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
                    break;

                case "5":
                    possibleMove = choice[(4)];
                    Console.WriteLine("\n" + name + " Has Decided To Throw: " + possibleMove);
                    break;

                default:
                    Console.WriteLine("\nPlease Try again");
                    ChooseOption();
                    break;
            }
        }
    }
}
