using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RockPaperScissorsLizardSpock
{
    public class Person: Players //inherit methods and member variables from Players class
    {
        
        //constructor
        public Person()
        {

        }
        
        //Prompts player names
        public override void PromptPlayerName(int playerNumber)
        {
            base.PromptPlayerName(playerNumber);
        }


        //prompts player choice
        public override void PlayerChoice(string playerName)
        {
            base.PlayerChoice(playerName);
        }

        //calculate points for each player
        public override void CalculatePoints(int points)
        {
            base.CalculatePoints(points);
        }

    }
}