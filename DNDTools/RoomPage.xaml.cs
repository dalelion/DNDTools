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

            string[] savedRoom = System.IO.File.ReadAllLines(@"C: /Users/" + Environment.UserName + "/source/repos/DNDTools/Room.txt");

            if (code.CompareTo(savedRoom[1]) == 0)
            {
                MainGame game = new MainGame();
                game.Show();
                parent.Close();
                this.Close();
            }
            else 
            {
                MessageBox.Show("The room code does not exist.", "Failed to connect to room", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void KeyBoardConnect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ButtonConnect_Click(sender, e);
            }
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();

            this.Close();
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            CreateRoom newRoom = new CreateRoom(this);

            newRoom.Show();

            this.Visibility = Visibility.Hidden;
            parent.Close();
        }
    }
}
