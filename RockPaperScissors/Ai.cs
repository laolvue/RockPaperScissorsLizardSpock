using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Ai
    {
        public Random randomizeChoice;
        //random.next(1,100);
        public Ai()
        {
            randomizeChoice = new Random();
        }

        public int AiChoice()
        {
            int choice = randomizeChoice.Next(1, 6);
            return(choice);
        }

    }
}
