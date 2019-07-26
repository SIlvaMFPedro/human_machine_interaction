using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public class ProfileUpdateEventArgs : System.EventArgs
    {
        private string mUserName;
        private string mRealName;
        private string mCountry;
        private string mDistrict;
        private string mCity;
        private string mAddress;
        private string mPayMethod;
        private string mAccountInfo;

        public ProfileUpdateEventArgs(string sUserName, string sRealName, string sCountry, string sDistrict, string sCity, string sAddress, string sPayMethod, string sAccountInfo)
        {
            this.mUserName = sUserName;
            this.mRealName = sRealName;
            this.mCountry = sCountry;
            this.mDistrict = sDistrict;
            this.mCity = sCity;
            this.mAddress = sAddress;
            this.mPayMethod = sPayMethod;
            this.mAccountInfo = sAccountInfo;
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
        }

        public string RealName
        {
            get
            {
                return mRealName;
            }
        }

        public string Country
        {
            get
            {
                return mCountry;
            }
        }

        public string District
        {
            get
            {
                return mDistrict;
            }
        }

        public string City
        {
            get
            {
                return mCity;
            }
        }

        public string Address
        {
            get
            {
                return mAddress;
            }
        }

        public string PayMethod
        {
            get
            {
                return mPayMethod;
            }
        }

        public string AccountInfo
        {
            get
            {
                return mAccountInfo;
            }
        }
    }
}
