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
    /// Interaction logic for CreateRoom.xaml
    /// </summary>
    public partial class CreateRoom : Window
    {
        RoomPage parent;

        public CreateRoom(RoomPage myParent)
        {
            InitializeComponent();

            parent = myParent;
        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            parent.Show();

            this.Close();
        }

        private void KeyboardEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                ButtonCreate_Click(sender, e);
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (RoomName.Text.Length == 0)
            {
                MessageBox.Show("You must have a room name.", "Cannot create room", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Random rngRoomCode = new Random();
                int roomCode = (int)(rngRoomCode.NextDouble() * 10000);

                lblRoomCodeValue.Content = "" + roomCode;

                string[] room = { RoomName.Text, lblRoomCodeValue.Content.ToString() };
                System.IO.File.WriteAllLines(@"C: /Users/" + Environment.UserName + "/source/repos/DNDTools/Room.txt", room);

                MessageBox.Show("Your room has been successfully made." +
                                "\n" + 
                                "\nYour room name: " + RoomName.Text + 
                                "\nYour room code: " + lblRoomCodeValue.Content.ToString(), "Created your room", MessageBoxButton.OK);

                MainGame mainGame = new MainGame();
                mainGame.Show();

                this.Close();
                parent.Close();
            }
        }
    }
}
