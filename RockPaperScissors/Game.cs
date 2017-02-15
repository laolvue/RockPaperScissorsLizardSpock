using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Person player1;
        Person player2;
        Ai ai;

        public Game()
        {
            player1 = new Person();
            player2 = new Person();
            ai = new Ai();
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to \"Rock Paper Scissors Lizard Spock\" the game!");
        }

        public int PromptNumberOfPlayers()
        {
            Console.WriteLine("Enter the game mode you would like to play: 1 = Player vs AI\t\t2 = Player vs Player");
            int gameMode = int.Parse(Console.ReadLine());
            return (gameMode);
        }

        public void PromptNames(int gameMode)
        {
            if (gameMode == 1)
            {
                player1.PromptPlayerName();
            }
            else if (gameMode == 2)
            {
                player1.PromptPlayerName();
                player2.PromptPlayerName();
            }
        }

        public void StartRound(int gameMode)
        {
            Console.WriteLine("\nThe Game is starting!\n1: Scissors\t2: Paper\t3: Rock\n4: Lizard\t5: Spock");
            if (gameMode == 1)
            {
                player1.PlayerChoice();
                ai.AiChoice();
            }
        }


        public void RunGame()
        {
            DisplayRules();
            int gameMode = PromptNumberOfPlayers();
            PromptNames(gameMode);
            StartRound(gameMode);
        }


    }
}
