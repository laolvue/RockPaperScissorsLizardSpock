using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RockPaperScissorsLizardSpock
{
    public class Game
    {
        Person player1;
        Person player2;
        Ai ai;
        Scissor scissor;
        Paper paper;
        Rock rock;
        Lizard lizard;
        Spock spock;
        public int playerPick;
        public int player2Pick;
        public string player2Name;
        public string player1Name;
        public int player1Points;
        public int player2Points;
        Regex numbers = new Regex(@"^[0-9]*$");

        public Game(int test)
        {

        }
        public Game()
        {
            this.player1 = new Person();
            this.player2 = new Person();
            this.ai = new Ai();
            this.scissor = new Scissor();
            this.paper = new Paper();
            this.rock = new Rock();
            this.lizard = new Lizard();
            this.spock = new Spock();
            this.player1Points = 0;
            this.player2Points = 0;
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to \"Rock Paper Scissors Lizard Spock\" the game!");
        }

        public int PromptNumberOfPlayers()
        {
            int gameMode, i=0;
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Invalid entry. Try again.\n");
                }
                gameMode = PromptInputNumber("Enter the game mode you would like to play: 1 = Player vs AI\t\t2 = Player vs Player", TestNumber);
                i++;
            } while (gameMode == 0 || gameMode>2);
            
            return gameMode;
        }
        public bool TestNumber(string input)
        {
            bool sts = numbers.IsMatch(input);
            if (sts && input != "")
            {
                return (true);
            }
            else
                Console.WriteLine("Invalid entry. Try again.\n");
                return (false);
        }

        public int PromptInputNumber(string input, Func<string,bool> test)
        {
            string userInput;
            do
            {
                Console.WriteLine(input);
                userInput = Console.ReadLine();
            } while (!test(userInput));
            int gameMode = int.Parse(userInput);
            return gameMode;
        }

        public void PromptNames(int gameMode)
        {
            if (gameMode == 1)
            {
                player1Name = player1.PromptPlayerName(1);
                player2Name = "Ai";
            }
            else if (gameMode == 2)
            {
                player1Name = player1.PromptPlayerName(1);
                player2Name = player2.PromptPlayerName(2);

            }
        }

        public void StartRound(int gameMode)
        {
            Console.WriteLine("\nThe Game is starting!\n1: Scissors\t2: Paper\t3: Rock\n4: Lizard\t5: Spock");
            if (gameMode == 1)
            {
                playerPick = player1.PlayerChoice(player1Name);
                player2Pick = ai.AiChoice();
            }
            else if (gameMode == 2)
            {
                playerPick = player1.PlayerChoice(player1Name);
                player2Pick = player2.PlayerChoice(player2Name);

            }
        }

        public int DetermineWinner(int player1Pick)
        {
            switch (player1Pick)
            {
                case 1: return scissor.CalculateWinner(player1Name,player2Name,player2Pick);
                case 2: return paper.CalculateWinner(player1Name, player2Name, player2Pick);
                case 3: return rock.CalculateWinner(player1Name, player2Name, player2Pick);
                case 4: return lizard.CalculateWinner(player1Name, player2Name, player2Pick);
                case 5: return spock.CalculateWinner(player1Name, player2Name, player2Pick);
                default: Console.WriteLine("Invalid entry. Try again.\n");
                    return 3;
            }

        }
        
        public int CalculatePoints(int points)
        {
            if (points == 1)
            {
                return player1Points++;
                
            }
            else if(points == 2)
            {
                return player2Points++;
            }
            else
            {
                return 0;
            }
        }

        public void DisplayPoints()
        {
            Console.WriteLine($"\nScoreBoard:\t\t{player1Name}: {player1Points}\t{player2Name}: {player2Points}");
        }

        public int endGame()
        {
            string winner;
            int endOfGame;
            int i = 0;
            if(player1Points == 3)
            {
                winner = player1Name;
            }
            else
            {
                winner = player2Name;
            }
            Console.WriteLine($"\n\n{winner} is the winner!");
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Invalid entry.Try again.\n");
                }
                endOfGame = PromptInputNumber("Would you like to play again? 1= yes\t2= no", TestNumber);
                i++;
            
            } while (endOfGame == 0 || endOfGame > 2);
            
            return endOfGame;
        }
        
        public void RunGame()
        {
            int restart;

            do
            {
                DisplayRules();
                int gameMode = PromptNumberOfPlayers();
                PromptNames(gameMode);

                while (player1Points < 3 && player2Points < 3)
                {
                    StartRound(gameMode);
                    int points = DetermineWinner(playerPick);
                    CalculatePoints(points);
                    DisplayPoints();
                }

                restart = endGame();
                player1Points = 0;
                player2Points = 0;
            } while (restart == 1);
            
        }
    }
}
