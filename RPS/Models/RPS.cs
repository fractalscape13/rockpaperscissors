namespace RPS.Models
{
    public class Game
    {
        public string Player1Move { get; set; }
        public string Player2Move { get; set; }
        
        public Game()
        {
           Player1Move = "";
           Player2Move = "";
        }
        
        public string RunGame()
        {
            if (Player1Move == Player2Move)
            {
                return "Draw!";
            }
            else if ((Player1Move == "rock" && Player2Move == "scissors") || (Player1Move == "paper" && Player2Move == "rock") || (Player1Move == "scissors" && Player2Move == "paper")) 
            {
                return "Player One Wins";
            }     
            else if ((Player2Move == "rock" && Player1Move == "scissors") || (Player2Move == "paper" && Player1Move == "rock") || (Player2Move == "scissors" && Player1Move == "paper")) 
            {
                return "Player Two Wins";
            }
            else 
            {
                return "Sorry, I didn't get that";
            }
        }

    }
}