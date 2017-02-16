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
        //member variables
        Person player;
        Ai ai;
        Scissor scissor;
        Paper paper;
        Rock rock;
        Lizard lizard;
        Spock spock;
        public int playerPick;
        public int player2Pick;
        Regex numbers;

        //constructor
        public Game()
        {
            this.player = new Person();
            this.ai = new Ai();
            this.scissor = new Scissor();
            this.paper = new Paper();
            this.rock = new Rock();
            this.lizard = new Lizard();
            this.spock = new Spock();
            numbers = new Regex(@"^[0-9]*$");
        }

        //constructor
        public Game(int test)
        {

        }

        //display rules
        public void DisplayRules()
        {
            Console.WriteLine("\nWelcome to \"Rock Paper Scissors Lizard Spock\" the game! First player to 3 points first wins! Good Luck.");
        }

        //prompt game mode user wants to play; playervsplayer or playervsAI
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

        //method to validate user input is a number
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

        //method to validate user input is a number, and returns the input if it's true
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

        //prompt player names
        public void PromptNames(int gameMode)
        {
            if (gameMode == 1)
            {
                player.PromptPlayerName(1);
                player.player2Name = "Ai";
            }
            else if (gameMode == 2)
            {
                player.PromptPlayerName(1);
                player.PromptPlayerName(2);

            }
        }

        //prompt for player choices
        public void StartRound(int gameMode)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nThe Game is starting!\n1: Scissors\t2: Paper\t3: Rock\n4: Lizard\t5: Spock");
            Console.ResetColor();
            if (gameMode == 1)
            {
                playerPick = player.PlayerChoice(player.player1Name);
                player2Pick = ai.AiChoice();
            }
            else if (gameMode == 2)
            {
                playerPick = player.PlayerChoice(player.player1Name);
                player2Pick = player.PlayerChoice(player.player2Name);

            }
        }

        //returns winner of each round
        public int DetermineWinner(int player1Pick)
        {
            switch (player1Pick)
            {
                case 1: return scissor.CalculateWinner(player.player1Name, player.player2Name,player2Pick);
                case 2: return paper.CalculateWinner(player.player1Name, player.player2Name, player2Pick);
                case 3: return rock.CalculateWinner(player.player1Name, player.player2Name, player2Pick);
                case 4: return lizard.CalculateWinner(player.player1Name, player.player2Name, player2Pick);
                case 5: return spock.CalculateWinner(player.player1Name, player.player2Name, player2Pick);
                default: Console.WriteLine("Invalid entry. Try again.\n");
                    return 3;
            }

        }


        //display points
        public void DisplayPoints()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nScoreBoard:\t\t{player.player1Name}: {player.player1Points}\t{player.player2Name}: {player.player2Points}");
            Console.ResetColor();
        }

        //prompt the user to end game or play again
        public int endGame()
        {
            string winner;
            int endOfGame;
            int i = 0;
            if(player.player1Points == 3)
            {
                winner = player.player1Name;
            }
            else
            {
                winner = player.player2Name;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n\n{winner} is the winner!");
            Console.ResetColor();
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
        
        //initial method that gets called to run the game
        public void RunGame()
        {
            int restart;
            do
            {
                DisplayRules();
                int gameMode = PromptNumberOfPlayers();
                PromptNames(gameMode);

                while (player.player1Points < 3 && player.player2Points < 3)
                {
                    StartRound(gameMode);
                    player.CalculatePoints(DetermineWinner(playerPick));
                    DisplayPoints();
                }

                restart = endGame();
                player.player1Points = 0;
                player.player2Points = 0;
            } while (restart == 1);

            Environment.Exit(0);
            
        }
    }
}
