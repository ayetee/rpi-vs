using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpi_vs.models
{
    public class App
    {
        private List<User> _users = new List<User>();

        public List<User> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }
    }
}
