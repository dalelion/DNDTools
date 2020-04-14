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
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        MainWindow parent;

        public CreateAccount(MainWindow myParent)
        {
            InitializeComponent();

            parent = myParent;
        }

        private void ButtonLogIn_Click(object sender, RoutedEventArgs e)
        {
            if (UserName.Text.Length == 0 || PassWord.Password.Length == 0)
            {
                MessageBox.Show("At least one parameter is missing.", "Cannot create account", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            {
                string[] account = { UserName.Text, PassWord.Password};
                System.IO.File.WriteAllLines(@"C: /Users/" + Environment.UserName + "/source/repos/DNDTools/Account.txt", account);

                MessageBox.Show("Your account is created", "Account finished", MessageBoxButton.OK, MessageBoxImage.None);

                parent.Visibility = Visibility.Visible;
                this.Close();
            }


        }

        private void ButtonReturn_Click(object sender, RoutedEventArgs e)
        {
            parent.Visibility = Visibility.Visible;
            this.Close();
        }


        private void KeyboardEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                ButtonLogIn_Click(sender, e);
        }
    }
}
