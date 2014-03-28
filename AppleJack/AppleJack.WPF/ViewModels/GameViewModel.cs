using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using AppleJack.WPF.Commands;
using AppleJack.WPF.Models;

namespace AppleJack.WPF.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        private DelegateCommand _exitCommand;


        private IGameModel _theGame;

        public string SquareSelected { get; set; }

        public ObservableCollection<ChessGridItem> TheBoard
        {
            get;
            set;
        }

        public GameViewModel(bool playerIsWhite)
        {

            _theGame = new GameModel();
            ChessGridItem[] items = new ChessGridItem[64];

            string white = "White";
            string black = "Black";

            string darkSquare = "SaddleBrown";
            string lightSquare = "SandyBrown";
            bool switcher = true;

            SquareSelected = "None Selected";
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ChessGridItem();
                items[i].Index = i;
                if (switcher)
                {
                    items[i].SquareColor = lightSquare;
                }
                else
                {
                    items[i].SquareColor = darkSquare;
                }
                //items[i].PieceColor = "Red";
                if (_theGame.AllPieces[i])
                {
                    items[i].PieceColor = white;
                    if (_theGame.WhitePieces[i])
                    {
                        if (_theGame.WhitePawns[i])
                        {
                            items[i].PieceShape = "P";
                        }
                        else if(_theGame.WhiteRooks[i])
                        {
                            items[i].PieceShape = "R";
                        }
                        else if(_theGame.WhiteKnights[i])
                        {
                            items[i].PieceShape = "N";
                        }
                        else if(_theGame.WhiteBishops[i])
                        {
                            items[i].PieceShape = "B";
                        }
                        else if(_theGame.WhiteQueens[i])
                        {
                            items[i].PieceShape = "Q";
                        }
                        else if (_theGame.WhiteKing[i])
                        {
                            items[i].PieceShape = "K";
                        }
                        else
                        {
                            throw new Exception("White Bit Board Showed Piece Existed But No matching piece found in White piece bitboards");
                        }

                    }
                    else if(_theGame.BlackPieces[i])
                    {
                        items[i].PieceColor = black;

                        if (_theGame.BlackPawns[i])
                        {
                            items[i].PieceShape = "P";
                        }
                        else if (_theGame.BlackRooks[i])
                        {
                            items[i].PieceShape = "R";
                        }
                        else if (_theGame.BlackKnights[i])
                        {
                            items[i].PieceShape = "N";
                        }
                        else if (_theGame.BlackBishops[i])
                        {
                            items[i].PieceShape = "B";
                        }
                        else if (_theGame.BlackQueens[i])
                        {
                            items[i].PieceShape = "Q";
                        }
                        else if (_theGame.BlackKing[i])
                        {
                            items[i].PieceShape = "K";
                        }
                        else
                        {
                            throw new Exception("Black Bit Board Showed Piece Existed But No matching piece found in Black piece bitboards");
                        }
                    }

                }

            if ((i+1)%8 != 0 || i==0)
                {
                    switcher = !switcher;
                }
                items[i].Index = i;

            }
            TheBoard = new ObservableCollection<ChessGridItem>(items);
     
        }


        public void LeftButtonDownInSquare(string id)
        {
             SquareToMoveFrom = int.Parse(id);




        }

        private int SquareToMoveFrom { get; set; }
        private int SquareToMoveTo { get; set; }

        public void LeftButtonUpInSquare(string id)
        {
            SquareToMoveTo = int.Parse(id);
            _theGame.TryMove(SquareToMoveFrom, SquareToMoveTo);
          

        }

        private void UpdateBoard()
        {
            OnPropertyChanged(TheBoard);
        }


        public ICommand ExitCommand
        {
            get
            {
                if (_exitCommand == null)
                {
                    _exitCommand = new DelegateCommand(Exit);
                }
                return _exitCommand;
            }
        }

        private void Exit()
        {
            throw new NotImplementedException();
        }

    }

    public class ChessGridItem
    {

        public string PieceShape { get; set; }
        public string PieceColor { get; set; }
        public string SquareColor { get; set; }
        public int Index { get; set; }

    }
}
