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

        /// <summary>
        /// Detects when user hits enter key to signal inpout of a command or text to the chat. Can be expanded on in the future.
        /// </summary>
        /// <param name="sender">Eventually will contain info about who the request is from for username information</param>
        /// <param name="e">The key that is pressed. We are looking for the enter key, others can be used here</param>
        private void Chatbox_KeyDown( object sender, KeyEventArgs e ) {

            if (e.Key.Equals(Key.Enter)) { //User submitted request

                if ( Chatbox.Text.StartsWith( "/" ) ) { //Request is a command
                    ProcessCommand( Chatbox.Text.ToLower().Split() );
                } else { //Request is a chat message

                }

                //TODO: @Noah - I want to allow users to hit up and be able to reselect old requests they entered during this session. This will require storing this info before clearning.
                Chatbox.Text = ""; //Clear chatbox after input is dealt with

            }

        }

        private static void ProcessCommand(String[] Command) {

            /*switch ( Command[0] ) {

                case "/help":
                    //TODO: @Noah Display commands available to users. Future work to implement this and add more commands
                    break;
                case "/roll":

                    break;
                default:
                    break;

            }*/

            if ( Command[0].Equals("/roll") && Command[1].Contains('d')) { //temporary rigging to make only /roll work since other commands arent implemented.
                String[] DiceRoll = Command[1].Split( 'd' );
                StringBuilder SB = new StringBuilder();
                for (int i = 0; i < Int32.Parse(DiceRoll[0]); i++ ) {
                    //SB.Append();
                    //TODO: @Noah Display each dice roll seperated by +'s and the sum in the chat log.
                }

            }


        }

        /// <summary>
        /// Rolls dice with specified Number of Sides
        /// </summary>
        /// <param name="NumSides">How many sides you want the dice being rolled to have.</param>
        /// <returns>Random number between 1 and NumSides</returns>
        private static int DiceRoll(int NumSides) {

            return new Random().Next( 1, NumSides + 1 );

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
