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
    /// Interaction logic for FriendsWindow.xaml
    /// </summary>
    public partial class FriendsWindow : Window
    {
        public FriendsWindow()
        {
            InitializeComponent();
        }

        private void AddFriendToList_Click(object sender, RoutedEventArgs e)
        {
            AddFriendsWindow addFriends = new AddFriendsWindow();
            addFriends.FriendListUpdated += new AddFriendsWindow.FriendUpdateHandler(AddFriendsToList_ButtonClicked);
            addFriends.Show();
        }

        private void AddFriendsToList_ButtonClicked(object sender, FriendUpdateEventArgs e)
        {
            //update the forms values from the event args
            var items = FriendsTree_View.Items;
            var item = new TreeViewItem() { Header = e.NewFriend };
            foreach(TreeViewItem n in items)
            {
                if(n.Header.ToString() == "Online")
                {
                    (n as TreeViewItem).Items.Add(item);
                }
            }
        }

        private void SearchFriend(object sender, RoutedEventArgs e)
        {
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(FriendsTree_View.ItemsSource);
            if(view != null)
            {
                view.Filter = FriendFilter;
            }
        }

        private bool FriendFilter(object item)
        {
            if (String.IsNullOrEmpty(SearchFriendTextBox.Text))
                return true;
            else
                return ((item as TreeViewItem).Name.IndexOf(SearchFriendTextBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        
    }
}
