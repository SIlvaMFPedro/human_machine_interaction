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
    /// Interaction logic for ProfileWindow.xaml
    /// </summary>
    public partial class ProfileWindow : Window
    {
        public ProfileWindow()
        {
            InitializeComponent();
            StatusTxtBox.Text = "Online";
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            //close window
            this.Close();
        }

        private void OnlineCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            awayCheckBox.IsChecked = false;
            disturbCheckBox.IsChecked = false;
            StatusTxtBox.Text = "Online";
        }

        private void AwayCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            onlineCheckBox.IsChecked = false;
            disturbCheckBox.IsChecked = false;
            StatusTxtBox.Text = "Away";
        }

        private void DoNotDisturbCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            onlineCheckBox.IsChecked = false;
            awayCheckBox.IsChecked = false;
            StatusTxtBox.Text = "Do not Disturb";
        }
        private void MyListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBoxItem item = e.Source as ListBoxItem;
            //show item in a message box
            MessageBox.Show(item.ToString());
        }
    }
}
