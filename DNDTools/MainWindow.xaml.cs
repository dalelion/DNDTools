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

            Button btnDiceRoll = (Button)sender;
            Random rngDice = new Random(20);        //Set to 20 on default, will change based on selected dice
            diceRollVal = rngDice.Next() + 1;

            btnDiceRoll.Text = diceRollVal;
        }

        private static readonly DependencyProperty changeTextProperty = DependencyProperty.Register("changeText", typeof(String), typeof(MainWindow));

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*  
             * Make a new menu open up
             * Allows Player to choose the different types of dice
             */ 
        }
    }
}
