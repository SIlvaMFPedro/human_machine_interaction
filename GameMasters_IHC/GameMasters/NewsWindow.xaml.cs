using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.ServiceModel.Syndication;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace ChatBubbles
{
    /// <summary>
    /// Interaction logic for NewsWindow.xaml
    /// </summary>
    public partial class NewsWindow : Window
    {
        public NewsWindow()
        {
            InitializeComponent();
            this.txtUrl.Text = "https://store.steampowered.com/feeds/news.xml";
        }
        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            XDocument xmlDoc = null;
            string path = @"D:\Projecto\ChatBubbles-master\ChatBubbles\steamnews.xml";
            string fileName = Path.GetFileNameWithoutExtension(path);
            /*
            using(XmlReader reader = XmlReader.Create(txtUrl.Text))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                lstFeedItems.ItemsSource = feed.Items;
            }
            */
            using (StreamReader oReader = new StreamReader(fileName, Encoding.GetEncoding("ISO-8859-1")))
            {
                xmlDoc = XDocument.Load(oReader);
                XmlReader reader = XmlReader.Create(oReader);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                lstFeedItems.ItemsSource = feed.Items;

            }
        }
    }
}
