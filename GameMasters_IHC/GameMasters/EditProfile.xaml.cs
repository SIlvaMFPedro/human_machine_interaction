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
    /// Interaction logic for EditProfile.xaml
    /// </summary>
    public partial class EditProfile : Window
    {
        //add a delegate
        public delegate void ProfileUpdateHandler(object sender, ProfileUpdateEventArgs e);

        //add an event of the delegate type
        public event ProfileUpdateHandler ProfileUpdated;

        public EditProfile()
        {
            InitializeComponent();
        }

        private void ApplyChanges(object sender, RoutedEventArgs e)
        {
            string sUserName = txtUserName.Text;
            string sRealName = txtRealName.Text;
            string sCountry = txtCountry.Text;
            string sDistrict = txtDistrict.Text;
            string sCity = txtCity.Text;
            string sAddress = txtAddress.Text;
            string sPayMethod = GetPayMethod();
            string sAccountInfo = txtAccountInfo.Text;

            //instance the event args and pass it each value
            ProfileUpdateEventArgs args = new ProfileUpdateEventArgs(sUserName, sRealName, sCountry, sDistrict, sCity, sAddress, sPayMethod, sAccountInfo);
            //raise the event with the updated arguments
            ProfileUpdated(this, args);
            //close window;
            this.Close();
        }

        private string GetPayMethod()
        {
            if (PaySafeCardCheckBox.IsChecked == true)
            {
                return "PaySafeCard";

            }
            else if (PaypalCheckBox.IsChecked == true)
            {
                return "PayPal";
            }
            else if (MasterCardCheckBox.IsChecked == true)
            {
                return "MasterCard";
            }
            return "Pay method";
        }

        private void TxtUserName_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtUserName_GotFocus;
            txtUserName.Foreground = Brushes.Black;
        }

        private void TxtRealName_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtRealName_GotFocus;
            txtRealName.Foreground = Brushes.Black;
        }

        private void TxtCountry_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtCountry_GotFocus;
            txtCountry.Foreground = Brushes.Black;
        }

        private void TxtDistrict_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtDistrict_GotFocus;
            txtDistrict.Foreground = Brushes.Black;
        }

        private void TxtCity_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtCity_GotFocus;
            txtCity.Foreground = Brushes.Black;
        }

        private void TxtAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtAddress_GotFocus;
            txtAddress.Foreground = Brushes.Black;
        }

        private void TxtAccountInfo_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= TxtAccountInfo_GotFocus;
            txtAccountInfo.Foreground = Brushes.Black;
        }

        private void PaySafeCardCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaypalCheckBox.IsChecked = false;
            MasterCardCheckBox.IsChecked = false;
        }

        private void PaypalCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaySafeCardCheckBox.IsChecked = false;
            MasterCardCheckBox.IsChecked = false;
        }

        private void MasterCardCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PaySafeCardCheckBox.IsChecked = false;
            PaypalCheckBox.IsChecked = false;
        }
    }
}
