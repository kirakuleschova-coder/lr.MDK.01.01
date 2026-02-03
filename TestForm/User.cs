using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm
{
    public class User
    {
        private string login_;
        private string password_;

        User(string login, string password)
        {
            login_ = login;
            password_ = password;
        }

        string Login
        {
            get { return login_; }
        }

        string Password
        {
            get { return password_; }
        }

    }
}
