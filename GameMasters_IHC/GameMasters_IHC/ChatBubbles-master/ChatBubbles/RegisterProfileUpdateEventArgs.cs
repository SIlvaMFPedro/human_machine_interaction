using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public class RegisterProfileUpdateEventArgs : System.EventArgs
    {
        private string mUserName;
        private string mPasswd;

        public RegisterProfileUpdateEventArgs(string sUserName, string sPasswd)
        {
            this.mUserName = sUserName;
            this.mPasswd = sPasswd;
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
        }

        public string Passwd
        {
            get
            {
                return mPasswd;
            }
        }
    }
}
