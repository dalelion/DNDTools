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
using System.Windows.Shapes;

namespace DNDTools
{
    /// <summary>
    /// Interaction logic for endGame.xaml
    /// </summary>
    public partial class endGame : Window
    {
        MainGame parent;

        public endGame(MainGame myParent)
        {
            InitializeComponent();

            parent = myParent;
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonLeave_Click(object sender, RoutedEventArgs e)
        {
            parent.Close();
            this.Close();
        }
    }
}
