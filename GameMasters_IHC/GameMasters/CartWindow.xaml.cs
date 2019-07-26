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
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        //add a delegate
        public delegate void CartUpdateHandler(object sender, CartUpdateEventArgs e);

        //add an event of the delegate type
        public event CartUpdateHandler CartUpdated;

        public CartWindow()
        {
            InitializeComponent();
        }

        private void BuyGame_Click(object sender, RoutedEventArgs e)
        {
            //get games from CartBox
            if(CartBox.SelectedItems.Count < 1)
            {
                MessageBox.Show("No game has been selected yet!");
                return;
            }
            //check prices
            string valueincart = valueTxtBox.Text;
            valueincart = valueincart.Replace("$", string.Empty);
            string moneyinwallet = moneyTxtBox.Text;
            moneyinwallet = moneyinwallet.Replace("$", string.Empty);
            //get double values;
            double value = Convert.ToDouble(valueincart);
            double money = Convert.ToDouble(moneyinwallet);
            //check salary
            if(value > money)
            {
                MessageBox.Show("You do not have sufficient funds for this purchase!");
                return;
            }
            double endMoney = money - value;

            //create shop list
            List<MyGameData> sGames = new List<MyGameData>();
            for (int i = 0; i < CartBox.SelectedItems.Count; i++)
            {
                GameData game = this.CartBox.SelectedItems[i] as GameData;
                sGames.Add(new MyGameData() { Image = game.Image, Name = game.Title });
            }
            string sMoney = endMoney + "$";
            //instantiate the event args and pass it each value
            CartUpdateEventArgs args = new CartUpdateEventArgs(sGames, sMoney);
            //raise the event with the updated arguments
            CartUpdated(this, args);
            //close window
            this.Close();

        }

        private void AddFunds_Click(object sender, RoutedEventArgs e)
        {
            MoneyWindow money = new MoneyWindow();

            // Add an event handler to update this form

            // when the profile form is updated (when MoneyUpdated fires).
            money.MoneyProfileUpdated += new MoneyWindow.MoneyUpdateHandler(AddFunds_ButtonClicked);
            money.Show();
        }

        private void AddFunds_ButtonClicked(object sender, MoneyUpdateEventArgs e)
        {
            moneyTxtBox.Text = e.Money;
            MessageBox.Show("Money transfer completed with success!"); //show tranfer message;
        }
    }
}
