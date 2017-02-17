using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RockPaperScissorsLizardSpock
{
    public class Players
    {
        public string player1Name;
        public string player2Name;
        public int player1Points;
        public int player2Points;
        public int player1Pick;
        public int player2Pick;
        Regex numbers;
        Regex letters;

        public Players()
        {
            letters = new Regex(@"^[a-zA-Z0-9 ]*$");
            numbers = new Regex(@"^[0-9]*$");
        }

        //prompt player name
        public virtual void PromptPlayerName(int playerNumber)
        {
            if (playerNumber == 1)
            {
                player1Name = PromptInputLetters($"\nEnter Player {playerNumber} name: ", TestLetters);
            }
            else
                player2Name = PromptInputLetters($"\nEnter Player {playerNumber} name: ", TestLetters);
        }


        //prompts player choice
        public virtual void PlayerChoice(string playerName)
        {
            int choice, i = 0;
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Invalid entry.Try again.\n");
                }
                choice = PromptInputNumber($"{playerName}, please enter your choice: ", TestNumber);
                i++;

            } while (choice == 0 || choice > 5);
            if (playerName == player1Name)
            {
                player1Pick = choice;
            }
            else if(playerName == player2Name)
            {
                player2Pick = choice;
            }
        }

        //calculate points for each player
        public virtual void CalculatePoints(int points)
        {
            if (points == 1)
            {
                player1Points++;

            }
            else if (points == 2)
            {
                player2Points++;
            }
        }


        //method to validate user input is a number
        public bool TestNumber(string input)
        {
            bool testedInput = numbers.IsMatch(input);
            if (testedInput && input != "")
            {
                return (true);
            }
            else
                Console.WriteLine("Invalid entry. Try again.\n");
            return (false);
        }

        //method to validate user input is a number, and returns the input if it's true
        public int PromptInputNumber(string input, Func<string, bool> test)
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

        //Method that validates user input is a letter or number, and returns the input if it's true
        public string PromptInputLetters(string name, Func<string, bool> testLetters)
        {
            string playerName;
            do
            {
                Console.Write(name);
                playerName = Console.ReadLine();
            } while (!testLetters(playerName));
            return playerName;
        }

        //Method that validates user input is a letter or number
        public bool TestLetters(string playerName)
        {
            bool testedInput = letters.IsMatch(playerName);
            if (testedInput && playerName != "")
            {
                return (true);
            }
            else
                return (false);
        }





    }
}