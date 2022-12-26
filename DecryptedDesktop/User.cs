using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecryptedDesktop
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
