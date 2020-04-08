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
    /// Interaction logic for RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Window
    {
        MainWindow parent;

        public RoomPage()
        {
            InitializeComponent();
        }

        public RoomPage(MainWindow myParent)
        {
            InitializeComponent();

            parent = myParent;
        }

        private void ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            String code = RoomCode.Text;

            if (code.CompareTo("1234") == 0)
            {
                MainGame game = new MainGame();
                game.Show();
                parent.Close();
                this.Close();
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();

            this.Close();
        }
    }
}
