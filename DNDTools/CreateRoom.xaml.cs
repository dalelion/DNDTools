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
            string[] account = { RoomName.Text , lblRoomCodeValue.ContentStringFormat };
            System.IO.File.WriteAllLines(@"C: /Users/" + Environment.UserName + "/source/repos/DNDTools/Account.txt", account);
        }
    }
}
