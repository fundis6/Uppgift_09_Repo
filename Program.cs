using System;
using System.IO;

namespace Uppgift_09_Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice;
            string computerChoise;
            int winCalculator;
            int playerWinCount = 0;
            int computerWinCount = 0;

            Console.WriteLine("This is a game of rock paper scissors between you and the computer!");
            System.Console.Write("Write your playerChoice between the three options: ");
            playerChoice = Console.ReadLine();

            // Checks to see that a valid answer has been written, otherwise replays till a valid answer is given
            while (playerChoice.ToLower() != "rock" && playerChoice.ToLower() != "paper" && playerChoice.ToLower() != "scissors")
            {
                System.Console.WriteLine("Your answer was invalid, try again and make sure you spelled it right. ");
                playerChoice = Console.ReadLine();
            }

            Console.Clear();
            computerChoise = ComputersChoice();

            System.Console.WriteLine("Your playerChoice: " + playerChoice);
            System.Console.WriteLine("The computers playerChoice: " + computerChoise);

            winCalculator = CalculateResult(playerChoice, computerChoise);


            switch (winCalculator)
            {
                case 1:
                    System.Console.WriteLine("The player wins!");
                    playerWinCount++;
                    break;
                case 2:
                    System.Console.WriteLine("The computer wins");
                    computerWinCount++;
                    break;
                case 3:
                    System.Console.WriteLine("Both chose the same option, it's a tie!");
                    break;

                default:
                break;
            }

            

            Console.ReadKey();
        }

        static string ComputersChoice()
        {
            string playerChoice;
            Random random = new Random();
            int randomNumber = random.Next(0,3);

            switch (randomNumber)
            {
                case 0:
                    playerChoice = "rock";
                    break;

                case 1:
                    playerChoice = "paper";
                    break;

                case 2: 
                    playerChoice = "scissors";
                    break;

                default:
                    playerChoice = null;
                    break;
            }

            return playerChoice;
        }

        static int CalculateResult(string playerChoice, string computerChoice)
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
