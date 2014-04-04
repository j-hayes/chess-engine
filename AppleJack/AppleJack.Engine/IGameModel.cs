using System.Collections;

namespace AppleJack.Engine
{
    public interface IGameModel
    {
         BitArray AllPieces{ get;  }
       

         BitArray AllWhitePieces{ get;  }


        BitArray AllBlackPieces { get; }
       
        BitArray WhitePawns { get;  }


        BitArray BlackPawns { get;  }

        BitArray WhiteRooks { get;  }
        BitArray WhiteKnights { get;  }
        BitArray WhiteBishops { get;  }

        BitArray WhiteQueens { get;  }


        BitArray WhiteKing { get;  }



        BitArray BlackRooks { get;  }
       
        BitArray BlackKnights { get;  }


        BitArray BlackBishops { get;  }

        BitArray BlackQueens { get;  }
        BitArray BlackKing { get;  }

        int PieceTypeCount { get; }

        bool TryMove(int squaretoMovefromi, int squaretoMovetoi);
    }
}
