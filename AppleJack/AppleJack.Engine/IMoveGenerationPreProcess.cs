using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleJack.Engine
{
    public interface IMoveGenerationPreProcess
    {
        int[][][][] GetPreProcessedLegalMoves();

    }

    public class MoveGenerationPreProcess : IMoveGenerationPreProcess
    {

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

        private int[][][][] MoveDatabase;
        public MoveGenerationPreProcess()
        {
            MoveDatabase = CreateJaggedArray<int[][][][]>(5,64,8,9); 
            //todo can we make some space memory saving?? a lot of wasted space to accomodate king queen and bishop long move
        }

        public int[][][][] GetPreProcessedLegalMoves()
        {
            throw new NotImplementedException();
        }


        static T CreateJaggedArray<T>(params int[] lengths)
        {
            return (T)InitializeJaggedArray(typeof(T).GetElementType(), 0, lengths);
        }

        static object InitializeJaggedArray(Type type, int index, int[] lengths)
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
