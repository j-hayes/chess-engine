using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AppleJack.WPF.ViewModels;

namespace AppleJack.Views
{
    /// <summary>
    /// Interaction logic for GameView.xaml
    /// </summary>
    public partial class GameView : Window
    {
        public GameView()
        {
            InitializeComponent();
        }

        public GameView(GameViewModel gameViewModel)
        {

            this.DataContext = gameViewModel;
            InitializeComponent();
        }


        private void UIElement_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((Grid) sender).Background = Brushes.Teal;
            ((GameViewModel) this.DataContext).LeftButtonDownInSquare(((Grid)sender).Uid);

        }

        private void UIElement_OnMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((Grid)sender).Background = Brushes.Purple;
            ((GameViewModel)this.DataContext).LeftButtonUpInSquare(((Grid)sender).Uid);
        }
    }
}
