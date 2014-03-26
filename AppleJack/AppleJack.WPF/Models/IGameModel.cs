using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AppleJack.WPF.Models
{
    internal interface IGameModel
    {
         BitArray AllPieces{ get;  }
       

         BitArray WhitePieces{ get;  }


         BitArray BlackPieces { get; }
       
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

    }
}
