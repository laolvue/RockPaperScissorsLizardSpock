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
        Regex letters = new Regex(@"^[a-zA-Z0-9 ]*$");
        public Person()
        {
            personGame = new Game(0);
        }

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

        public string PromptInputLetters(string name, Func<string,bool> testLetters)
        {
            string playerName;
            do
            {
                Console.Write(name);
                playerName = Console.ReadLine();
            } while (!testLetters(playerName));
            return playerName;
        } 

        public string PromptPlayerName(int playerNumber)
        {
            string playerName = PromptInputLetters($"\nEnter Player {playerNumber} name: ", TestLetters);
            return playerName;
        }
        
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