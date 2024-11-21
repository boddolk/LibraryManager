using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace libraryMeneger.user
{
    public abstract class BaseUser
    {
        private string login;
        private string name;
        private string surname;
        private string password;
        private string email;
        private string phoneNumber;
        private bool isAdmin = false;


        public BaseUser()
        {
            login = "User";
            Name = "noName";
            Surname = "noSurname";
            Password = "noPassword";
            Email = "mnoEmail";
            PhoneNumber = "noPhoneNumber";

        }

        public BaseUser(string myLogin, string myName, string mySurname, string myPassword, string myEmail, string myPhoneNumber)
        {
            login = myLogin;
            Name = myName;
            Surname = mySurname;
            Password = myPassword;
            Email = myEmail;
            PhoneNumber = myPhoneNumber;
        }

        public string Login
        { 
            get { return login; } 
            set { login = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Password
        {
            get { return password; }
            private set { password = value; } 
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                    email = value;
                else
                    throw new ArgumentException("Invalid email address");
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            protected set { isAdmin = value; }
        }
    }

}
