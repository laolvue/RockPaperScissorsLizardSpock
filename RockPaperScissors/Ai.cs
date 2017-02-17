using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Ai: Players //inherit methods and member variables from Players class
    {
        public Random randomizeChoice;//randomize class

        //constructor
        public Ai()
        {
            randomizeChoice = new Random();
        }

        //sets player 2 name

        public override void PromptPlayerName(int playerNumber)
        {
            player2Name = "Ai Bob";
        }

        //randomizes a number between 1 and 6; this will be AI choice
        public override void PlayerChoice(string playerName)
        {
            player2Pick= randomizeChoice.Next(1, 6);
        }

        //calculate points for each player
        public override void CalculatePoints(int points)
        {
            base.CalculatePoints(points);
        }

    }
}
