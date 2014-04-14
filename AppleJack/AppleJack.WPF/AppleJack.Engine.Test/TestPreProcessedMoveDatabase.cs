using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestPreProcessedMoveDatabase
    {
        private IMoveGenerationPreProcess preProcess;
        private int[][][][] database;
        [TestInitialize]
        public void Before()
        {
            preProcess = new MoveGenerationPreProcess();
            database = preProcess.GetPreProcessedLegalMoves();
        }

        [TestCleanup]
        public void After()
        {

        }
        

        [TestMethod]
        public void TestCreation()
        {
            Assert.AreEqual(1, database[0][0][0][0]); // this usage will not be valid later
        }
    }
}
