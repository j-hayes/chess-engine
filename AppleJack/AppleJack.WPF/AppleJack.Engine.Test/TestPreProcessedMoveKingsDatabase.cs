using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestPreProcessedMoveKingsDatabase
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

        [TestMethod]
        public void TestKingAtIndex0()
        {

            Assert.AreEqual(1, database[0][0][0][0]); // this usage will not be valid later
            Assert.AreEqual(9, database[0][0][1][0]); // this usage will not be valid later
            Assert.AreEqual(8, database[0][0][2][0]); // this usage will not be valid later
            Assert.AreEqual(-1, database[0][0][3][0]); // this usage will not be valid later
            Assert.AreEqual(-1, database[0][0][4][0]); // this usage will not be valid later
            Assert.AreEqual(-1, database[0][0][5][0]); // this usage will not be valid later
            Assert.AreEqual(-1, database[0][0][6][0]); // this usage will not be valid later
            Assert.AreEqual(-1, database[0][0][7][0]); // this usage will not be valid later


            Assert.AreEqual(1, preProcess.GetKingMoveRays(0)[0][0]);
            Assert.AreEqual(9, preProcess.GetKingMoveRays(0)[1][0]);
            Assert.AreEqual(8, preProcess.GetKingMoveRays(0)[2][0]);
           
      
        }
        
        [TestMethod]
        public void TestKingAtIndexindex()
        {
            int index = 36;

            Assert.AreEqual(index + 1, preProcess.GetKingMoveRays(index)[0][0]);
            Assert.AreEqual(index + 9, preProcess.GetKingMoveRays(index)[1][0]);
            Assert.AreEqual(index + 8, preProcess.GetKingMoveRays(index)[2][0]);
            Assert.AreEqual(index + 7, preProcess.GetKingMoveRays(index)[3][0]);
            Assert.AreEqual(index - 1, preProcess.GetKingMoveRays(index)[4][0]);
            Assert.AreEqual(index - 9, preProcess.GetKingMoveRays(index)[5][0]);
            Assert.AreEqual(index - 8, preProcess.GetKingMoveRays(index)[6][0]);
            Assert.AreEqual(index - 7, preProcess.GetKingMoveRays(index)[7][0]);
          
      
        }

        [TestMethod]
        public void TestKingAtIndex24()
        {
            int index = 24;

            Assert.AreEqual(index + 1, preProcess.GetKingMoveRays(index)[0][0]);
            Assert.AreEqual(index + 9, preProcess.GetKingMoveRays(index)[1][0]);
            Assert.AreEqual(index + 8, preProcess.GetKingMoveRays(index)[2][0]);
            Assert.AreEqual(-1, preProcess.GetKingMoveRays(index)[3][0]);
            Assert.AreEqual(-1, preProcess.GetKingMoveRays(index)[4][0]);
            Assert.AreEqual(-1, preProcess.GetKingMoveRays(index)[5][0]);
            Assert.AreEqual(index - 8, preProcess.GetKingMoveRays(index)[6][0]);
            Assert.AreEqual(index - 7, preProcess.GetKingMoveRays(index)[7][0]);


        }

        [TestMethod]
        public void TestKingAtIndex61()
        {
            int index = 61;

            Assert.AreEqual(index + 1, preProcess.GetKingMoveRays(index)[0][0]);
            Assert.AreEqual(-1, preProcess.GetKingMoveRays(index)[1][0]);
            Assert.AreEqual(-1, preProcess.GetKingMoveRays(index)[2][0]);
            Assert.AreEqual(-1, preProcess.GetKingMoveRays(index)[3][0]);
            Assert.AreEqual(index -1, preProcess.GetKingMoveRays(index)[4][0]);
            Assert.AreEqual(index - 9, preProcess.GetKingMoveRays(index)[5][0]);
            Assert.AreEqual(index - 8, preProcess.GetKingMoveRays(index)[6][0]);
            Assert.AreEqual(index - 7, preProcess.GetKingMoveRays(index)[7][0]);


        }

    }
}

