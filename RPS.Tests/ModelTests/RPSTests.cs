using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Test
{
    [TestClass]
    public class RPSTests
    {
        [TestMethod]
        public void RunGame_GetResult_Player1Wins()
        {
            Game newGame = new Game();
            newGame.Player1Move = "rock";
            newGame.Player2Move = "scissors";
            string result = newGame.RunGame();
            Assert.AreEqual(result, "Player One Wins");
        }    
        [TestMethod]
        public void RunGame_GetResult_Player2Wins()
        {
            Game newGame = new Game();
            newGame.Player1Move = "paper";
            newGame.Player2Move = "scissors";
            string result = newGame.RunGame();
            Assert.AreEqual(result, "Player Two Wins");
        }    
        [TestMethod]
        public void RunGame_GetResult_Draw()
        {
            Game newGame = new Game();
            newGame.Player1Move = "rock";
            newGame.Player2Move = "rock";
            string result = newGame.RunGame();
            Assert.AreEqual(result, "Draw!");
        }    
        
    }
}