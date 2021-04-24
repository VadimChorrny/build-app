using System;
using System.Collections.Generic;
using System.Text;

namespace build_app
{
    [Serializable]
    class User
    {
        public string Login; // email
        public int PasswordHash;
        public User(string login,string pass)
        {
            Login = login;
            PasswordHash = pass.GetHashCode();
        }
    }
}
