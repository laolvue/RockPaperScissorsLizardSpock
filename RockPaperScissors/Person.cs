using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Person
    {
        //  public string player1,player2,player1Choice,player2Choice;
        public string playerName;
        public Person()
        {

        }

        public string PromptPlayerName()
        {
            Console.Write($"Enter Player name: ");
            playerName = Console.ReadLine();
            return (playerName);
        }


        public int PlayerChoice()
        {
            Console.Write("Pick one: ");
            int choice = int.Parse(Console.ReadLine());
            return (choice);
        }
        /*
        public string Player2Choice()
        {
            Console.Write("Enter Player 2 name: ");
            string player2 = Console.ReadLine();
            return (player2);
        }*/

    }
}
