using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Converters;

namespace AppleJack.WPF.Models
{
    public class GameModel : IGameModel
    {
        /*
         a board bit board is below 
         * 0th bitarray is 
         */
        public BitArray[] board {get;set;}

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

        public BitArray WhitePieces
        {
            get { return board[1]; }
        }

        public BitArray BlackPieces
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

        public bool TryMove(int from, int to)
        {
            // todo: think about roll back strategy? 

            if (AllPieces[from])
            {
                if (WhitePieces[from])
                {
                    if (WhitePawns[from])
                    {
                        WhitePawns[from] = false;
                        WhitePawns[to] = true;//this is oversimplified
                        
                    }
                }
                else if (BlackPieces[from])
                {
                    if (BlackPawns[from])
                    {
                        BlackPawns[from] = false;
                        BlackPawns[to] = true; //oversimplified should be checked obviously
                    }
                }
            }





            AllPieces[to] = true;
            throw new NotImplementedException();
        }
    }
}
