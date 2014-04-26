using System;

using AppleJack.Engine;

namespace AppleJack.Console
{
    public class CommandLineMoveTest
    {
        private static void Main()
        {
            IMoveGenerationPreProcess preProcess;
            int[][][][] database;

            preProcess = new MoveGenerationPreProcess();
            database = preProcess.GetPreProcessedLegalMoves();

            string input = "";
            string[] args;

            int type = 0;
            int fromi = 0;
            int toi = 0;

            while (input != "exit")
            {
               System.Console.WriteLine("Enter a piece value combination in the form piece type, from index, to index " +
                                  "\n EG: Q,0,1");
                input = System.Console.ReadLine();

                args = input.Split(',');
                type = TypeToIndex(args[0]);
                fromi = int.Parse(args[1]);
                toi = int.Parse(args[2]);

                int[][] Rays = database[type][fromi];

                bool found = false;
                foreach (int[] ray in Rays)
                {
                    foreach (int i in ray)
                    {
                        if (i == toi)
                        {
                            System.Console.WriteLine(String.Format("Peice Can Move from: {0}, to {1}", fromi, toi));
                            found = true;
                        }
                        if (i == -1)
                        {
                            break;
                        }
                    }
                }
                if (!found)
                {
                    System.Console.WriteLine(String.Format("Peice Cannot Move from: {0}, to {1}", fromi, toi));

                }

            }


        }

        private static int TypeToIndex(string typeString)
        {
            switch (typeString)
            {
                case "K":
                    return 0;

                case "Q":
                    return 1;

                case "B":
                    return 2;

                case "k":
                    return 3;

                case "R":
                    return 4;
                default:
                    return -1;

            }



        }
    }
}
