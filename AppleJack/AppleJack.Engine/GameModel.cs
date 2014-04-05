using System;
using System.Collections;
using System.Linq;

namespace AppleJack.Engine
{
    public enum ChessPeiceType
    {
        WhitePawn,
        WhiteRook,
        WhiteKnight,
        WhiteBishop,
        WhiteQueen,
        WhiteKing,
        BlackPawn,
        BlackRook,
        BlackKnight,
        BlackBishop,
        BlackQueen,
        BlackKing

    }

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
            get { return board.Count(); }//not correct??
           
        }
        /*This method throws illegal move exception if one occurs*/
        public bool TryMove(int fromi, int toi) 
        {
            // toido: think about roll back strategy? 
           
                if ((toi < 64 && toi > -1) && (fromi < 64 && fromi > -1)) //Test if moves are on board 0 to 63 indedicies 
                {
                   // CheckForSelfCheckMove(fromi, toi);

                    if (AllPieces[fromi])
                    {
                        bool wasLegal = false;
                      
                        if (AllWhitePieces[fromi])
                        {
                            if (WhitePawns[fromi])
                            {
                                wasLegal = DoPawnMoveIfLegal(true, fromi, toi);
                            }
                            else if (WhiteRooks[fromi])
                            {
                                wasLegal = DoRookMoveIfLegal(true, fromi, toi);
                            }
                            else if (WhiteKnights[fromi])
                            {
                                wasLegal = DoKnightMoveIfLegal(true, fromi, toi);
                            }
                            else if (WhiteBishops[fromi])
                            {
                                wasLegal = DoBishopMoveIfLegal(true, fromi, toi);
                            }
                            else if (WhiteQueens[fromi])
                            {
                                wasLegal = DoQueenMoveIfLegal(true, fromi, toi);
                            }
                            else if (WhiteKing[fromi])
                            {
                                wasLegal = DoKingMoveIfLegal(true, fromi, toi);
                            }
                            if (wasLegal)
                            {
                                AllWhitePieces[toi] = true;
                                AllWhitePieces[fromi] = false;
                                AllPieces[toi] = true;
                                AllPieces[fromi] = false;
                                return true;
                            }
                           
                        }
                        else if (AllBlackPieces[fromi])
                        {
                            if (BlackPawns[fromi])
                            {
                                wasLegal = DoPawnMoveIfLegal(false, fromi, toi);
                            }
                            else if (BlackRooks[fromi])
                            {
                                wasLegal = DoRookMoveIfLegal(false, fromi, toi);
                            }
                            else if (BlackKnights[fromi])
                            {
                                wasLegal = DoKnightMoveIfLegal(true, fromi, toi);
                            }
                            else if (BlackBishops[fromi])
                            {
                                wasLegal = DoBishopMoveIfLegal(false, fromi, toi);
                            }
                            else if (BlackQueens[fromi])
                            {
                                wasLegal = DoQueenMoveIfLegal(false, fromi, toi);
                            }
                            else if (BlackKing[fromi])
                            {
                                wasLegal = DoKingMoveIfLegal(false, fromi, toi);
                            }
                            if (wasLegal)
                            {
                                AllBlackPieces[toi] = true;
                                AllBlackPieces[fromi] = false;
                                AllPieces[toi] = true;
                                AllPieces[fromi] = false;
                                return true;
                            }
                        }
                      
                    }
                    throw new IllegalMoveException("There is no piece at this index " + fromi + "to move");
 
                }
                
            
            throw new IllegalMoveException("Movement goes off of the board");
        }

        private bool DoKingMoveIfLegal(bool isPieceWhite, int fromi, int toi)
        {
            throw new NotImplementedException();
        }

        private bool DoQueenMoveIfLegal(bool isPieceWhite, int fromi, int toi)
        {
            throw new NotImplementedException();
        }

        private bool DoBishopMoveIfLegal(bool pieceIsWhite, int fromi, int toi)
        {
            throw new NotImplementedException();
        }

        private bool DoKnightMoveIfLegal(bool pieceIsWhite, int fromi, int toi)
        {
            throw new NotImplementedException();
        }

        private bool DoRookMoveIfLegal(bool pieceIsWhite, int fromi, int toi)
        {
            if (MoveOnBoard(fromi, toi)) {
                
            }

            throw new IllegalMoveException("Rook moves not implimented");
        }

        private bool MoveOnBoard(int fromi, int toi)
        {
            if (MoveOnBoard(fromi,toi)) {
                return true;
            }
            return false;
        }

        private void CheckForSelfCheckMove(int @fromi, int toi)
        {
            throw new NotImplementedException();
        }

        private bool DoPawnMoveIfLegal(bool pieceIsWhite, int fromi, int toi)
        {
            int moveDistance;
            if (pieceIsWhite)
            {
                moveDistance = fromi - toi;
                if (moveDistance == 8 && !AllPieces[toi]) // pawn moves forward one space and there was no piece in the square
                {
                    WhitePawns[fromi] = false;
                    WhitePawns[toi] = true;
                }

                else if (moveDistance == 16 && !AllPieces[toi] && !AllPieces[toi+8] && (fromi < 56 && fromi > 47 ))//is in second row and moves 2 rows forward
                {
                    WhitePawns[fromi] = false;
                    WhitePawns[toi] = true;
                    WhitePawns[toi] = true;
                }
                else if ((moveDistance == 7 || moveDistance == 9) && AllBlackPieces[toi]) //pawn slanted capture 
                {
                    RemovePeiceAtIndex(toi);
                    WhitePawns[fromi] = false;
                    WhitePawns[toi] = true;
                }
                    //toiDO:En Passant
                else
                {
                    throw new IllegalMoveException(string.Format("The white pawn move from {0} to {1} was not legal", fromi,toi));
                }
            }

            else//piece moved is black
            {
                moveDistance = toi - fromi;
                if (moveDistance == 8 && !AllPieces[toi]) // pawn moves forward one space and there was no piece in the square
                {
                    BlackPawns[fromi] = false;
                    BlackPawns[toi] = true;
                    AllBlackPieces[toi] = true;
                    
                }

                else if (moveDistance == 16 && !AllPieces[toi] && !AllPieces[toi + 8] && (fromi < 23 && fromi > 7))//is in second row and moves 2 rows forward
                {
                    BlackPawns[fromi] = false;
                    BlackPawns[toi] = true;
                    AllBlackPieces[toi] = true;
                }
                else if ((moveDistance == 7 || moveDistance == 9) && AllWhitePieces[toi]) //pawn slanted capture 
                {
                    RemovePeiceAtIndex(toi);
                    BlackPawns[fromi] = false;
                    BlackPawns[toi] = true;
                }
                else
                {
                    throw new IllegalMoveException(string.Format("The black pawn move from {0} to {1} was not legal", fromi, toi));
                }
            }
            return true;//legal move


        }

        /*This removes a peice from the board */
        private void RemovePeiceAtIndex(int index)
        {
            //should this be a set of if statements to save processing power and not loop through the entire array? 
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
