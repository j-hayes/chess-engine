using System;
using System.Collections;
using System.Linq;

namespace AppleJack.Engine
{
    public class GameModel : IGameModel
    {
   
        /*
         a board bit board is below 
         * 0th bitarray is 
         */
        public BitArray[] board { get; set; }

        public GameModel()
        {
            board = InitializeBoard(true);
        }

        private BitArray[] InitializeBoard(bool playerIsWhite)
        {
            var initialGame = new BitArray[15];


            initialGame[0] = new BitArray(InitalBoardConstants.AllPeices);
            initialGame[1] = new BitArray(InitalBoardConstants.AllWhite);
            initialGame[2] = new BitArray(InitalBoardConstants.AllBlack);
            initialGame[3] = new BitArray(InitalBoardConstants.WhitePawns());
            initialGame[4] = new BitArray(InitalBoardConstants.BlackPawns());
            initialGame[5] = new BitArray(InitalBoardConstants.WhiteRooks());
            initialGame[6] = new BitArray(InitalBoardConstants.WhiteKnights());
            initialGame[7] = new BitArray(InitalBoardConstants.WhiteBishops());
            initialGame[8] = new BitArray(InitalBoardConstants.WhiteQueen());
            initialGame[9] = new BitArray(InitalBoardConstants.WhiteKing());
            initialGame[10] = new BitArray(InitalBoardConstants.BlackRooks());
            initialGame[11] = new BitArray(InitalBoardConstants.BlackKnights());
            initialGame[12] = new BitArray(InitalBoardConstants.BlackBishops());
            initialGame[13] = new BitArray(InitalBoardConstants.BlackQueen());
            initialGame[14] = new BitArray(InitalBoardConstants.BlackKing());


            return initialGame;
        }

        public BitArray AllPieces
        {
            get { return board[0]; }
        }

        public BitArray AllWhitePieces
        {
            get { return board[1]; }
        }

        public BitArray AllBlackPieces
        {
            get { return board[2]; }
        }

        public BitArray WhitePawns
        {
            get { return board[3]; }
        }

        public BitArray BlackPawns
        {
            get { return board[4]; }
        }

        public BitArray WhiteRooks
        {
            get { return board[5]; }
        }

        public BitArray WhiteKnights
        {
            get { return board[6]; }
        }

        public BitArray WhiteBishops
        {
            get { return board[7]; }
        }

        public BitArray WhiteQueens
        {
            get { return board[8]; }
        }

        public BitArray WhiteKing
        {
            get { return board[9]; }
        }

        public BitArray BlackRooks
        {
            get { return board[10]; }
        }

        public BitArray BlackKnights
        {
            get { return board[11]; }
        }

        public BitArray BlackBishops
        {
            get { return board[12]; }
        }

        public BitArray BlackQueens
        {
            get { return board[13]; }
        }

        public BitArray BlackKing
        {
            get { return board[14]; }
        }



        public int PieceTypeCount
        {
            get { return board.Count(); }
           
        }

        public bool TryMove(int from, int to)
        {
            // todo: think about roll back strategy? 


            if (AllPieces[from])
            {
                RemovePeiceAtIndex(to);
                if (AllWhitePieces[from])
                {
                    if (WhitePawns[from])
                    {
                        WhitePawns[from] = false;
                        WhitePawns[to] = true; //this is oversimplified
                    }
                    else if (WhiteRooks[from])
                    {
                        WhiteRooks[from] = false;
                        WhiteRooks[to] = true; //this is oversimplified
                    }
                    else if (WhiteKnights[from])
                    {
                        WhiteKnights[from] = false;
                        WhiteKnights[to] = true; //this is oversimplified
                    }
                    else if (WhiteBishops[from])
                    {
                        WhiteBishops[from] = false;
                        WhiteBishops[to] = true; //this is oversimplified
                    }
                    else if (WhiteQueens[from])
                    {
                        WhiteQueens[from] = false;
                        WhiteQueens[to] = true; //this is oversimplified
                    }
                    else if(WhiteKing[from])
                    {
                        WhiteKing[from] = false;
                        WhiteKing[to] = true;
                    }
                    AllWhitePieces[to] = true;
                    AllWhitePieces[from] = false;
                }
                else if (AllBlackPieces[from])
                {
                    if (AllBlackPieces[from])
                    {
                        if (BlackPawns[from])
                        {
                            BlackPawns[from] = false;
                            BlackPawns[to] = true; //this is oversimplified
                        }
                        else if (BlackRooks[from])
                        {
                            BlackRooks[from] = false;
                            BlackRooks[to] = true; //this is oversimplified
                        }
                        else if (BlackKnights[from])
                        {
                            BlackKnights[from] = false;
                            BlackKnights[to] = true; //this is oversimplified
                        }
                        else if (BlackBishops[from])
                        {
                            BlackBishops[from] = false;
                            BlackBishops[to] = true; //this is oversimplified
                        }
                        else if (BlackQueens[from])
                        {
                            BlackQueens[from] = false;
                            BlackQueens[to] = true; //this is oversimplified
                        }
                        else if(BlackKing[from])
                        {
                            BlackKing[from] = false;
                            BlackKing[to] = true;
                        }
                    }
                    AllBlackPieces[to] = true;
                    AllWhitePieces[from] = false;
                }
                
                AllPieces[to] = true;
                AllPieces[from] = false;

                return true;
            }
            throw new Exception("There is no piece at this index to move");
            return false;
        }
        //this method will get changed to check 
        //and see if this move is legal ie is there a peice of same type in 

        //currently over simplefied 
        private void RemovePeiceAtIndex(int index)
        {
            foreach (var bitArray in board)
            {
                if (bitArray[index])
                {
                    bitArray[index] = false;
                }

            }
        }

    }
}
