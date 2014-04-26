using System;
using System.Collections;
using System.Linq;

namespace AppleJack.Engine
{
    public interface IMoveGenerationPreProcess
    {
        int[][][][] GetPreProcessedLegalMoves();

        int[][] GetKingMoveRays(int fromi);
        int[][] GetQueenMoveRays(int fromi);
        int[][] GetBishopMoveRays(int fromi);
        int[][] GetKnightMoveRays(int fromi);
        int[][] GetRookMoveRays(int fromi);
    }

    /*
         
      * Move Ray Creation Rules 
      * 
      * Start by moving positively by the number of squares a piece moves
      * EG king queen rook move one space on the board 0 -> 1 
      * Knight moves 0 -> 10
      * 
      * follow clockwise from that move
      * 
      * 
      * 
      */

    public class MoveGenerationPreProcess : IMoveGenerationPreProcess
    {
        private readonly int[][][][] MoveDatabase;

        public MoveGenerationPreProcess()
        {
            MoveDatabase = CreateJaggedArray<int[][][][]>(5, 64, 8, 7);//5 major pieces, 64 spaces, 8 possible rays, maximum length of 7
          
            Initialize();
        }

        private void Initialize()
        {
            InitalizeAllValues(); //sets all values to -1
            InitializeKing();
            InitializeQueen();
            InitializeBishop();
            InitializeKnight();
            InitializeRook();
        }


        private void InitalizeAllValues()
        {
            for (int index = 0; index < MoveDatabase.Length; index++)
            {
                int[][][] PieceBoards = MoveDatabase[index];
                for (int index1 = 0; index1 < PieceBoards.Length; index1++)
                {
                    int[][] PieceRays = PieceBoards[index1];
                    for (int i1 = 0; i1 < PieceRays.Length; i1++)
                    {
                        int[] ray = PieceRays[i1];
                        for (int index2 = 0; index2 < ray.Length; index2++)
                        {
                            MoveDatabase[index][index1][i1][index2] = -1;
                        }
                    }
                }
            }
        }

        private void InitializeKing()
        {
            int moveLength;
            for (int fromi = 0; fromi < MoveDatabase[0].Length; fromi++)
            {
                //int[] moveDistances = new[] {1, 9, 8, 7, -1, -9, -8, -7};
                int rayIndex = 0;
                int toi = fromi + 1;
                if (toi < 64 && (fromi + 1%8) != 0) //block off board to the right
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }

                toi = fromi + 9;
                if (toi < 64 && ((fromi + 1)%8) != 0) //block slant off to the right or front
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }

                toi = fromi + 8;
                if (toi < 64) //block forward off of the board
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }

