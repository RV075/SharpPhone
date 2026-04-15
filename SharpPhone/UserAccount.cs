using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone
{
    public class UserAccount
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int FailedAttempts { get; set; }
        public bool Locked { get; set; }

        public UserAccount()
        {

        }
        
        public UserAccount(string username, string password, int failedAttempts = 0, bool locked = false)
        {
            Username = username;
            Password = password;
            FailedAttempts = failedAttempts;
            Locked = locked;
        }
    }
}
