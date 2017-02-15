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
            choice = new Random();
        }

        public void AiChoice()
        {

            int choice = randomizeChoice.Next(1, 6);
            Console.WriteLine(choice);


        }

    }
}
