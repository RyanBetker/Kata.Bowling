using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata.Bowling.Tests
{
    [TestClass]
    public class GameTest
    {
        void RollPinsSeveralTimes(Game g, int rollCount, int pinsToKnock)
        {
            for (int i = 0; i < rollCount; i++)
            {
                g.Roll(pinsToKnock);
            }
        }

        [TestMethod]
        public void ScoreGutterGame()
        {
            var game = new Game();
            RollPinsSeveralTimes(game, 20, 0);

            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void Score7Game()
        {
            var game = new Game();
            game.Roll(2);
            game.Roll(5);
            RollPinsSeveralTimes(game, 18, 0);

            Assert.AreEqual(7, game.Score());
        }

        [TestMethod]
        public void ScoreAllOnesGame()
        {
            var game = new Game();
            RollPinsSeveralTimes(game, 20, 1);

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void ScoreOneSpareGame()
        {
            var game = new Game();
            game.Roll(4);
            game.Roll(6);
            game.Roll(2);

            RollPinsSeveralTimes(game, 17, 0);

            Assert.AreEqual(14, game.Score());
        }

        [TestMethod]
        public void ScoreOneStrikeGame()
        {
            var game = new Game();
            game.Roll(10);

            game.Roll(2);
            game.Roll(6); 

            RollPinsSeveralTimes(game, 17, 0);

            Assert.AreEqual(26, game.Score());
        }

        [TestMethod]
        public void ScorePerfectGame()
        {
            var game = new Game();

            RollPinsSeveralTimes(game, 11, 10);

            Assert.AreEqual(300, game.Score());
        }
    }
}
