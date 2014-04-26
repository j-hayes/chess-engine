using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestPreProcessedMoveRookDatabase
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
        public void TestRookAtIndex0()
        {

            const int index = 0;

            int[] allNeg1 = new int[7] {-1, -1, -1, -1, -1, -1, -1,};


            int[] expectedat0 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = new int[7] {8, 16, 24, 32, 40, 48, 56};
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] rookRays = preProcess.GetRookMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, rookRays[0]);
            CollectionAssert.AreEqual(expectedat1, rookRays[1]);
            CollectionAssert.AreEqual(expectedat2, rookRays[2]);
            CollectionAssert.AreEqual(expectedat3, rookRays[3]);
            CollectionAssert.AreEqual(expectedat4, rookRays[4]);
            CollectionAssert.AreEqual(expectedat5, rookRays[5]);
            CollectionAssert.AreEqual(expectedat6, rookRays[6]);
            CollectionAssert.AreEqual(expectedat7, rookRays[7]);


        }

        [TestMethod]
        public void TestRookAtIndex7()
        {

            const int index = 7;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = new int[7] {15, 23, 31, 39, 47,55,63 };
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = new int[7] { 6, 5, 4, 3, 2, 1, 0 };
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;
            

            int[][] rookRays = preProcess.GetRookMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, rookRays[0]);
            CollectionAssert.AreEqual(expectedat1, rookRays[1]);
            CollectionAssert.AreEqual(expectedat2, rookRays[2]);
            CollectionAssert.AreEqual(expectedat3, rookRays[3]);
            CollectionAssert.AreEqual(expectedat4, rookRays[4]);
            CollectionAssert.AreEqual(expectedat5, rookRays[5]);
            CollectionAssert.AreEqual(expectedat6, rookRays[6]);
            CollectionAssert.AreEqual(expectedat7, rookRays[7]);
            
        }

        [TestMethod]
        public void TestRookAtIndex56()
        {

            const int index = 56;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = new int[7] { 57, 58, 59, 60, 61, 62, 63 };
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = new int[7] { 48, 40, 32, 24, 16, 8, 0 };
            int[] expectedat7 = allNeg1;


            int[][] rookRays = preProcess.GetRookMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, rookRays[0]);
            CollectionAssert.AreEqual(expectedat1, rookRays[1]);
            CollectionAssert.AreEqual(expectedat2, rookRays[2]);
            CollectionAssert.AreEqual(expectedat3, rookRays[3]);
            CollectionAssert.AreEqual(expectedat4, rookRays[4]);
            CollectionAssert.AreEqual(expectedat5, rookRays[5]);
            CollectionAssert.AreEqual(expectedat6, rookRays[6]);
            CollectionAssert.AreEqual(expectedat7, rookRays[7]);

        }


        [TestMethod]
        public void TestRookAtIndex63()
        {

            const int index = 63;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = new int[7] { 62,61,60,59,58,57,56 };
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = new int[7] { 55,47,39,31,23,15,7 };
            int[] expectedat7 = allNeg1;


            int[][] rookRays = preProcess.GetRookMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, rookRays[0]);
            CollectionAssert.AreEqual(expectedat1, rookRays[1]);
            CollectionAssert.AreEqual(expectedat2, rookRays[2]);
            CollectionAssert.AreEqual(expectedat3, rookRays[3]);
            CollectionAssert.AreEqual(expectedat4, rookRays[4]);
            CollectionAssert.AreEqual(expectedat5, rookRays[5]);
            CollectionAssert.AreEqual(expectedat6, rookRays[6]);
            CollectionAssert.AreEqual(expectedat7, rookRays[7]);

        }
    }
}