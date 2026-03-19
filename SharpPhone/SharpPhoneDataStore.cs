using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpPhone
{
    public class SharpPhoneDataStore
    {
        List<SmartPhone> Phones = new List<SmartPhone>();
        List<UserAccount> Users = new List<SmartPhone>();
    }

    internal class UserAccount
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int FailedAttempts { get; set; }
        public bool Locked { get; set; }
    }

    public class SharpPhoneJsonStore
    {
        public SharpPhoneDataStore Data { get; set; } = new SharpPhoneDataStore();
    }
}
