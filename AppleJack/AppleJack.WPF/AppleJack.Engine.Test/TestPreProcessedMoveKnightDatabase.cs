using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestPreProcessedMoveKnightDatabase
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
        public void TestKnightAtIndex0()
        {

            const int index = 0;

            int[] allNeg1 = new int[7] {-1, -1, -1, -1, -1, -1, -1,};


            int[] expectedat0 = new int[7] { 10, -1, -1, -1, -1, -1, -1, };
            int[] expectedat1 = new int[7] { 17, -1, -1, -1, -1, -1, -1, };
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }


        [TestMethod]
        public void TestKnightAtIndex7()
        {

            const int index = 7;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = new int[7] { 22, -1, -1, -1, -1, -1, -1, };
            int[] expectedat3 = new int[7] { 13, -1, -1, -1, -1, -1, -1, };
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }

        [TestMethod]
        public void TestKnightAtIndex9()
        {

            const int index = 9;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = new int[7] { 19, -1, -1, -1, -1, -1, -1, };
            int[] expectedat1 = new int[7] { 26, -1, -1, -1, -1, -1, -1, };
            int[] expectedat2 = new int[7] { 24, -1, -1, -1, -1, -1, -1, };
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = new int[7] { 3, -1, -1, -1, -1, -1, -1, };



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }
        [TestMethod]
        public void TestKnightAtIndex14()
        {

            const int index = 14;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = new int[7] { 31, -1, -1, -1, -1, -1, -1, };
            int[] expectedat2 = new int[7] { 29, -1, -1, -1, -1, -1, -1, };
            int[] expectedat3 = new int[7] { 20, -1, -1, -1, -1, -1, -1, };
            int[] expectedat4 = new int[7] { 4, -1, -1, -1, -1, -1, -1, };
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }

        [TestMethod]
        public void TestKnightAtIndex49()
        {

            const int index = 49;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = new int[7] { 59, -1, -1, -1, -1, -1, -1, };
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = new int[7] { 32, -1, -1, -1, -1, -1, -1, };
            int[] expectedat6 = new int[7] { 34, -1, -1, -1, -1, -1, -1, };
            int[] expectedat7 = new int[7] { 43, -1, -1, -1, -1, -1, -1, };



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }


        [TestMethod]
        public void TestKnightAtIndex54()
        {

            const int index = 54;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = new int[7] { 60, -1, -1, -1, -1, -1, -1, };
            int[] expectedat4 = new int[7] { 44, -1, -1, -1, -1, -1, -1, };
            int[] expectedat5 = new int[7] { 37, -1, -1, -1, -1, -1, -1, };
            int[] expectedat6 = new int[7] { 39, -1, -1, -1, -1, -1, -1, };
            int[] expectedat7 = allNeg1;



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }

        [TestMethod]
        public void TestKnightAtIndex56()
        {

            const int index = 56;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = new int[7] { 41, -1, -1, -1, -1, -1, -1, };
            int[] expectedat7 = new int[7] { 50, -1, -1, -1, -1, -1, -1, };



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }

        [TestMethod]
        public void TestKnightAtIndex63()
        {

            const int index = 63;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = new int[7] { 53, -1, -1, -1, -1, -1, -1, };
            int[] expectedat5 = new int[7] { 46, -1, -1, -1, -1, -1, -1, };
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] knightRays = preProcess.GetKnightMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, knightRays[0]);
            CollectionAssert.AreEqual(expectedat1, knightRays[1]);
            CollectionAssert.AreEqual(expectedat2, knightRays[2]);
            CollectionAssert.AreEqual(expectedat3, knightRays[3]);
            CollectionAssert.AreEqual(expectedat4, knightRays[4]);
            CollectionAssert.AreEqual(expectedat5, knightRays[5]);
            CollectionAssert.AreEqual(expectedat6, knightRays[6]);
            CollectionAssert.AreEqual(expectedat7, knightRays[7]);


        }

    }
}