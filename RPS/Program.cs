using System;
using RPS.Models;

namespace RPS
{
    public class Program
    {
        static void Main()
        {
            Console.Clear();
            TypeLine("Welcome to the Rock, Paper, Scissors game!");
            TypeLine("Are you ready to play? Press enter to start game");
            string startGame = Console.ReadLine();
            if (startGame != null)
            {
                Console.Clear();
                Game newGame = new Game();
                TypeLine("Please enter Player One's choice (rock, paper or scissors)");
                newGame.Player1Move = Console.ReadLine();
                Console.Clear();
                TypeLine("Please enter Player Two's choice (rock, paper or scissors)");
                newGame.Player2Move = Console.ReadLine();
                Console.Clear();
                string outcome = newGame.RunGame();
                TypeLine(outcome);
            }

        }

        public static void TypeLine(string input)
        {
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(input[i]);
            System.Threading.Thread.Sleep(25);
        }
        Console.Write(Environment.NewLine);
        Console.Write(Environment.NewLine);
        }
    }
}