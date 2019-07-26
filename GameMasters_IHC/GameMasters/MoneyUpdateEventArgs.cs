using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public class MoneyUpdateEventArgs : System.EventArgs
    {
        private String mMoney;

        public MoneyUpdateEventArgs(String sMoney)
        {
            this.mMoney = sMoney;
        }

        public string Money
        {
            get
            {
                return mMoney;
            }
        }
    }
}
