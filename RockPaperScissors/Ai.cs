using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Ai
    {
        public Random randomizeChoice;//randomize class
        public Ai()
        {
            randomizeChoice = new Random();
        }

        //randomizes a number between 1 and 6; this will be AI choice
        public int AiChoice()
        {
            int choice = randomizeChoice.Next(1, 6);
            return(choice);
        }

    }
}
