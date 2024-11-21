using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libraryMeneger.user
{
    public class AdminUser : BaseUser
    {
        public AdminUser(string myLogin, string myName, string mySurname, string myPassword, string myEmail, string myPhoneNumber)
            : base( myLogin, myName, mySurname, myPassword, myEmail, myPhoneNumber)
        {
            IsAdmin = true;
        }
    }
}
