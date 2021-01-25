using System;

namespace Uppgift_09_Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int playerWinCount;
            int computerWinCount;

            Console.WriteLine("This is a game of rock paper scissors between you and the computer!");
            System.Console.Write("Write your choice between the three options: ");
            choice = Console.ReadLine();

            while (choice.ToLower() != "rock" && choice.ToLower() != "paper" && choice.ToLower() != "scissors")
            {
                System.Console.WriteLine("Your answer was invalid, try again and make sure you spelled it right. ");
                choice = Console.ReadLine();
            }

            Console.Clear();

            System.Console.WriteLine("Your choice: " + choice);
            System.Console.WriteLine("The computers choice: " + ComputersChoice());



            Console.ReadKey();
        }

        static string ComputersChoice()
        {
            string choice;
            Random random = new Random();
            int randomNumber = random.Next(0,3);

            switch (randomNumber)
            {
                case 0:
                    choice = "rock";
                    break;

                case 1:
                    choice = "paper";
                    break;

                case 2: 
                    choice = "scissors";
                    break;

                default:
                    choice = null;
                    break;
            }

            return choice;
        }

        static int PlayerWins(string playerChoice, string computerChoice)
        {
            int winnerNumber;

            // All the different ways for the player to win
            if (playerChoice.ToLower() == "rock" && computerChoice.ToLower() == "scissors" || 
            playerChoice.ToLower() == "paper" && computerChoice.ToLower() == "rock" ||
            playerChoice.ToLower() == "scissors" && computerChoice.ToLower() == "paper")
            {
                winnerNumber = 1;
            }

            // All the different ways for the computer to win
            else if (playerChoice.ToLower() ==  "rock" && computerChoice.ToLower() == "paper" || 
            playerChoice.ToLower() == "paper" && computerChoice == "scissors" ||
            playerChoice.ToLower() == "scissors" && computerChoice.ToLower() == "rock")
            {
                winnerNumber = 2;
            }

            // The remaining options are ties
            else
            {
                winnerNumber = 3;
            }
            
            return winnerNumber;
        }
    }
}
