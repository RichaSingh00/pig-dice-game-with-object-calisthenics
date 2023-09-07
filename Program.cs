using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenicsPigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play PIG!");
            Console.WriteLine("* See how many turns it takes you to get to 20.");
            Console.WriteLine("* Turn ends when you hold or roll a 1.");
            Console.WriteLine("* If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("* If you hold, you save all points for the turn.");

            int turnScore = 0;
            int totalScore = 0;
            int turnCount = 0;
            bool gameOver = false;
            Random random = new Random();
            while (!gameOver)
            {
                Console.WriteLine("Welcome to the game of PIG!");
                Console.WriteLine("Enter 'r' to roll, 'h' to hold");
                Console.WriteLine("Turn Count:" + turnCount);

                char input = char.ToLower(Console.ReadKey().KeyChar);
                if (input == 'r')
                {
                    int roll = random.Next(1, 7);
                    if (roll == 1)
                    {
                        Console.WriteLine("You rolled: 1");
                        turnCount++;
                    }
                    else
                    {
                        turnScore += roll;
                        Console.WriteLine("You rolled: " + roll);
                        Console.WriteLine("Your turn score is " + turnScore +
                            "and your total score is " + totalScore);
                        turnCount++;
                    }
                }
                else if (input == 'h')
                {
                    totalScore += turnScore;
                    Console.WriteLine("If you hold, you will have " + turnScore);
                    Console.WriteLine("Your turn score is " + turnScore +
                        "and your total score is " + totalScore);
                    turnCount++;
                }
                else
                {
                    Console.WriteLine("Please enter r or h only.");
                }
                if (totalScore >= 20)
                {
                    gameOver = true;
                    Console.WriteLine("You win! You finished in " + turnCount + "turns");
                }
            }
        }
    }
}





