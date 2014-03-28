using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestMovementWithoutLegality
    {

        private IGameModel gameModel;

        [TestInitialize]
        public void Before()
        {
            gameModel = new GameModel();
        }

        [TestCleanup]
        public void After()
        {
        
        }

        [TestMethod]
        public void TestMoveQueenPawnTwoForward()
        {
            gameModel.TryMove(52, 36);

            Assert.IsTrue(gameModel.WhitePawns[36]);
            Assert.IsFalse(gameModel.WhitePawns[52]);
            Assert.IsTrue(gameModel.AllPieces[36]);
            Assert.IsFalse(gameModel.AllPieces[52]);
            Assert.IsTrue(gameModel.AllWhitePieces[36]);
            Assert.IsFalse(gameModel.AllWhitePieces[52]);
            
        }


    }
}
