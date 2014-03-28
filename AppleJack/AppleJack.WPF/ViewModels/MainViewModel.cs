using System;
using System.Text;
using System.Windows;
using System.Windows.Input;
using AppleJack.Views;
using AppleJack.WPF.Commands;
using AppleJack.WPF.Models;
using AppleJack.WPF.Views;

namespace AppleJack.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private DelegateCommand _exitCommand;
        private DelegateCommand _newGameWhiteCommand;
        private DelegateCommand _newGameBlackCommand;


        #region Constructor
        public MainViewModel()
        {
          
        }

        #endregion

        #region Properties

        public const string WelcomeMessage = "Would you like to play a board";

        #endregion

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
            Application.Current.Shutdown();
        }

        public ICommand NewGameWhiteCommand
        {
            get
            {
                if (_newGameWhiteCommand == null)
                {
                    _newGameWhiteCommand = new DelegateCommand(StartNewGameWhite);
                }
                return _newGameWhiteCommand;
            }
        }

        public ICommand NewGameWhiteBlack
        {
            get
            {
                if (_newGameBlackCommand == null)
                {
                    _newGameBlackCommand = new DelegateCommand(StartNewGameBlack);
                }
                return _newGameBlackCommand;
            }
        }

        private void StartNewGameBlack()
        {
            StartNewGame(false);
        }

        private void StartNewGameWhite()
        {
            StartNewGame(true);
        }

        private void StartNewGame(bool playerIsWhite)
        {
            var gameView = new GameView(new GameViewModel(true));
            gameView.Show();

        }



        


    }

}
