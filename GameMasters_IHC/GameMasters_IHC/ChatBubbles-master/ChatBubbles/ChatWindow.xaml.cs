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
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        public ChatWindow()
        {
            InitializeComponent();
        }

        private void StartChat_Click(object sender, RoutedEventArgs e)
        {
            ChatBubblesWindow messageWindow = new ChatBubblesWindow();
            messageWindow.Show(); //start message window.
        }

        private void ShowMessage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Friend is offline! Cannot start chat!");
        }
    }
}
