



using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace AppleJack.Engine.Test
{
    [TestClass]
    public class TestPreProcessedMoveQueensDatabase
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
        public void TestQueenAtIndex0()
        {

            const int index = 0;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };


            int[] expectedat0 = new int[7] {1, 2, 3, 4, 5, 6, 7};
            int[] expectedat1 = new int[7] {9,18,27,36,45,54,63};
            int[] expectedat2 = new int[7] {8, 16, 24, 32,40, 48, 56};
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = allNeg1;
            int[] expectedat7 = allNeg1;
           
           

            int[][] queenRays = preProcess.GetQueenMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, queenRays[0]);
            CollectionAssert.AreEqual(expectedat1, queenRays[1]);
            CollectionAssert.AreEqual(expectedat2, queenRays[2]);
            CollectionAssert.AreEqual(expectedat3, queenRays[3]);
            CollectionAssert.AreEqual(expectedat4, queenRays[4]);
            CollectionAssert.AreEqual(expectedat5, queenRays[5]);
            CollectionAssert.AreEqual(expectedat6, queenRays[6]);
            CollectionAssert.AreEqual(expectedat7, queenRays[7]);
           
      
        }
        
        
        [TestMethod]
        public void TestQueenAtIndex61()
        {
            const int index = 61;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };

            int[] expectedat0 = new int[7] { 62, 63, -1, -1, -1, -1, -1 };
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = allNeg1;
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = new int[7] { 60, 59, 58, 57, 56, -1, -1 };
            int[] expectedat5 = new int[7] { 52, 43, 34, 25, 16, -1, -1 };
            int[] expectedat6 = new int[7] { 53, 45, 37, 29, 21, 13, 5 };
            int[] expectedat7 = new int[7] { 54, 47, -1, -1, -1, -1, -1 };



            int[][] queenRays = preProcess.GetQueenMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, queenRays[0]);
            CollectionAssert.AreEqual(expectedat1, queenRays[1]);
            CollectionAssert.AreEqual(expectedat2, queenRays[2]);
            CollectionAssert.AreEqual(expectedat3, queenRays[3]);
            CollectionAssert.AreEqual(expectedat4, queenRays[4]);
            CollectionAssert.AreEqual(expectedat5, queenRays[5]);
            CollectionAssert.AreEqual(expectedat6, queenRays[6]);
            CollectionAssert.AreEqual(expectedat7, queenRays[7]);

        }

        [TestMethod]
        public void TestQueenAtIndex24()
        {
            const int index = 24;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };

            int[] expectedat0 = new int[7] { 25,26,27,28,29,30,31};
            int[] expectedat1 = new int[7] { 33, 42, 51, 60, -1,-1, -1 };
            int[] expectedat2 = new int[7] { 32, 40, 48, 56, -1, -1, -1 };
            int[] expectedat3 = allNeg1;
            int[] expectedat4 = allNeg1;
            int[] expectedat5 = allNeg1;
            int[] expectedat6 = new int[7] { 16, 8, 0, -1, -1, -1, -1};
            int[] expectedat7 = new int[7] { 17, 10, 3, -1, -1, -1, -1 };

            int[][] queenRays = preProcess.GetQueenMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, queenRays[0]);
            CollectionAssert.AreEqual(expectedat1, queenRays[1]);
            CollectionAssert.AreEqual(expectedat2, queenRays[2]);
            CollectionAssert.AreEqual(expectedat3, queenRays[3]);
            CollectionAssert.AreEqual(expectedat4, queenRays[4]);
            CollectionAssert.AreEqual(expectedat5, queenRays[5]);
            CollectionAssert.AreEqual(expectedat6, queenRays[6]);
            CollectionAssert.AreEqual(expectedat7, queenRays[7]);

        }

        [TestMethod]
        public void TestQueenAtIndex23()
        {
            const int index = 23;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };

            int[] expectedat0 = allNeg1;
            int[] expectedat1 = allNeg1;
            int[] expectedat2 = new int[7] { 31, 39, 47, 55, 63, -1, -1 };
            int[] expectedat3 = new int[7] { 30, 37, 44, 51, 58, -1, -1 };
            int[] expectedat4 = new int[7] { 22, 21, 20, 19, 18, 17, 16 };
            int[] expectedat5 = new int[7] { 14, 5, -1, -1, -1, -1, -1};
            int[] expectedat6 = new int[7] { 15, 7,-1, -1, -1, -1, -1 };
            int[] expectedat7 = allNeg1;

            int[][] queenRays = preProcess.GetQueenMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, queenRays[0]);
            CollectionAssert.AreEqual(expectedat1, queenRays[1]);
            CollectionAssert.AreEqual(expectedat2, queenRays[2]);
            CollectionAssert.AreEqual(expectedat3, queenRays[3]);
            CollectionAssert.AreEqual(expectedat4, queenRays[4]);
            CollectionAssert.AreEqual(expectedat5, queenRays[5]);
            CollectionAssert.AreEqual(expectedat6, queenRays[6]);
            CollectionAssert.AreEqual(expectedat7, queenRays[7]);

        }
        [TestMethod]
        public void TestQueenAtIndex35()
        {
            const int index = 35;

            int[] allNeg1 = new int[7] { -1, -1, -1, -1, -1, -1, -1, };

            int[] expectedat0 = new int[7] { 36, 37, 38, 39, -1, -1, -1 };
            int[] expectedat1 = new int[7] { 44, 53, 62, -1, -1, -1, -1 };
            int[] expectedat2 = new int[7] { 43, 51, 59, -1, -1, -1, -1 };
            int[] expectedat3 = new int[7] { 42, 49, 56, -1, -1, -1, -1 };
            int[] expectedat4 = new int[7] { 34, 33, 32, -1, -1, -1, -1};
            int[] expectedat5 = new int[7] { 26, 17, 8, -1, -1, -1, -1, };
            int[] expectedat6 = new int[7] { 27, 19, 11, 3, -1, -1, -1, };
            int[] expectedat7 = new int[7] { 28, 21, 14, 7, -1, -1, -1, };

            int[][] queenRays = preProcess.GetQueenMoveRays(index);

            CollectionAssert.AreEqual(expectedat0, queenRays[0]);
            CollectionAssert.AreEqual(expectedat1, queenRays[1]);
            CollectionAssert.AreEqual(expectedat2, queenRays[2]);
            CollectionAssert.AreEqual(expectedat3, queenRays[3]);
            CollectionAssert.AreEqual(expectedat4, queenRays[4]);
            CollectionAssert.AreEqual(expectedat5, queenRays[5]);
            CollectionAssert.AreEqual(expectedat6, queenRays[6]);
            CollectionAssert.AreEqual(expectedat7, queenRays[7]);

        }

    }
}