                toi = fromi + 7;
                if (toi < 64 && (fromi%8) != 0) //block left forward slant off of the board
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }
                toi = fromi - 1;
                if (toi > -1 && (fromi%8) != 0) //block left move  off of the board
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }
                toi = fromi - 9;
                if (toi > -1 && (fromi%8) != 0) //block left backward slant off of the board
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }
                toi = fromi - 8;
                if (toi > -1) //block left forward slant off of the board
                {
                    MoveDatabase[0][fromi][rayIndex++][0] = toi;
                }
                else
                {
                    rayIndex++;
                }
                toi = fromi - 7;
                if (toi > -1 && (fromi + 1%8) != 0) //block right backward slant off of the board
                {
                    MoveDatabase[0][fromi][rayIndex][0] = toi;
                }
            }
        }

        private void InitializeQueen()
        {
           
            for (int fromi = 0; fromi < MoveDatabase[1].Length; fromi++)
            {
                int rayindex = 0;
                int RayEnd = 0;

                RayEnd = 8 * (fromi/8) + 7;
                int availibleMove = fromi+1;
                int i = 0;
                //positive horizantal move rayintdex = 0
                while(availibleMove <= RayEnd)
                {
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    availibleMove++;
                    i++;
                }

                rayindex++;
                
                // slant positive right rayindex = 1
                availibleMove = fromi;
                i = 0;
                while ((availibleMove+1)%8 != 0 && availibleMove < 55)
                {
                    availibleMove += 9;
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    i++;
                }

                rayindex++;
               
                //postive move vertically rayindex = 2
                i = 0;
                availibleMove = fromi + 8;
                while(availibleMove < 64)
                {
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    availibleMove += 8;
                    i++;
                }

                rayindex++;
                //slant postitive left rayindex = 3
                i = 0;
                
                availibleMove = fromi;
                while((availibleMove)%8 != 0 && availibleMove < 56 )
                {
                    availibleMove += 7;    
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    i++;
                }
                
                rayindex++;
                //horizantal move negative rayindex = 4
                RayEnd = RayEnd = 8 * (fromi / 8);
                availibleMove = fromi - 1;
                i = 0;
                while (availibleMove >= RayEnd)
                {
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    availibleMove -= 1;
                    i++;
                }
                rayindex++;
                //slant negative left rayindex = 5
                availibleMove = fromi;
                
                i = 0;
                while ((availibleMove)%8 != 0 && availibleMove > 8)//this is a tad odd but it seems to work it's 8 to because 9 is the first number that can do a shif this way
                {
                    availibleMove -= 9;
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    i++;
                }
                rayindex++;
                //vertical negative rayindex = 6
                
                availibleMove = fromi - 8;
                i = 0;
                while (availibleMove > -1)
                {
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    i++;
                    availibleMove -= 8;
                }

                rayindex++;
                //slant negative left rayindex = 7
                
                availibleMove = fromi;
                i = 0;
                while ((availibleMove+1)% 8 != 0 && availibleMove > 8)
                {
                    availibleMove -= 7;
                    MoveDatabase[1][fromi][rayindex][i] = availibleMove;
                    i++;
                }




            }
            


        }


        private void InitializeBishop()
        {

            for (int fromi = 0; fromi < MoveDatabase[1].Length; fromi++)
            {
                int rayindex = 0;
              
                int i = 0;
           
               
                // slant positive right rayindex = 0
                
                int availibleMove = fromi;
                i = 0;
                while ((availibleMove + 1) % 8 != 0 && availibleMove < 55)
                {
                    availibleMove += 9;
                    MoveDatabase[2][fromi][rayindex][i] = availibleMove;
                    i++;
                }

                rayindex++;

               
                //slant postitive left rayindex = 1
                i = 0;

                availibleMove = fromi;
                while ((availibleMove) % 8 != 0 && availibleMove < 56)
                {
                    availibleMove += 7;
                    MoveDatabase[2][fromi][rayindex][i] = availibleMove;
                    i++;
                }

                rayindex++;
                
                //slant negative left rayindex = 2
                availibleMove = fromi;

                i = 0;
                while ((availibleMove) % 8 != 0 && availibleMove > 8)//this is a tad odd but it seems to work it's 8 to because 9 is the first number that can do a shif this way
                {
                    availibleMove -= 9;
                    MoveDatabase[2][fromi][rayindex][i] = availibleMove;
                    i++;
                }
                rayindex++;
               
                //slant negative left rayindex = 3

                availibleMove = fromi;
                i = 0;
                while ((availibleMove + 1) % 8 != 0 && availibleMove > 8)
                {
                    availibleMove -= 7;
                    MoveDatabase[2][fromi][rayindex][i] = availibleMove;
                    i++;
                }
            }
            

        }


        private void InitializeKnight()
        {

            for (int fromi = 0; fromi < MoveDatabase[1].Length; fromi++)
            {
                int rayindex = 0;
                int availibleMove = fromi;
                //slant right positive  1 rayindex 0
                if ((fromi + 2)%8 !=0 && (fromi +1) %8 !=0 && fromi < 54)
                {
                    availibleMove += 10;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;

                //slant right positive 2 rayindex = 1
                availibleMove = fromi;
                if ((fromi + 1) % 8 != 0 && fromi < 47)
                {
                    availibleMove += 17;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;

                //slant left positive 1 rayindex = 2
                availibleMove = fromi;
                if ((fromi) % 8 != 0 && fromi < 48)
                {
                    availibleMove += 15;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;

                //slant left positive 1 rayindex = 3
                availibleMove = fromi;
                if ((fromi) % 8 != 0 && (fromi-1) % 8 != 0 && fromi < 56)
                {
                    availibleMove += 6;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;
                
                //slant left negative 1 rayindex = 4
                availibleMove = fromi;
                if ((fromi) % 8 != 0 && (fromi - 1) % 8 != 0 && fromi > 9)
                {
                    availibleMove -= 10;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;

                //slant left negative 2 rayindex = 5
                availibleMove = fromi;
                if ((fromi) % 8 != 0 && fromi > 16)
                {
                    availibleMove -=17;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;


                //slant right negative 1 rayindex = 6
                availibleMove = fromi;
                if ((fromi + 1) % 8 != 0  && fromi > 15)
                {
                    availibleMove -= 15;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
                rayindex++;

                //slant right negative 2 rayindex = 7
                availibleMove = fromi;
                if ((fromi + 2) % 8 != 0 && (fromi + 1) % 8 != 0 && fromi > 8)
                {
                    availibleMove -= 6;
                    MoveDatabase[3][fromi][rayindex][0] = availibleMove;
                }
            }

          
        }


        private void InitializeRook()
        {

            for (int fromi = 0; fromi < MoveDatabase[1].Length; fromi++)
            {
                int rayindex = 0;
                int RayEnd = 0;

                RayEnd = 8*(fromi/8) + 7;
                int availibleMove = fromi + 1;
                int i = 0;
                //positive horizantal move rayintdex = 0
                while (availibleMove <= RayEnd)
                {
                    MoveDatabase[4][fromi][rayindex][i] = availibleMove;
                    availibleMove++;
                    i++;
                }

                rayindex++;

                rayindex++;

                //postive move vertically rayindex = 2
                i = 0;
                availibleMove = fromi + 8;
                while (availibleMove < 64)
                {
                    MoveDatabase[4][fromi][rayindex][i] = availibleMove;
                    availibleMove += 8;
                    i++;
                }

                rayindex++;
                rayindex++;
                //horizantal move negative rayindex = 4
                RayEnd = RayEnd = 8*(fromi/8);
                availibleMove = fromi - 1;
                i = 0;
                while (availibleMove >= RayEnd)
                {
                    MoveDatabase[4][fromi][rayindex][i] = availibleMove;
                    availibleMove -= 1;
                    i++;
                }
                rayindex++;
                rayindex++;
                //vertical negative rayindex = 6

                availibleMove = fromi - 8;
                i = 0;
                while (availibleMove > -1)
                {
                    MoveDatabase[4][fromi][rayindex][i] = availibleMove;
                    i++;
                    availibleMove -= 8;
                }

               
            }
        }


        public int[][][][] GetPreProcessedLegalMoves()
        {
            return MoveDatabase;
        }

        public int[][] GetKingMoveRays(int fromi)
        {
            return MoveDatabase[0][fromi];
        }

        public int[][] GetQueenMoveRays(int fromi)
        {
            return MoveDatabase[1][fromi];
        }

        public int[][] GetBishopMoveRays(int fromi)
        {
            return MoveDatabase[2][fromi];
        }

        public int[][] GetKnightMoveRays(int fromi)
        {
            return MoveDatabase[3][fromi];
        }

        public int[][] GetRookMoveRays(int fromi)
        {
            return MoveDatabase[4][fromi];
        }
        /*If move is illegal return null*/
        public int[] TestMove(ChessPeiceType type, int fromi, int toi)
        {
            switch (type)
            {
                case ChessPeiceType.BlackKing:
                case ChessPeiceType.WhiteKing:
                    int[][] kingRays = GetKingMoveRays(fromi);
                    int length = kingRays.Length/2;
                    if (fromi < toi)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < kingRays[i].Length; j++)
                            {
                                if (kingRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (kingRays[i][j] == toi)
                                {
                                    return kingRays[i];
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = length; i < kingRays.Length; i++)
                        {
                            for (int j = 0; j < kingRays[i].Length; j++)
                            {

                                if (kingRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (kingRays[i][j] == toi)
                                {
                                    return kingRays[i];
                                }
                            }
                        }
                    }
                    return null;
                case ChessPeiceType.BlackQueen:
                case ChessPeiceType.WhiteQueen:
                    int[][] queenRays = GetQueenMoveRays(fromi);
                    length = queenRays.Length/2;
                    if (fromi < toi)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < queenRays[i].Length; j++)
                            {

                                if (queenRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (queenRays[i][j] == toi)
                                {
                                    return queenRays[i];
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = length; i < queenRays.Length; i++)
                        {
                            for (int j = 0; j < queenRays[i].Length; j++)
                            {
                                if (queenRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (queenRays[i][j] == toi)
                                {
                                    return queenRays[i];
                                }
                            }
                        }
                    }
                    return null;
                case ChessPeiceType.BlackBishop:
                case ChessPeiceType.WhiteBishop:
                    int[][] bishopRays = GetBishopMoveRays(fromi);
                    length = bishopRays.Length/4;
                    if (fromi < toi)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < bishopRays[i].Length; j++)
                            {

                                
                                if (bishopRays[i][j] == -1)
                                {
                                    break;
                                }
                            
                                if (bishopRays[i][j] == toi)
                                {
                                    return bishopRays[i];
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = length; i < bishopRays.Length; i++)
                        {
                            for (int j = 0; j < bishopRays[i].Length; j++)
                            {
                                if (bishopRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (bishopRays[i][j] == toi)
                                {
                                    return bishopRays[i];
                                }
                            }
                        }
                    }
                    return null;
                case ChessPeiceType.BlackKnight:
                case ChessPeiceType.WhiteKnight:
                    int[][] knightRays = GetKnightMoveRays(fromi);
                    length = knightRays.Length/2;
                    if (fromi < toi)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < knightRays[i].Length; j++)
                            {


                                if (knightRays[i][j] == -1)
                                {
                                    break;
                                }

                                if (knightRays[i][j] == toi)
                                {
                                    return knightRays[i];
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = length; i < knightRays.Length; i++)
                        {
                            for (int j = 0; j < knightRays[i].Length; j++)
                            {
                                if (knightRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (knightRays[i][j] == toi)
                                {
                                    return knightRays[i];
                                }
                            }
                        }
                    }
                    return null;
                case ChessPeiceType.BlackRook:
                case ChessPeiceType.WhiteRook:
                    int[][] rookRays = GetRookMoveRays(fromi);
                    length = rookRays.Length / 2;
                    if (fromi < toi)
                    {
                        for (int i = 0; i < length; i+=2)
                        {
                            for (int j = 0; j < rookRays[i].Length; j++)
                            {


                                if (rookRays[i][j] == -1)
                                {
                                    break;
                                }

                                if (rookRays[i][j] == toi)
                                {
                                    return rookRays[i];
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = length; i < rookRays.Length; i += 2)
                        {
                            for (int j = 0; j < rookRays[i].Length; j++)
                            {
                                if (rookRays[i][j] == -1)
                                {
                                    break;
                                }
                                if (rookRays[i][j] == toi)
                                {
                                    return rookRays[i];
                                }
                            }
                        }
                    }
                    return null;
                default:
                    return null;
            }
            
        }


        private static T CreateJaggedArray<T>(params int[] lengths)
        {
            return (T) InitializeJaggedArray(typeof (T).GetElementType(), 0, lengths);
        }

        private static object InitializeJaggedArray(Type type, int index, int[] lengths)
        {
            Array array = Array.CreateInstance(type, lengths[index]);
            Type elementType = type.GetElementType();

            if (elementType != null)
            {
                for (int i = 0; i < lengths[index]; i++)
                {
                    array.SetValue(
                        InitializeJaggedArray(elementType, index + 1, lengths), i);
                }
            }

            return array;
        }
    }
}
