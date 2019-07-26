using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public class CartUpdateEventArgs : System.EventArgs
    {
        //add local member variable to hold text
        private List<MyGameData> mGames;
        private string mMoney;

        //class constructor
        public CartUpdateEventArgs(List<MyGameData> sGames, string sMoney)
        {
            this.mGames = sGames;
            this.mMoney = sMoney;
        }
        
        public List<MyGameData> Games
        {
            get
            {
                return mGames;
            }
            set
            {
                mGames = value;
            }
        }

        public string Money
        {
            get
            {
                return mMoney;
            }
            set
            {
                mMoney = value;
            }
        }
    }
}
