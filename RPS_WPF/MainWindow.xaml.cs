/******************************************************************************
 * Keith Emery
 * IS 253
 * 2014/10/01
 * RPS is a simple rock, paper, scissors game. The program asks the user for
 * his/her choice, gets a random choice for the computer then determines
 * whether the player or the computer has won using the familiar rules of the
 * game. This iteration implements the WPF version of the game by adding it
 * to the solution as a separate project. This version is substantially similar
 * logically to the console and windows form versions of the game and is 
 * primarily for experiencing the WPF environment.
 * 
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPS_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string userChoice;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Rock_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "r";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.computerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_rock.Background = Brushes.AliceBlue;
            toggle_disabled();
        }

        private void btn_Paper_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "p";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.computerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_paper.Background = Brushes.DarkRed;
            btn_paper.Foreground = Brushes.AntiqueWhite;
            toggle_disabled();
        }

        private void btn_scissors_Click(object sender, RoutedEventArgs e)
        {
            userChoice = "s";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.computerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_scissors.Background = Brushes.DarkSeaGreen;
            toggle_disabled();
        }

        private void btn_playAgain_Click(object sender, RoutedEventArgs e)
        {
            btn_rock.ClearValue(Button.BackgroundProperty);
            btn_paper.ClearValue(Button.BackgroundProperty);
            btn_paper.Foreground = Brushes.Black;
            btn_scissors.ClearValue(Button.BackgroundProperty);
            txt_computerChoice.Clear();
            txt_winner.Clear();
            btn_rock.IsEnabled = true;
            btn_paper.IsEnabled = true;
            btn_scissors.IsEnabled = true;
        }

        private void toggle_disabled()
        {
            btn_rock.IsEnabled = false;
            btn_paper.IsEnabled = false;
            btn_scissors.IsEnabled = false;
        }
    }
}
