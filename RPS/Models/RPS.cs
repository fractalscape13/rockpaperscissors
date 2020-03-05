using System;

namespace RPS.Models
{
    public class Game
    {
        public string Player1Move { get; set; }
        public string Player2Move { get; set; }
        public int Player1Score { get; set; }
        public int Player2Score { get; set; }
        public int WinCount { get; set; }
        
        public Game()
        {
           Player1Move = "";
           Player2Move = "";
           Player1Score = 0;
           Player2Score = 0;
           WinCount = 1;

        }
        public void GamePlay(string type)
        {  
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (type == "pvp")
            {
                TypeLine("Player Two, please look away");
            }
            TypeLine("Player One: Enter choice (rock, paper or scissors)");
            Player1Move = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (type == "pvp")
            {
                TypeLine("Player One, please look away");
                TypeLine("Player Two: Enter choice (rock, paper or scissors)");
                Player2Move = Console.ReadLine();
                Console.Clear();
                TypeLine("Player One chose " + Player1Move);
                TypeLine("Player Two chose " + Player2Move);
            }
            else if (type == "pvc")
            {
                Random randNum = new Random();
                int index = randNum.Next(1, 4);
                if (index == 1)
                {
                    Player2Move = "rock";
                }
                else if (index == 2)
                {
                    Player2Move = "paper";
                }
                else if (index == 3)
                {
                    Player2Move = "scissors";
                }
                TypeLine("Player One chose " + Player1Move);
                TypeLine("Computer chose " + Player2Move);
            }
            string outcome = CheckGame(type);
            Console.ForegroundColor = ConsoleColor.Green;
            TypeLine(outcome);
            TypeLine("Player One current score: " + Player1Score);
            if (type == "pvp")
            {
                TypeLine("Player Two current score: " + Player2Score);
            }
            else if (type == "pvc")
            {
                TypeLine("Computer current score: " + Player2Score);
            }
            CheckWinner(type);
        }

        public string CheckGame(string type)
        {
            if (Player1Move == Player2Move)
            {
                return "Draw!";
            }
            else if ((Player1Move == "rock" && Player2Move == "scissors") || (Player1Move == "paper" && Player2Move == "rock") || (Player1Move == "scissors" && Player2Move == "paper")) 
            {
                Player1Score += 1;
                return "Player One wins this round";
            }     
            else if ((Player2Move == "rock" && Player1Move == "scissors") || (Player2Move == "paper" && Player1Move == "rock") || (Player2Move == "scissors" && Player1Move == "paper")) 
            {
                Player2Score += 1;
                if (type == "pvp")
                {
                    return "Player Two wins this round";
                }
                else if (type == "pvc")
                {
                    return "Computer wins this round";
                }
                else
                {
                    return "Error";
                }
            }
            else 
            {
                return "Sorry, I didn't get that";
            }
        }

        public void CheckWinner(string type)
        {
            if (Player1Score >= WinCount)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                TypeLine("Player One Wins!");
            }
            else if (Player2Score >= WinCount)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (type == "pvc")
                {
                    TypeLine("Computer Wins!");
                }
                else
                {
                    TypeLine("Player Two Wins!");
                }
            }
            else
            {
                GamePlay(type);
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