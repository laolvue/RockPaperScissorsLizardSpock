﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Rock
    {
        public Rock()
        {

        }

        //Method calculates who wins
        public int CalculateWinner(string player1Name, string player2Name, int player2Choice)
        {
            switch (player2Choice)
            {
                case 1:
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Scissor\n{player1Name} wins this round");
                    return 1;
                case 2:
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Paper\n{player2Name} Wins this round!");
                    return 2;
                case 3:
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Rock\nIt's a tie!");
                    return 0;
                case 4:
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Lizard\n{player1Name} wins this round");
                    return 1;
                case 5:
                    Console.WriteLine($"\n{player1Name}: Rock\n{player2Name}: Spock\n{player2Name} Wins this round");
                    return 2;
                default:
                    return 3;
            }
        }
    }
}