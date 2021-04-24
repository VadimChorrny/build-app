﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace build_app
{
    [Serializable]
    class Users : List<User>
    {
        // Вхід 
        public bool SignIn(string login, string password)
        {
            var user = this.FirstOrDefault(u => u.Login == login);
            if (user == null) throw new Exception("User login is unknown.");
            if (user.PasswordHash != password.GetHashCode()) throw new Exception("User password is incorrect.");
            return true;
        }
        // Реєстрація нового юзера
        public void SignupNewUser(string login, string password)
        {
            if (this.Any(u => u.Login == login))
                throw new Exception("User with same name exists already.");
            Add(new User(login, password));
        }
    }
}
