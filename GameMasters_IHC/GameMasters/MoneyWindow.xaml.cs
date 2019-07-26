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
    /// Interaction logic for MoneyWindow.xaml
    /// </summary>
    public partial class MoneyWindow : Window
    {
        //add delegate
        public delegate void MoneyUpdateHandler(object sender, MoneyUpdateEventArgs e);

        //add an event of the delegate type
        public event MoneyUpdateHandler MoneyProfileUpdated;

        private int moneyCount;
        private String sMoney;

        public MoneyWindow()
        {
            InitializeComponent();
            this.moneyCount = 0;
            this.sMoney = string.Empty;
        }

        private void Add5ToWallet_Click(object sender, RoutedEventArgs e)
        {
            moneyCount += 5;
            sMoney = moneyCount + "$";
            MoneyTxtBox.Text = sMoney;
        }

        private void Add10ToWallet_Click(object sender, RoutedEventArgs e)
        {
            moneyCount += 10;
            sMoney = moneyCount + "$";
            MoneyTxtBox.Text = sMoney;
        }

        private void Add25ToWallet_Click(object sender, RoutedEventArgs e)
        {
            moneyCount += 25;
            sMoney = moneyCount + "$";
            MoneyTxtBox.Text = sMoney;
        }

        private void Add50ToWallet_Click(object sender, RoutedEventArgs e)
        {
            moneyCount += 50;
            sMoney = moneyCount + "$";
            MoneyTxtBox.Text = sMoney;
        }

        private void Add100ToWallet_Click(object sender, RoutedEventArgs e)
        {
            moneyCount += 100;
            sMoney = moneyCount + "$";
            MoneyTxtBox.Text = sMoney;
        }

        private void AccountDetails_Click(object sender, RoutedEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            // Add an event handler to update this form

            // when the profile form is updated (when ProfileUpdated fires).

            editProfile.ProfileUpdated += new

            EditProfile.ProfileUpdateHandler(AccountDetails_ButtonClicked);

            editProfile.Show();
        }
        private void AccountDetails_ButtonClicked(object sender, ProfileUpdateEventArgs e)
        {
            string username = "UserName: " + e.UserName + Environment.NewLine;
            string realname = "RealName: " + e.RealName + Environment.NewLine;
            string country = "Country: " + e.Country + Environment.NewLine;
            string district = "District: " + e.District + Environment.NewLine;
            string city = "City: " + e.City + Environment.NewLine;
            string address = "Address: " + e.Address + Environment.NewLine;
            string paymethod = "PayMethod: " + e.PayMethod + Environment.NewLine;
            string accountinfo = "Account Info: " + e.AccountInfo + Environment.NewLine;

            string msg = username + realname + country + district + city + address + paymethod + accountinfo;
            MessageBox.Show(msg); //show message in a message box;
        }

        private void PayMethod_Click(object sender, RoutedEventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            // Add an event handler to update this form

            // when the profile form is updated (when ProfileUpdated fires).

            editProfile.ProfileUpdated += new

            EditProfile.ProfileUpdateHandler(PayMethod_ButtonClicked);

            editProfile.Show();
        }

        private void PayMethod_ButtonClicked(object sender, ProfileUpdateEventArgs e)
        {
            string paymethod = "PayMethod: " + e.PayMethod;
            MessageBox.Show(paymethod); //show message in a message box;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            //instance the event args and pass it each value
            MoneyUpdateEventArgs args = new MoneyUpdateEventArgs(sMoney);
            //raise the event with the updated arguments
            MoneyProfileUpdated(this, args);
            //close window;
            this.Close();
        }
    }
}
