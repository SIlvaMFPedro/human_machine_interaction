using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ChatBubbles
{
    public class GameData
    {
        BitmapImage image;
        string title;
        string price;

        public BitmapImage Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        public string Title
        {
            get {
                return title;
            }
            set {
                title = value;
            }
        }

       public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

    }
}
