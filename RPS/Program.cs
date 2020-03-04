using System;
using RPS.Models;

namespace RPS
{
    public class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            TypeLine("Welcome to the Rock, Paper, Scissors game!");
            TypeLine("Do you want to play Player vs Player OR Player vs Computer? Choose pvp or pvc");
            string gameType = Console.ReadLine();
            if (gameType == "pvp")
            {
                PvPGame();
            }
            else if (gameType == "pvc")
            {
                PvCGame();
            }
            else
            {
                Console.Write(Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Red;
                TypeLine("That wasn't a valid choice... please try again in..");
                TypeLine("3........................");
                System.Threading.Thread.Sleep(300);
                TypeLine("2..................................");
                System.Threading.Thread.Sleep(300);
                TypeLine("1...........................................");
                System.Threading.Thread.Sleep(300);
                Main(); 
            }

        }

        static void PvPGame()
        {
            Console.Clear();
            TypeLine("Let's decide an amount of rounds to play");
            TypeLine("How many rounds won will end the match? Please enter a whole number");
            Game newGame = new Game();
            try
            {
                newGame.WinCount = int.Parse(Console.ReadLine());       
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                TypeLine("Okay, lets play! First to " + newGame.WinCount + " wins!");
                newGame.GamePlay();
            }
            catch (System.Exception)
            {
                Console.Write(Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Red;
                TypeLine("That wasn't a valid number... please try again in..");
                TypeLine("3........................");
                System.Threading.Thread.Sleep(300);
                TypeLine("2..................................");
                System.Threading.Thread.Sleep(300);
                TypeLine("1...........................................");
                System.Threading.Thread.Sleep(300);
                Main();
            }
        }

        static void PvCGame()
        {
            Console.Clear();
            TypeLine("Let's decide an amount of rounds to play");
            TypeLine("How many rounds won will end the match? Please enter a whole number");
            Game newGame = new Game();
            try
            {
                newGame.WinCount = int.Parse(Console.ReadLine());       
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                TypeLine("Okay, lets play! First to " + newGame.WinCount + " wins!");
                newGame.PvCGamePlay();
            }
            catch (System.Exception)
            {
                Console.Write(Environment.NewLine);
                Console.ForegroundColor = ConsoleColor.Red;
                TypeLine("That wasn't a valid number... please try again in..");
                TypeLine("3........................");
                System.Threading.Thread.Sleep(300);
                TypeLine("2..................................");
                System.Threading.Thread.Sleep(300);
                TypeLine("1...........................................");
                System.Threading.Thread.Sleep(300);
                Main();
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