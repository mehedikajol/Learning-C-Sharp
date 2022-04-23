using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstractClass
{
    public abstract class User
    {
        public void Login(string username, string password)
        {
            // Login code need to be written here
        }

        public void Logout()
        {
            // Logout code need to be written here
        }
        
        public abstract void ChangePassword(string username);
    }
}
