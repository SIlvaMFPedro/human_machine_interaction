using System;
using System.IO;
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
using Microsoft.Win32;

namespace ChatBubbles
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        List<MyGameData> my_games_items;

        public MainView()
        {
            InitializeComponent();
            //get game uris
            Consoletxtblock.Text += Environment.NewLine + "Getting game URIS..." + Environment.NewLine;
            var ageempires_uri = new Uri("/Pictures/ageempires.png", UriKind.Relative);
            var ageempires_dlc_uri = new Uri("/Pictures/ageempiresdlc.png", UriKind.Relative);
            var armaIII_uri = new Uri("/Pictures/armaIII.png", UriKind.Relative);
            var borderlands_pre_sequel_uri = new Uri("/Pictures/borderlands-pre-sequel.png", UriKind.Relative);
            var borderlands_uri = new Uri("/Pictures/borderlands.png", UriKind.Relative);
            var borderlands2_uri = new Uri("/Pictures/borderlands2.png", UriKind.Relative); 
            var csgo_uri = new Uri("/Pictures/csgo.png", UriKind.Relative);
            var cssource_uri = new Uri("/Pictures/cssource.png", UriKind.Relative);
            var cs_uri = new Uri("/Pictures/cs.png", UriKind.Relative);
            var fortinite_uri = new Uri("/Pictures/fortnite.png", UriKind.Relative);
            var gta_uri = new Uri("/Pictures/gta.png", UriKind.Relative);
            var issac_uri = new Uri("/Pictures/issac.png", UriKind.Relative);
            var lol_uri = new Uri("/Pictures/lol.png", UriKind.Relative);
            var paladins_uri = new Uri("/Pictures/paladins.png", UriKind.Relative);
            var pubg_uri = new Uri("/Pictures/pubg.png", UriKind.Relative);
            var r6siege_uri = new Uri("/Pictures/r6siege.png", UriKind.Relative);
            var skyrim_uri = new Uri("/Pictures/skyrim.png", UriKind.Relative);
            var sow_uri = new Uri("/Pictures/sow.png", UriKind.Relative);
            var tombraider_uri = new Uri("/Pictures/tombraider.png", UriKind.Relative);
            var TWD_uri = new Uri("/Pictures/TWD.png", UriKind.Relative);
            var uno_uri = new Uri("/Pictures/uno.png", UriKind.Relative);
            var worms_uri = new Uri("/Pictures/worms.png", UriKind.Relative);


            //list SearchGamesView
            Consoletxtblock.Text += "Creating SearchBox ListView..." + Environment.NewLine;
            List<GameData> search_game_items = new List<GameData>();
            search_game_items.Add(new GameData() { Image = new BitmapImage(csgo_uri), Title = "Counter-Strike Global Offensive", Price = "19,99$"});
            search_game_items.Add(new GameData() { Image = new BitmapImage(cssource_uri), Title = "Counter-Strike Source", Price = "9,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(cs_uri), Title = "Counter Strike", Price = "4,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(armaIII_uri), Title = "ArmaIII", Price = "29,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(borderlands_uri), Title = "Borderlands", Price = "19,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(borderlands2_uri), Title = "Borderlands2", Price = "29,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(borderlands_pre_sequel_uri), Title = "Borderlands Pre Sequel", Price = "39,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(tombraider_uri), Title = "TombRaider", Price = "19,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(issac_uri), Title = "Binding of Issac", Price = "9,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(TWD_uri), Title = "The Waliking Dead - Telltale Game", Price = "19,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(sow_uri), Title = "Middle Earth Shadow of War", Price = "39,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(skyrim_uri), Title = "Elder Scrolls V - Skyrim", Price = "39,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(ageempires_uri), Title = "Age of Wonders III", Price = "29,99$" });
            search_game_items.Add(new GameData() { Image = new BitmapImage(ageempires_dlc_uri), Title = "Age of Wonders III - DLC", Price = "19,99$" });
            //add items to ListView SearchBox.
            SearchBox.Items.Clear(); //empty searchbox
            SearchBox.ItemsSource = search_game_items;
            //filter ListView SearchBox
            CollectionView searchgamesview = (CollectionView)CollectionViewSource.GetDefaultView(SearchBox.ItemsSource);
            searchgamesview.Filter = SearchGameFilter;

            //list MyGamesView
            Consoletxtblock.Text += "Creating MyGamesBox ListView..." + Environment.NewLine;
            my_games_items = new List<MyGameData>();
            my_games_items.Add(new MyGameData() { Image = new BitmapImage(fortinite_uri), Name = "Fortnite" });
            my_games_items.Add(new MyGameData() { Image = new BitmapImage(pubg_uri), Name = "Player Unknown BattleGrounds" });
            my_games_items.Add(new MyGameData() { Image = new BitmapImage(r6siege_uri), Name = "Rainbow Six Siege" });
            my_games_items.Add(new MyGameData() { Image = new BitmapImage(gta_uri), Name = "Grand Theft Auto " });
            //add items to ListView MyGamesBox.
            MyGamesBox.Items.Clear(); //empty mygamesbox
            MyGamesBox.ItemsSource = my_games_items;
            //filter ListView MyGamesBox.
            CollectionView mygamesview = (CollectionView)CollectionViewSource.GetDefaultView(MyGamesBox.ItemsSource);
            mygamesview.Filter = SearchMyGamesFilter;

            //list MyFreeGamesView
            Consoletxtblock.Text += "Creating FreeGamesBox ListView..." + Environment.NewLine;
            List<MyGameData> free_games_items = new List<MyGameData>();
            free_games_items.Add(new MyGameData() { Image = new BitmapImage(lol_uri), Name = "League Of Legends" });
            free_games_items.Add(new MyGameData() { Image = new BitmapImage(uno_uri), Name = "UNO" });
            free_games_items.Add(new MyGameData() { Image = new BitmapImage(worms_uri), Name = "Worms" });
            free_games_items.Add(new MyGameData() { Image = new BitmapImage(paladins_uri), Name = "Paladins" });
            //add items to ListView FreeGamesBox.
            FreeGamesBox.Items.Clear(); //empty freegamesbox;
            FreeGamesBox.ItemsSource = free_games_items;
            //filter ListView FreeGamesBox.
            CollectionView freegamesview = (CollectionView)CollectionViewSource.GetDefaultView(FreeGamesBox.ItemsSource);
            freegamesview.Filter = SearchFreeGamesFilter;

            //list UserView
            Consoletxtblock.Text += "Creating UserView ListView..." + Environment.NewLine;
            List<User> user_items = new List<User>();
            user_items.Add(new User() {Name ="John", NickName = "John Doe", Level = 42 });
            user_items.Add(new User() {Name="Jane", NickName = "Jane Doe", Level = 39 });
            user_items.Add(new User() {Name="Sammy", NickName = "Sammy Doe", Level = 13 });
            user_items.Add(new User() {Name="Donna", NickName = "Donna Doe", Level = 13 });
            //add items to ListView UserView.
            UserView.ItemsSource = user_items;
            //filter UserView.
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(UserView.ItemsSource);
            view.Filter = UserFilter;

        }

        private bool SearchGameFilter(object item)
        {
            Consoletxtblock.Text += "Applying SearchGameFilter..." + Environment.NewLine;
            if (String.IsNullOrEmpty(searchgameFilter.Text))
                return true;
            else
                return ((item as GameData).Title.IndexOf(searchgameFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void SearchGameFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "SearchGameFilter Text Changed..." + Environment.NewLine;
            CollectionViewSource.GetDefaultView(SearchBox.ItemsSource).Refresh();
        }

        private bool SearchMyGamesFilter(object item)
        {
            Consoletxtblock.Text += "Applying SearchMyGamesFilter..." + Environment.NewLine;
            if (String.IsNullOrEmpty(searchMyGamesFilter.Text))
                return true;
            else
                return ((item as MyGameData).Name.IndexOf(searchMyGamesFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);

        }

        private void SearchMyGamesFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "SearchMyGamesFilter Text Changed..." + Environment.NewLine;
            CollectionViewSource.GetDefaultView(MyGamesBox.ItemsSource).Refresh();
        }

        private bool SearchFreeGamesFilter(object item)
        {
            Consoletxtblock.Text += "SearchFreeGameFilter Text Changed..." + Environment.NewLine;
            if (String.IsNullOrEmpty(searchFreeGamesFilter.Text))
                return true;
            else
                return ((item as MyGameData).Name.IndexOf(searchFreeGamesFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void SearchFreeGamesFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "SearchFreeGamesFilter Text Changed..." + Environment.NewLine;
            CollectionViewSource.GetDefaultView(FreeGamesBox.ItemsSource).Refresh();
        }

        private bool UserFilter(object item)
        {

            Consoletxtblock.Text += "Applying UserFilter..." + Environment.NewLine;
            if (String.IsNullOrEmpty(userFilter.Text))
                return true;
            else
                return ((item as User).Name.IndexOf(userFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void UserFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "User Filter Text Changed..." + Environment.NewLine;
            CollectionViewSource.GetDefaultView(UserView.ItemsSource).Refresh();
        }

        private void TreeView_Loaded(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Loading ComTree_View..." + Environment.NewLine;
            //create first treeviewitem
            TreeViewItem item1 = new TreeViewItem();
            item1.Header = "Community1";
            item1.ItemsSource = new string[] { "User1" };
           

            //create second treeviewitem
            TreeViewItem item2 = new TreeViewItem();
            item2.Header = "Community2";
            item2.ItemsSource = new string[] { "User2" };

            //clear treeview.
            ComTree_View.Items.Clear();
            //add treeviewitems to treeview
            ComTree_View.Items.Add(item1);
            ComTree_View.Items.Add(item2);
            CollectionView treeview = (CollectionView)CollectionViewSource.GetDefaultView(ComTree_View.Items);
            if (treeview != null)
            {
                treeview.Filter = ComFilter;
            }
        }

        
        private bool ComFilter(object item)
        {
            Consoletxtblock.Text += "Applying ComFilter..." + Environment.NewLine;
            if (String.IsNullOrEmpty(comFilter.Text))
                return true;
            else
                return ((item as TreeViewItem).Header.Equals(comFilter.Text));
        }
        
        
        private void ComFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "ComFilter Text Changed..." + Environment.NewLine;
            CollectionView view = (CollectionView) CollectionViewSource.GetDefaultView(ComTree_View.ItemsSource);
            if (view != null)
            {
                CollectionViewSource.GetDefaultView(ComTree_View.ItemsSource).Refresh();
            }
            else MessageBox.Show("erro");
        }
        


        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            Consoletxtblock.Text += "TreeView Selected Item Changed..." + Environment.NewLine;
            var tree = sender as TreeView;
            //Determine type of SelectedItem;
            if(tree.SelectedItem is TreeViewItem)
            {
                //handle treeviewitem
                var item = tree.SelectedItem as TreeViewItem;
                this.Title = "Selected header: " + item.Header.ToString();
            }
            else if(tree.SelectedItem is string)
            {
                //handle string
                this.Title = "Selected: " + tree.SelectedItem.ToString();
            }
        }

        private void GotoNews_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to News Click..." + Environment.NewLine;
            NewsWindow news = new NewsWindow();
            news.Show();
        }

        private void GotoCart_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to Cart Click..." + Environment.NewLine;
            CartWindow cart = new CartWindow();
            cart.valueTxtBox.Text = "0$";
            cart.moneyTxtBox.Text = MoneyTextBox.Text;
            cart.Show();
        }

        private void GotoChat_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to Chat Click..." + Environment.NewLine;
            ChatWindow chat = new ChatWindow();
            chat.Show();
        }

        private void GotoFriends_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to Friends Click..." + Environment.NewLine;
            FriendsWindow friends = new FriendsWindow();
            friends.NickNameTxtBox.Text = nickName.Text;
            friends.StatusTxtBox.Text = "Online";
            friends.Show();
        }

        private void GotoProfile_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to Profile Click..." + Environment.NewLine;
            ProfileWindow profile = new ProfileWindow();
            profile.NickNameTxtBox.Text = nickName.Text;
            profile.LevelTxtBox.Text = LevelTextBox.Text;
            profile.Show();
        }

        private void GotoMoney_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to Money Click..." + Environment.NewLine;
            MoneyWindow money = new MoneyWindow();

            // Add an event handler to update this form

            // when the profile form is updated (when MoneyUpdated fires).
            money.MoneyProfileUpdated += new MoneyWindow.MoneyUpdateHandler(GotoMoney_ButtonClicked);
            money.Show();
        }

        private void GotoMoney_ButtonClicked(object sender, MoneyUpdateEventArgs e)
        {
            Consoletxtblock.Text += "Go to Money Button Clicked..." + Environment.NewLine;
            string money = MoneyTextBox.Text;
            money = money.Replace("$", string.Empty);
            string newmoney = e.Money;
            newmoney = newmoney.Replace("$", string.Empty);
            double moneyvalue = Convert.ToDouble(money);
            double newmoneyvalue = Convert.ToDouble(newmoney);
            double endmoney = moneyvalue + newmoneyvalue;
            MoneyTextBox.Text = endmoney + "$";
            MessageBox.Show("Money transfer completed with success!");
        }

        private void Numberofusers_TextChanged(object sender, TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "Number of User Text Changed..." + Environment.NewLine;
            var textbox = sender as TextBox;
            numberofusers.Text = textbox.Text;

        }

        private void CreateCom_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Create community click..." + Environment.NewLine;
            //create treeviewitem
            TreeViewItem item = new TreeViewItem();
            item.Header = nameCom.Text;
            int i = 1;
            bool canConvert = int.TryParse(numberofusers.Text, out i);
            if (canConvert == true)
            {
                int value = int.Parse(numberofusers.Text);
                item.ItemsSource = new string[value];
                ComTree_View.Items.Add(item);
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(ComTree_View.Items);
                if (view != null)
                {
                    view.Filter = ComFilter;

                }
            }
            else MessageBox.Show("Please insert a number!");

        }

        private void NameCom_TextChanged(object sender, TextChangedEventArgs e)
        {
            Consoletxtblock.Text += "Comunity Name Text Changed..." + Environment.NewLine;
            var textbox = sender as TextBox;
            nameCom.Text = textbox.Text;

        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Add User Click..." + Environment.NewLine;
            //get users by name
            if(UserView.SelectedItems.Count < 1)
            {
                MessageBox.Show("Nothing selected");
                return;
            }
            string[] usernames = new string[UserView.SelectedItems.Count];
            for(int i = 0; i < UserView.SelectedItems.Count; i++)
            {
                User user = this.UserView.SelectedItems[i] as User;
                usernames[i] = user.Name;
            }
            //add user to selected item in tree view
            if (ComTree_View.SelectedItem == null)
                MessageBox.Show("Please select a community to add user!");
            else {
                TreeViewItem tvItem = ComTree_View.SelectedItem as TreeViewItem;
                tvItem.ItemsSource = usernames;
            }
            
        }

        private void ChangePic_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Change picture click..." + Environment.NewLine;
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" + "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" + "Portable Network Graphic (*.png)|*.png";
            if(op.ShowDialog() == true)
            {
                PersonProfilePic.Source = new BitmapImage(new Uri(op.FileName));
            }

        }

        private void GotoEditProfile_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Go to Edit Profile Click..." + Environment.NewLine;
            EditProfile editProfile = new EditProfile();

            // Add an event handler to update this form

            // when the profile form is updated (when ProfileUpdated fires).

            editProfile.ProfileUpdated += new

            EditProfile.ProfileUpdateHandler(EditProfile_ButtonClicked);

            editProfile.Show();
        }
        //handles edit profile event
        private void EditProfile_ButtonClicked(object sender, ProfileUpdateEventArgs e)
        {
            Consoletxtblock.Text += "Edit Profile Button Clicked..." + Environment.NewLine;
            List<String> items = new List<String>();
            items.Add(e.UserName);
            items.Add(e.RealName);
            items.Add(e.Country);
            items.Add(e.District);
            items.Add(e.City);
            items.Add(e.Address);
            items.Add(e.PayMethod);
            items.Add(e.AccountInfo);

            //update profile listbox
            if (ProfileLB.ItemsSource == null)
            {
                ProfileLB.Items.Clear(); // clear item source
                ProfileLB.ItemsSource = items;
            }
            else
            {
                ProfileLB.ItemsSource = null;
                ProfileLB.Items.Clear(); // clear item source
                ProfileLB.ItemsSource = items;
            }
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "LogOut Click..." + Environment.NewLine;
            GameMasters_Login login = new GameMasters_Login();
            login.Show();
            this.Close();
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Add to Cart Click..." + Environment.NewLine;
            //get ganes from SearchBox
            if(SearchBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("No game has been selected");
                return;
            }
            List<GameData> items = new List<GameData>();
            double[] prices = new double[SearchBox.SelectedItems.Count];
            for(int i = 0; i < SearchBox.SelectedItems.Count; i++)
            {
                GameData game = this.SearchBox.SelectedItems[i] as GameData;
                items.Add(new GameData() { Image = game.Image, Title = game.Title, Price = game.Price });
                string gameprice = game.Price;
                gameprice = gameprice.Replace("$", string.Empty);
                prices[i] = Convert.ToDouble(gameprice);
            }
            double sum = 0.0;
            //sum game prices
            for(int i = 0; i < SearchBox.SelectedItems.Count; i++)
            {
                sum += prices[i];
            }
            //start new CartWindow
            CartWindow cart = new CartWindow();
            cart.CartBox.ItemsSource = items;
            cart.valueTxtBox.Text = sum + "$";
            cart.moneyTxtBox.Text = MoneyTextBox.Text;

            // Add an event handler to update this form

            // when the profile form is updated (when CartUpdated fires).
            cart.CartUpdated += new CartWindow.CartUpdateHandler(AddtoCart_ButtonClicked);

            //show CartWindow
            cart.Show();
        }
        private void AddtoCart_ButtonClicked(object sender, CartUpdateEventArgs e)
        {
            Consoletxtblock.Text += "Add to Cart Button Clicked..." + Environment.NewLine;
            List<MyGameData> myNewGamelst = new List<MyGameData>();
            myNewGamelst = e.Games;
            MoneyTextBox.Text = e.Money;

            //add new games to MyGamesBox
            for(int i = 0; i < myNewGamelst.Count; i++)
            {
                my_games_items.Add(myNewGamelst[i]);
            }

            //add items to ListView MyGamesBox.
            //MyGamesBox.Items.Clear(); //empty mygamesbox
            MyGamesBox.ItemsSource = my_games_items;
        }

        private void ViewDetails_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "View Details Click..." + Environment.NewLine;
            //get games from SearchBox
            if(SearchBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("No game has been selected");
                return;
            }
            for(int i = 0; i < SearchBox.SelectedItems.Count; i++)
            {
                GameData game = this.SearchBox.SelectedItems[i] as GameData;
                string gametitle = game.Title;
                string gameprice = game.Price;
                string msg = gametitle + " - " + gameprice;
                MessageBox.Show(msg); //show message box with game details;
            }

        }

        private void InstallGame_Click(object sender, RoutedEventArgs e)
        {
            Consoletxtblock.Text += "Install Game Click..." + Environment.NewLine;
            //get games from MyGamesBox
            if(MyGamesBox.SelectedItems.Count < 1)
            {
                if (FreeGamesBox.SelectedItems.Count < 1)
                {
                    MessageBox.Show("No game has been selected to install");
                    return;
                }
            }
            //install games from MyGames
            if (MyGamesBox.SelectedItems.Count >= 1)
            {
                for (int i = 0; i < MyGamesBox.SelectedItems.Count; i++)
                {
                    MyGameData mygame = this.MyGamesBox.SelectedItems[i] as MyGameData;
                    string mygamename = mygame.Name;
                    string msg = mygamename + " is being installed";
                    MessageBox.Show(msg); //show message b0ox with game details;
                }
            }
            //install games from FreeGames
            if(FreeGamesBox.SelectedItems.Count >= 1)
            {
                for(int j = 0; j < FreeGamesBox.SelectedItems.Count; j++)
                {
                    MyGameData freegame = this.FreeGamesBox.SelectedItems[j] as MyGameData;
                    string myfreegamename = freegame.Name;
                    string msg = myfreegamename + " is being installed";
                    MessageBox.Show(msg); //show message box with game details;
                }
            }
        }

        private void NameCom_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= NameCom_GotFocus;
            nameCom.Foreground = Brushes.Black;
        }

        private void Numberofusers_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= Numberofusers_GotFocus;
            numberofusers.Foreground = Brushes.Black;
        }
    }
}
