using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestBoardCreation
    {
        [TestMethod]
        public void TestNothingInThirdRowOnStart()
        {
            IGameModel gameModel = new GameModel();

            Assert.IsFalse(gameModel.AllPieces[17]);
        }
    }
}
