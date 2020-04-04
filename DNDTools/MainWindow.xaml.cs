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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean canLogIn = false;
        String userName = "";
        String passWord = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            userName = UserName.Text;
            passWord = PassWord.Password;

            if (userName.CompareTo("Silver") == 0 && passWord.CompareTo("test") == 0)
            {
                canLogIn = true;

                RoomPage room = new RoomPage();
                room.Show();
                this.Close();
            }
        }

        public Boolean canLogin()
        {
            return canLogIn;
        }
    }
}
