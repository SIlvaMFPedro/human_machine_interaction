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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        //add a delegate
        public delegate void RegisterProfileUpdateHandler(object sender, RegisterProfileUpdateEventArgs e);

        //add an event of the delegate type
        public event RegisterProfileUpdateHandler RegisterProfileUpdated;

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            if(UsernameTxtBox.Text == string.Empty)
            {
                MessageBox.Show("UserName cannot be empty");
                return;
            }
            if(PasswdBox.Password.ToString() == string.Empty)
            {
                MessageBox.Show("Password cannot be null");
                return;
            }
            string sUserName = UsernameTxtBox.Text;
            string sPasswd = PasswdBox.Password.ToString();
            //instance the event args and pass it each value
            RegisterProfileUpdateEventArgs args = new RegisterProfileUpdateEventArgs(sUserName, sPasswd);
            //raise the event with the updated arguments
            RegisterProfileUpdated(this, args);
            //close window;
            this.Close();
        }

        private void BackToLogin_Click(object sender, RoutedEventArgs e)
        {
            //close window
            this.Close();

        }
    }
}
