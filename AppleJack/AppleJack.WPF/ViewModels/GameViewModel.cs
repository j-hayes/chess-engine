using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using AppleJack.Engine;
using AppleJack.WPF.Commands;
using AppleJack.WPF.Models;

namespace AppleJack.WPF.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        private DelegateCommand _exitCommand;

        private IGameModel _theGame;
        private string _printToScreen;
        private ObservableCollection<ChessGridItem> _theBoard;
        private const string White = "White";
        private const string Black = "Black";

        private const string DarkSquare = "SaddleBrown";
        private const string LightSquare = "SandyBrown";


        private const string Pawn = "P";
        private const string Rook = "R";
        private const string Knight = "k";
        private const string Bishop = "B";
        private const string Queen = "Q";
        private const string King = "K";


        public string PrintToScreen
        {
            get { return _printToScreen; }
            set
            {
                _printToScreen = value;
                OnPropertyChanged("PrintToScreen");
            }
        }


        public ObservableCollection<ChessGridItem> TheBoard

        {
            get { return _theBoard; }
            set
            {
                _theBoard = value;
                OnPropertyChanged("TheBoard");
            }
        }

        public GameViewModel(bool playerIsWhite)
        {

            _theGame = new GameModel();
            ChessGridItem[] items = new ChessGridItem[64];

          
            bool switcher = true;

            PrintToScreen = "Welcome Make Your Move";
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new ChessGridItem {Index = i};
                if (switcher)
                {
                    items[i].SquareColor = LightSquare;
                }
                else
                {
                    items[i].SquareColor = DarkSquare;
                }
                //items[i].PieceColor = "Red";
                if (_theGame.AllPieces[i]) // can this block be refactored to be the refresh board it needs to be a //
                    //loop but this may be a method that the larger method uses
                {
               
                    if (_theGame.AllWhitePieces[i])
                    {
                        items[i].PieceColor = White;
                        if (_theGame.WhitePawns[i])
                        {
                            items[i].PieceShape = Pawn;
                        }
                        else if(_theGame.WhiteRooks[i])
                        {
                            items[i].PieceShape = Rook;
                        }
                        else if(_theGame.WhiteKnights[i])
                        {
                            items[i].PieceShape = Knight;
                        }
                        else if(_theGame.WhiteBishops[i])
                        {
                            items[i].PieceShape = Bishop;
                        }
                        else if(_theGame.WhiteQueens[i])
                        {
                            items[i].PieceShape = Queen;
                        }
                        else if (_theGame.WhiteKing[i])
                        {
                            items[i].PieceShape = King;
                        }
                        else
                        {
                            throw new Exception("White Bit Board Showed Piece Existed But No matching piece found in White piece bitboards");
                        }

                    }
                    else if(_theGame.AllBlackPieces[i])
                    {
                        items[i].PieceColor = Black;

                        if (_theGame.BlackPawns[i])
                        {
                            items[i].PieceShape = Pawn;
                        }
                        else if (_theGame.BlackRooks[i])
                        {
                            items[i].PieceShape = Rook;
                        }
                        else if (_theGame.BlackKnights[i])
                        {
                            items[i].PieceShape = Knight;
                        }
                        else if (_theGame.BlackBishops[i])
                        {
                            items[i].PieceShape = Bishop;
                        }
                        else if (_theGame.BlackQueens[i])
                        {
                            items[i].PieceShape = Queen;
                        }
                        else if (_theGame.BlackKing[i])
                        {
                            items[i].PieceShape = King;
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


        public void LeftButtonDownInSquare(string id)//rename this variable todo:
        {
             SquareToMoveFrom = int.Parse(id);
            PrintToScreen = id;



        }

        private int SquareToMoveFrom { get; set; }
        private int SquareToMoveTo { get; set; }

        public void LeftButtonUpInSquare(string id)
        {
            PrintToScreen = id;
            SquareToMoveTo = int.Parse(id);
            bool result = _theGame.TryMove(SquareToMoveFrom, SquareToMoveTo);
            if (result)
            {
                UpdateBoard();
            }
            else
            {
                PrintToScreen = "error";
            }


        }

        private void UpdateBoard()
        {
            int index;
            foreach (var chessGridItem in TheBoard)
            {
                chessGridItem.PieceShape = "";
                index = chessGridItem.Index;
                if (_theGame.AllPieces[index])
                {

                    if (_theGame.AllWhitePieces[index])
                    {
                        chessGridItem.PieceColor = White;
                        if (_theGame.WhitePawns[index])
                        {
                            chessGridItem.PieceShape = Pawn;
                        }
                        else if (_theGame.WhiteRooks[index])
                        {
                            chessGridItem.PieceShape = Rook;
                        }
                        else if (_theGame.WhiteKnights[index])
                        {
                            chessGridItem.PieceShape = Knight;
                        }
                        else if (_theGame.WhiteBishops[index])
                        {
                            chessGridItem.PieceShape = Bishop;
                        }
                        else if (_theGame.WhiteQueens[index])
                        {
                            chessGridItem.PieceShape = Queen;
                        }
                        else if (_theGame.WhiteKing[index])
                        {
                            chessGridItem.PieceShape = King;
                        }


                    }
                    else if (_theGame.AllBlackPieces[index])
                    {
                        chessGridItem.PieceColor = Black;
                        if (_theGame.BlackPawns[index])
                        {
                            chessGridItem.PieceShape = Pawn;
                        }
                        else if (_theGame.BlackRooks[index])
                        {
                            chessGridItem.PieceShape = Rook;
                        }
                        else if (_theGame.BlackKnights[index])
                        {
                            chessGridItem.PieceShape = Knight;
                        }
                        else if (_theGame.BlackBishops[index])
                        {
                            chessGridItem.PieceShape = Bishop;
                        }
                        else if (_theGame.BlackQueens[index])
                        {
                            chessGridItem.PieceShape = Queen;
                        }
                        else if (_theGame.BlackKing[index])
                        {
                            chessGridItem.PieceShape = King;
                        }
                    }
                }
            }
            OnPropertyChanged("TheBoard");
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

    public class ChessGridItem : INotifyPropertyChanged
    {
        private string _pieceShape;
        private string _pieceColor;
        private string _squareColor;
        private int _index;

        public string PieceShape
        {
            get { return _pieceShape; }
            set
            {
                _pieceShape = value;
                OnPropertyChanged();
            }
        }

        public string PieceColor
        {
            get { return _pieceColor; }
            set
            {
                _pieceColor = value;
                OnPropertyChanged();
            }
        }

        public string SquareColor
        {
            get { return _squareColor; }
            set
            {
                _squareColor = value; 
                OnPropertyChanged();
            }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; OnPropertyChanged(); }
        } 

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            string s = propertyName;
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
