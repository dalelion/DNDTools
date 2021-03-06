﻿using System;
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
    /// Interaction logic for MainGame.xaml
    /// </summary>
    public partial class MainGame : Window {

        static string[] savedAccount = System.IO.File.ReadAllLines(@"C: /Users/" + Environment.UserName + "/source/repos/DNDTools/Account.txt");
        private int diceRollVal = 1;

        Player player = new Player(savedAccount[0]);

        public MainGame() {

                InitializeComponent();
                
                this.Title = "Welcome to " + player.getName() + "'s Dungeon";
                
                //Changes the text in Character info to match the Character's Stats
                StrLbl.Content = "" + player.getBaseStat(0);
                DexLbl.Content = "" + player.getBaseStat(1);
                ConLbl.Content = "" + player.getBaseStat(2);
                IntLbl.Content = "" + player.getBaseStat(3);
                WisLbl.Content = "" + player.getBaseStat(4);
                ChaLbl.Content = "" + player.getBaseStat(5);

                lblArmor.Content = player.getArmor();
                lblSpeed.Content = player.getSpeed();

                //Changes the text in Character info to match the character's changing stats
                if (player.getVariableStat(0) > 0)
                    StrVarLbl.Content = "(+" + player.getVariableStat(0) + ")";
                else
                    StrVarLbl.Content = "(" + player.getVariableStat(0) + ")";

                if (player.getVariableStat(1) > 0)
                {
                    DexVarLbl.Content = "(+" + player.getVariableStat(1) + ")";
                    lblInitiative.Content = "+" + player.getVariableStat(1);
                }
                else
                {
                    DexVarLbl.Content = "(" + player.getVariableStat(1) + ")";
                    lblInitiative.Content = player.getVariableStat(1);
                }

                if (player.getVariableStat(2) > 0)
                    ConVarLbl.Content = "(+" + player.getVariableStat(2) + ")";
                else
                    ConVarLbl.Content = "(" + player.getVariableStat(2) + ")";

                if (player.getVariableStat(3) > 0)
                    IntVarLbl.Content = "(+" + player.getVariableStat(3) + ")";
                else
                    IntVarLbl.Content = "(" + player.getVariableStat(3) + ")";

                if (player.getVariableStat(3) > 0)
                    WisVarLbl.Content = "(+" + player.getVariableStat(4) + ")";
                else
                    WisVarLbl.Content = "(" + player.getVariableStat(4) + ")";

                if (player.getVariableStat(5) > 0)
                    ChaVarLbl.Content = "(+" + player.getVariableStat(5) + ")";
                else
                    ChaVarLbl.Content = "(" + player.getVariableStat(5) + ")";
            
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

            Chatlog.Content = Chatlog.Content + "\n> " + player.getName() + " has rolled a " + diceRollVal;
            Chatlog.ScrollToEnd();
        }

        private void ButtonEndTurn_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Ends the turn for the current player
             * Should reset the dice roll
             */

            btnDice.Content = "Dice Roll";

            Chatlog.Content = Chatlog.Content + "\n> " + player.getName() + "'s turn has ended. Player 2's turn begins.";
            Chatlog.ScrollToEnd();
        }

        /// <summary>
        /// Detects when user hits enter key to signal inpout of a command or text to the chat. Can be expanded on in the future.
        /// </summary>
        /// <param name="sender">Eventually will contain info about who the request is from for username information</param>
        /// <param name="e">The key that is pressed. We are looking for the enter key, others can be used here</param>
        private void Chatbox_KeyDown( object sender, KeyEventArgs e ) {

            if (e.Key.Equals(Key.Enter) && Chatbox.Text != "" ) { //User submitted request

                if ( Chatbox.Text.StartsWith( "/" ) ) { //Request is a command
                    Chatlog.Content += ProcessCommand( Chatbox.Text.ToLower().Split() );
                } else { //Request is a chat message
                    Chatlog.Content = Chatlog.Content + "\n" + Chatbox.Text; //TODO: @Ruiming this is where I moved your chat events to.
                    Chatbox.Text = "";
                }

                //TODO: @Noah - I want to allow users to hit up and be able to reselect old requests they entered during this session. This will require storing this info before clearning.
                Chatbox.Text = ""; //Clear chatbox after input is dealt with

                Chatlog.ScrollToEnd();

            }

        }

        /// <summary>
        /// Processes request by the user.
        /// </summary>
        /// <param name="Command">Text command starting with '/'</param>
        /// <returns>Command output or error message.</returns>
        private String ProcessCommand(String[] Command) {
            switch ( Command[0] ) {
                case "/help":
                    return "\nThe command system is still under construction! -> Dice Rolling is available (ex. '/roll 3d6')";
                case "/roll":
                    if ( Command[1].Contains( 'd' ) ) {
                        String[] DiceCommand = Command[1].Split( 'd' );
                        Int32[] NumbersRolled = new Int32[Int32.Parse( DiceCommand[0] )];
                        for ( int i = 0; i < Int32.Parse( DiceCommand[0] ); i++ ) {
                            NumbersRolled[i] = DiceRoll( Int32.Parse( DiceCommand[1] ) );
                        }
                        return "\n> " + player.getName() + $" rolled {Command[1]} -> " + String.Join( " + ", NumbersRolled ) + $" = {NumbersRolled.Sum()}";
                    }
                    return "\nTry again: /roll [NumOfDice]d[NumOfSides]";
                //Add more cases for new commands here
                default:
                    return "\n*Error*: Command not recognized.";
            }
        }

        private static Random DiceRandomizer = new Random( DateTime.Now.Millisecond );

        /// <summary>
        /// Rolls dice with specified Number of Sides
        /// </summary>
        /// <param name="NumSides">How many sides you want the dice being rolled to have.</param>
        /// <returns>Random number between 1 and NumSides</returns>
        private static int DiceRoll(int NumSides) {

            return DiceRandomizer.Next( 1, NumSides + 1 );

        }


        private void ButtonEndGame_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Shows a new window to end the game
             */

            endGame endGameWindow = new endGame(this);

            endGameWindow.Show();
            btnEnd.IsEnabled = false;
        }

        private void TextboxNote_KeyDown(object sender, KeyEventArgs e)
        {
            /* 
             * Chat system, press Enter to paste onto the chatlog
             */

            if (e.Key == Key.Enter && PlayerNotes.Text != "")
            {
                WrittenNotes.Content = WrittenNotes.Content + "\n" + PlayerNotes.Text;
                PlayerNotes.Text = "";
                WrittenNotes.ScrollToEnd();
            }
        }

        private void ButtonInfo_Click(object sender, RoutedEventArgs e)
        {
            /*
             * Opens a new window for the player to view their stats, can keep open or close
             */

            CharacterInfo characterInfo = new CharacterInfo(this, player);

            characterInfo.Show();
        }

        private void ButtonOption_Click(object sender, RoutedEventArgs e)
        {
            new Window().Show();
        }
    }
}
