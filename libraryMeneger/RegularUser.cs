using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMeneger.user
{
    public class RegularUser:BaseUser

    {
        public RegularUser()
            :base()
        {

        }

        public RegularUser(string myLogin, string myName, string mySurname, string myPassword, string myEmail, string myPhoneNumber)
            : base(myLogin, myName, mySurname, myPassword, myEmail, myPhoneNumber)
        {
            IsAdmin = false;
        }
    }
}
