using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestMovementsWithLegalityChecks
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
        public void TestTryMoveMovePawnForwardOne()
        {
            //setup
            bool wasLegal = false;

            //act
            wasLegal = gameModel.TryMove(51, 43);
        

            //assert
            Assert.IsTrue(wasLegal);

        }  

        [TestMethod]
        public void TestTryMoveTestMoveQueensPawnsAndCaptureBlackPawn()
        {
            //setup
            bool wasLegal = false;
            
            //act
            wasLegal = gameModel.TryMove(51, 35);
            wasLegal = gameModel.TryMove(12, 28);
            wasLegal = gameModel.TryMove(35, 28);

            //assert
            Assert.IsTrue(wasLegal);

        }  

        [TestMethod]
        public void TestTryMoveMovePawnForwardTwoSquaresThenOneSquare()
        {
            //setup
            bool wasLegal = false;
            
            //act
            wasLegal = gameModel.TryMove(52, 36);//move forward 2 rows
            wasLegal = gameModel.TryMove(12, 20); //move forwad 1 row
            wasLegal = gameModel.TryMove(36, 28);// move forward one row

            //assert
            Assert.IsTrue(wasLegal);

        }

        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void TestTryMovePawn3RowsFails()
        {
            //act
            gameModel.TryMove(52, 28);//move forward 3 rows
            
            //assert is the exception should be thrown

        }

        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void TestTryMoveMoveBackWardFais()
        {
            //act
            gameModel.TryMove(52, 36);//move forward 3 rows
            gameModel.TryMove(8, 16);
            gameModel.TryMove(36, 44);
            //assert is the exception should be thrown

        }

        [TestMethod]
        [ExpectedException(typeof(IllegalMoveException))]
        public void TestTryMovePawnSlantedWithNoPeiceToCapture()
        {
            //act
            gameModel.TryMove(52, 36);//move forward 3 rows
            gameModel.TryMove(8, 16);
            //assert is the exception should be thrown

        }



    }
}
