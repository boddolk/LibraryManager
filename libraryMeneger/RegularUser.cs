using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMeneger.user
{
    internal class RegularUser:BaseUser

    {
        public RegularUser(string myName, string mySurname, string myPassword, string myEmail, string myPhoneNumber)
            : base(myName, mySurname, myPassword, myEmail, myPhoneNumber)
        {
            IsAdmin = false;
        }
    }
}
