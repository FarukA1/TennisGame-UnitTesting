using NUnit.Framework;
using System;
namespace Tennis
{
    [TestFixture()]
    public class Test
    {
        Game game;

        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }

        [TearDown]
        public void TearDown()
        {
            game = null;
        }

        public void reachDeuce()
        {
            for(int i = 0; i < 3; i++)
            {
                game.addPointToPlayer1();
            }

            for (int i = 0; i < 3; i++)
            {
                game.addPointToPlayer2();
            }
        }

        [Test()]
        public void testZeroPoints()
        {
            Assert.AreEqual(game.returnPlayer1Score(), "0", "P1 score correct with 0 points");
            Assert.AreEqual(game.returnPlayer2Score(), "0", "P2 score correct with 0 points");
        }

        [Test()]
        public void testScoreOnePoint()
        {
            game.addPointToPlayer1();
            Assert.AreEqual(game.returnPlayer1Score(), "15", "P1 score correct with 1 points");

            game.addPointToPlayer2();
            Assert.AreEqual(game.returnPlayer2Score(), "15", "P2 score correct with 1 points");
        }

        [Test()]
        public void testScoreTwoPoint()
        {
            for(int i = 0; i < 2; i++)
            {
                game.addPointToPlayer1();
            }
            Assert.AreEqual(game.returnPlayer1Score(), "30", "P1 score correct with 2 points");

            for (int i = 0; i < 2; i++)
            {
                game.addPointToPlayer2();
            };
            Assert.AreEqual(game.returnPlayer2Score(), "30", "P2 score correct with 2 points");
        }

        [Test()]
        public void testScoreThreePoint()
        {
            for (int i = 0; i < 3; i++)
            {
                game.addPointToPlayer1();
            }
            Assert.AreEqual(game.returnPlayer1Score(), "40", "P1 score correct with 3 points");

            for (int i = 0; i < 3; i++)
            {
                game.addPointToPlayer2();
            };
            Assert.AreEqual(game.returnPlayer2Score(), "40", "P2 score correct with 3 points");
        }

        [Test()]
        public void testSimpleWinP1()
        {
            for (int i = 0; i < 4; i++)
            {
                game.addPointToPlayer1();
            }
            Assert.IsTrue(game.player1Won(), "P1 win after 4 consecutive points");
        }

        [Test()]
        public void testSimpleWinP2()
        {
            for (int i = 0; i < 4; i++)
            {
                game.addPointToPlayer2();
            }
            Assert.IsTrue(game.player2Won(), "P2 win after 4 consecutive points");
        }

        [Test()]
        public void testReachingDeuce()
        {
            reachDeuce();
            Assert.AreEqual(game.returnPlayer1Score(), "40", "P1 score correct reaching Deuce");
            Assert.AreEqual(game.returnPlayer2Score(), "40", "P2 score correct reaching Deuce");
            Assert.IsFalse(game.player1Won());
            Assert.IsFalse(game.player2Won());
            Assert.IsFalse(game.completeGame());
        }

        [Test()]
        public void testAdvantageP1()
        {
            reachDeuce();
            game.addPointToPlayer1();
            Assert.AreEqual(game.returnPlayer1Score(), "A", "P1 score correct with P1 Advantage");
            Assert.AreEqual(game.returnPlayer2Score(), "40", "P2 score correct with P1 Advantage");
        }

        [Test()]
        public void testAdvantageP2()
        {
            reachDeuce();
            game.addPointToPlayer2();
            Assert.AreEqual(game.returnPlayer2Score(), "A", "P2 score correct with P1 Advantage");
            Assert.AreEqual(game.returnPlayer1Score(), "40", "P1 score correct with P1 Advantage");
        }

        [Test()]
        public void testGameWinP1()
        {
            for (int i = 0; i < 4; i++)
            {
                game.addPointToPlayer1();
            }
            Assert.IsTrue(game.completeGame());
        }

        [Test()]
        public void testGameWinP2()
        {
            for (int i = 0; i < 4; i++)
            {
                game.addPointToPlayer2();
            }
            Assert.IsTrue(game.completeGame());
        }
    }
}
