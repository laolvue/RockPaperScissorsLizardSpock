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

        Regex letters = new Regex(@"^[a-zA-Z ]*$");
        public Person()
        {

        }
        

        public bool numbers(string playerName)
        {
            bool sts = letters.IsMatch(playerName);
            Console.WriteLine(playerName);
            if (sts && playerName != "")
            {
                return (true);
            }
            else
                return (false);
        }

        public string prompty(string name, Func<string,bool> numb)
        {
            string playerName;
            do
            {
                Console.Write(name);
                playerName = Console.ReadLine();
            } while (!numb(playerName));
            return playerName;
        } 


        public string PromptPlayerName(int playerNumber)
        {
            string playerName = prompty($"\nEnter Player {playerNumber} name: ", numbers);
            return playerName;
        }


        public int PlayerChoice(string playerName)
        {
            Console.Write($"{playerName}, please enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return (choice);
        }
    }
}
