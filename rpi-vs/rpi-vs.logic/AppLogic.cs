using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rpi_vs.models;

namespace rpi_vs.logic
{
    public class AppLogic
    {
        private App _app;

        public AppLogic(App app)
        {
            _app = app;
        }

        public User Login(string username, string password)
        {
            try
            {
                return _app.Users.Single(u => u.Username == username && u.Password == password);
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
