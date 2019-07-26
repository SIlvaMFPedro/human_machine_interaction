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
    /// Interaction logic for AddFriendsWindow.xaml
    /// </summary>
    public partial class AddFriendsWindow : Window
    {
        //add delegate
        public delegate void FriendUpdateHandler(object sender, FriendUpdateEventArgs e);

        //add an event of the delegate type
        public event FriendUpdateHandler FriendListUpdated;
        public AddFriendsWindow()
        {
            InitializeComponent();
        }

        private void AddFriendToList(object sender, RoutedEventArgs e)
        {
            string sNewFriend = txtFriendName.Text;
            //instance the event args and pass it each value
            FriendUpdateEventArgs args = new FriendUpdateEventArgs(sNewFriend);
            //raise the event with the updated arguments
            FriendListUpdated(this, args);
            this.Close(); //close window;
        }

        private void ImportFriends(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Error! Cannot connect to steam servers!");
        }
    }
}
