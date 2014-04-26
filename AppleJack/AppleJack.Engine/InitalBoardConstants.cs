using System;

namespace AppleJack.Engine
{
    public static class InitalBoardConstants
    {
        public static readonly bool[] AllFalse = new bool[64]
        {
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false
        };

        public static readonly bool[] AllPeices = new bool[64]
        {
            true, true, true, true, true, true, true, true,
            true, true, true, true, true, true, true, true,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            true, true, true, true, true, true, true, true,
            true, true, true, true, true, true, true, true,

        };
        
        public static readonly bool[] AllWhite = new bool[64]
        {
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            true, true, true, true, true, true, true, true,
            true, true, true, true, true, true, true, true

        };
        
        public static readonly bool[] AllBlack = new bool[64]
        {
            true, true, true, true, true, true, true, true,
            true, true, true, true, true, true, true, true,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false,
            false, false, false, false, false, false, false, false
            

        };

        public static bool[] BlackPawns()
        {
            var pawns = AllFalse;
            for (int i = 8; i < 16; i++)//8-15
            {
                pawns[i] = true;
            }
            return pawns;
        }

        /*toDo: Consider making this use whitePawns with overload*/
        public static bool[] WhitePawns()
        {
            var pawns = AllFalse;
            for (int i = 48; i < 56; i++)//48-55
            {
                pawns[i] = true;
            }
            return pawns;
        }
        #region White Pieces
        public static bool[] WhiteRooks()
        {
            return GetBitBordWithTruesFor(new[] {56, 63});

        }

        public static bool[] WhiteKnights()
        {
            return GetBitBordWithTruesFor(new[] { 57, 62 });
        }

        public static bool[] WhiteBishops()
        {
            return GetBitBordWithTruesFor(new[] { 58, 61 });
        }

        public static bool[] WhiteQueen()
        {
            return GetBitBordWithTruesFor(new[] {59});
        }
        public static bool[] WhiteKing()
        {
            return GetBitBordWithTruesFor(new[] {60});
        }

        

        #endregion

        #region Black Pieces

        public static bool[] BlackRooks()
        {
            return GetBitBordWithTruesFor(new[] { 0, 7 });
        }

        /*Get batman's for board*/
        public static bool[] BlackKnights()
        {
            return GetBitBordWithTruesFor(new[] { 1, 6 });
        }

        public static bool[] BlackBishops()
        {
            return GetBitBordWithTruesFor(new[] { 2, 5 });
        }

        public static bool[] BlackQueen()
        {
            return GetBitBordWithTruesFor(new[] { 3 });
        }
        public static bool[] BlackKing()
        {
            return GetBitBordWithTruesFor(new[] { 4 });
        }



        #endregion


        private static bool[] GetBitBordWithTruesFor(int[] indicies)
        {
            bool[] board = AllFalse;
            foreach (int index in indicies)
            {
                if (index < 0 || index > 63)
                {
                    throw new Exception("One of the indicies " + index + "is out of bounds for a chess board");
                }
                else
                {
                    board[index] = true;
                }
            }
            return board;
        }
    }
}