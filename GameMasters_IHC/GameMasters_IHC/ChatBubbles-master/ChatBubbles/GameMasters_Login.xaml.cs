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

namespace ChatBubbles
{
    /// <summary>
    /// Interaction logic for GameMasters_Login.xaml
    /// </summary>
    public partial class GameMasters_Login : Window
    {
        public GameMasters_Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(usernameBox.Text == string.Empty)
            {
                MessageBox.Show("Username cannot be empty!");
                return;
            }
            if(passwordBox.Password.ToString() == string.Empty)
            {
                MessageBox.Show("Password cannot be empty!");
                return;
            }
            MainView mainview = new MainView();
            mainview.nickName.Text = usernameBox.Text;
            mainview.MoneyTextBox.Text = "0$";
            mainview.LevelTextBox.Text = "level 0";
            mainview.Show();
            this.Close(); //close this window.

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.RegisterProfileUpdated += new Register.RegisterProfileUpdateHandler(Register_ButtonClicked);
            register.Show();
            
        }

        private void Register_ButtonClicked(object sender, RegisterProfileUpdateEventArgs e)
        {
            usernameBox.Text = e.UserName;
            passwordBox.Password = e.Passwd;

        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Send help! :(");

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            usernameBox.Clear();
            passwordBox.Clear();

        }
    }
}
