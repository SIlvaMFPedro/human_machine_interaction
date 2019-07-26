using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ChatBubbles
{
    public class MyGameData
    {
        BitmapImage image;
        string name;

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

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

    }
}
