using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Scissor
    {
        public Scissor()
        {

        }


        public void CalculateWinner(player2Choice)
        {
            switch (player2Choice)
            {
                case 1: Console.WriteLine("It's a tie!");
                    break;
                case 2: Console.WriteLine("Player 1 wins this round");
                    break;
                case 3: Console.WriteLine("Ai Wins this round");
                    break;
                case 4: Console.WriteLine("Player 1 Wins this round");
                    break;
                case 5: Console.WriteLine("Ai Wins this round");
                    break;
                default:
                    break;

            }
            
        }


    }
}
