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
        public MainWindow() {
            InitializeComponent();
        }

        private int Button_Click(object sender, RoutedEventArgs e)
        {
            int diceRollVal = 1;

            /*
             * Generates a random value (1-n)
             * where n is the maximum value of the selected die
             * The value then changes the button text and sends
             * a message to the chat log
             */

            return diceRollVal;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            /*  
             * Make a new menu open up
             * Allows Player to choose the different types of dice
             */ 
        }
    }
}
