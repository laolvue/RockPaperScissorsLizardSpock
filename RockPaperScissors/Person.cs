using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RockPaperScissorsLizardSpock
{
    public class Person
    {
        Game personGame;

        //class that validates user input is a letter or number
        Regex letters;
        public Person()
        {
            personGame = new Game(0);
            letters = new Regex(@"^[a-zA-Z0-9 ]*$");
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
            bool sts = letters.IsMatch(playerName);
            if (sts && playerName != "")
            {
                return (true);
            }
            else
                return (false);
        }

        
        //Prompts player names
        public string PromptPlayerName(int playerNumber)
        {
            string playerName = PromptInputLetters($"\nEnter Player {playerNumber} name: ", TestLetters);
            return playerName;
        }


        //prompts player choice
        public int PlayerChoice(string playerName)
        {
            int choice,i=0;
            do
            {
                if (i > 0)
                {
                    Console.WriteLine("Invalid entry.Try again.\n");
                }
                choice = personGame.PromptInputNumber($"{playerName}, please enter your choice: ", personGame.TestNumber);
                i++;

            } while (choice == 0 || choice > 5);
            return (choice);
        }
    }
}