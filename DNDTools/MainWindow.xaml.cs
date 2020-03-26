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

namespace DNDTools {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public int diceRollVal = 1;

        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonDiceRoll_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Generates a random value (1-n)
             * where n is the maximum value of the selected die
             * The value then changes the button text and sends
             * a message to the chat log
             */

            int diceMax = 20;       //Max value set to 20 as default, will change in the future

            Random rngDice = new Random();
            diceRollVal = (int)(rngDice.NextDouble() * diceMax) + 1;

            btnDice.Content = diceRollVal;

            Chatlog.Content = Chatlog.Content + "\n> Player has rolled a " + diceRollVal;
            Chatlog.ScrollToEnd();
        }

        private void ButtinDiceMaxChange_Click(object sender, RoutedEventArgs e)
        {
            /*  
             * Make a new menu open up
             * Allows Player to choose the different types of dice
             */ 


        }

        private void ButtonEndTurn_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Ends the turn for the current player
             * Should reset the dice roll
             */

            btnDice.Content = "Dice Roll";

            Chatlog.Content = Chatlog.Content + "\n> Player 1's turn has ended. Player 2's turn begins.";
            Chatlog.ScrollToEnd();
        }

        private void ButtonEndGame_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Shows a new window to end the game
             */
            endGame frmEndGame = new endGame(this);

            frmEndGame.Show();
        }
    }
}
