using System.Collections.Generic;

namespace SharpPhone
{
    public class SharpPhoneDataStore
    {
        public List<ClassSmartPhone> Phones { get; set; } = new();
        public List<UserAccount> Users { get; set; } = new();
    }
}