using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestPreProcessedMoveBishopDatabase
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
        public void TestBishopAtIndex0()
        {

            const int index = 0;

            int[] allNeg1 = new int[7] {-1, -1, -1, -1, -1, -1, -1,};


            int[] expectedat0 = new int[7] {9, 18, 27, 36, 45, 54, 63};
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] bishopRays = preProcess.GetBishopMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, bishopRays[0]);
            CollectionAssert.AreEqual(expectedat1, bishopRays[1]);
            CollectionAssert.AreEqual(expectedat2, bishopRays[2]);
            CollectionAssert.AreEqual(expectedat3, bishopRays[3]);
            CollectionAssert.AreEqual(expectedat4, bishopRays[4]);
            CollectionAssert.AreEqual(expectedat5, bishopRays[5]);
            CollectionAssert.AreEqual(expectedat6, bishopRays[6]);
            CollectionAssert.AreEqual(expectedat7, bishopRays[7]);


        }
        [TestMethod]
        public void TestBishopAtIndex23()
        {

            const int index = 23;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = new int[7] { 30,37,44,51,58,-1,-1};
            int[] expectedat2 = new int[7] { 14, 5, -1, -1, -1, -1, -1, };
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] bishopRays = preProcess.GetBishopMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, bishopRays[0]);
            CollectionAssert.AreEqual(expectedat1, bishopRays[1]);
            CollectionAssert.AreEqual(expectedat2, bishopRays[2]);
            CollectionAssert.AreEqual(expectedat3, bishopRays[3]);
            CollectionAssert.AreEqual(expectedat4, bishopRays[4]);
            CollectionAssert.AreEqual(expectedat5, bishopRays[5]);
            CollectionAssert.AreEqual(expectedat6, bishopRays[6]);
            CollectionAssert.AreEqual(expectedat7, bishopRays[7]);


        }
        [TestMethod]
        public void TestBishopAtIndex35()
        {

            const int index = 35;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = new int[7] { 44, 53, 62, -1, -1, -1, -1, };
            int[] expectedat1 = new int[7] { 42, 49, 56, -1, -1, -1, -1 };
            int[] expectedat2 = new int[7] { 26, 17, 8, -1, -1, -1, -1, };
            int[] expectedat3 = new int[7] { 28, 21, 14, 7, -1, -1, -1, };
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] bishopRays = preProcess.GetBishopMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, bishopRays[0]);
            CollectionAssert.AreEqual(expectedat1, bishopRays[1]);
            CollectionAssert.AreEqual(expectedat2, bishopRays[2]);
            CollectionAssert.AreEqual(expectedat3, bishopRays[3]);
            CollectionAssert.AreEqual(expectedat4, bishopRays[4]);
            CollectionAssert.AreEqual(expectedat5, bishopRays[5]);
            CollectionAssert.AreEqual(expectedat6, bishopRays[6]);
            CollectionAssert.AreEqual(expectedat7, bishopRays[7]);


        }
        [TestMethod]
        public void TestBishopAtIndex40()
        {

            const int index = 40;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = new int[7] { 49, 58, -1, -1, -1, -1, -1, };
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = new int[7] { 33, 26, 19, 12, 5, -1, -1, };
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] bishopRays = preProcess.GetBishopMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, bishopRays[0]);
            CollectionAssert.AreEqual(expectedat1, bishopRays[1]);
            CollectionAssert.AreEqual(expectedat2, bishopRays[2]);
            CollectionAssert.AreEqual(expectedat3, bishopRays[3]);
            CollectionAssert.AreEqual(expectedat4, bishopRays[4]);
            CollectionAssert.AreEqual(expectedat5, bishopRays[5]);
            CollectionAssert.AreEqual(expectedat6, bishopRays[6]);
            CollectionAssert.AreEqual(expectedat7, bishopRays[7]);


        }
        [TestMethod]
        public void TestBishopAtIndex56()
        {

            const int index = 56;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = new int[7] { 49, 42, 35, 28, 21, 14, 7 };
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;



            int[][] bishopRays = preProcess.GetBishopMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, bishopRays[0]);
            CollectionAssert.AreEqual(expectedat1, bishopRays[1]);
            CollectionAssert.AreEqual(expectedat2, bishopRays[2]);
            CollectionAssert.AreEqual(expectedat3, bishopRays[3]);
            CollectionAssert.AreEqual(expectedat4, bishopRays[4]);
            CollectionAssert.AreEqual(expectedat5, bishopRays[5]);
            CollectionAssert.AreEqual(expectedat6, bishopRays[6]);
            CollectionAssert.AreEqual(expectedat7, bishopRays[7]);


        }
    }
}