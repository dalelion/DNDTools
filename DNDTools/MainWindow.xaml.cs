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

            Button btnDiceRoll = (Button)sender;
            Random rngDice = new Random();
            diceRollVal = (int)(rngDice.NextDouble() * diceMax) + 1;

            btnDiceRoll.Content = diceRollVal;

            Chatlog.Content = Chatlog.Content + "\nPlayer has rolled a " + diceRollVal;
        }

        private static readonly DependencyProperty changeTextProperty = DependencyProperty.Register("changeText", typeof(String), typeof(MainWindow));

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
        }

    }
}
