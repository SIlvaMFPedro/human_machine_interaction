using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public class FriendUpdateEventArgs : System.EventArgs
    {
        private String mNewFriend;

        //class constructor
        public FriendUpdateEventArgs(string sNewFriend)
        {
            this.mNewFriend = sNewFriend;
        }

        public string NewFriend
        {
            get
            {
                return mNewFriend;
            }
        }
    }
}
