using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBubbles
{
    public class User
    {
        string name;
        string nickname;
        int level;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string NickName
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
    }
}
