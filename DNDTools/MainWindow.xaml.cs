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

            string[] savedAccount = System.IO.File.ReadAllLines(@"C: /Users/" + Environment.UserName + "/source/repos/DNDTools/Account.txt");

            if (userName.CompareTo(savedAccount[0]) == 0 && passWord.CompareTo(savedAccount[1]) == 0)
            {
                canLogIn = true;

                RoomPage room = new RoomPage(this);
                room.Show();
                this.Visibility = Visibility.Hidden;
            }
            else if (userName.CompareTo(savedAccount[0]) != 0)
            {
                MessageBox.Show("Username is incorrect.", "Cannot login", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            {
                MessageBox.Show("Password is incorrect.", "Cannot login", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void KeyboardEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                ButtonLogIn_Click(sender, e);
        }

        private void LabelLink_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount newAccount = new CreateAccount(this);

            this.Visibility = Visibility.Hidden;
            newAccount.Show();
        }

        public Boolean canLogin()
        {
            return canLogIn;
        }
    }
}
