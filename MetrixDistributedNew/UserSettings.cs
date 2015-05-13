using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixDistributedNew
{
    public class UserSettings
    {
        private string username;

        public string user
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string pass
        {
            get { return password; }
            set { password = value; }
        }
    }
}
