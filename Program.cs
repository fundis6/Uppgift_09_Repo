using System;

namespace Uppgift_09_Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;

            Console.WriteLine("This is a game of rock paper scissors between you and the computer!");
            System.Console.Write("Write your choice between the three options: ");
            choice = Console.ReadLine();

            while (choice.ToLower() != "rock" && choice.ToLower() != "paper" && choice.ToLower() != "scissors")
            {
                System.Console.WriteLine("Your answer was invalid, try again and make sure you spelled it right. ");
                choice = Console.ReadLine();    
            }

            Console.ReadKey();
        }
    }
}
