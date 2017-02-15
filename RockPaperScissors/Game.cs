using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Person player1;
        Person player2;
        Ai ai;
        Scissor scissor;
        public int player2Choice;


        public Game()
        {
            player1 = new Person();
            player2 = new Person();
            ai = new Ai();
            scissor = new Scissor();
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
                int playerPick = player1.PlayerChoice();
                player2Choice = ai.AiChoice();

            }
        }

        public void DetermineWinner(playerPick)
        {
            switch (playerPick)
            {
                case 1: scissor.CalculateWinner(player2Choice);
                    break;
                case 2:
                case 3:
                case 4:
                case 5:

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
