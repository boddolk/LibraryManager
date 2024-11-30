using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryMeneger.Data;
using libraryMeneger.Data.UserRepository;
using libraryMeneger.user;
namespace libraryMeneger
{
    internal static class Program
    {
        //public static string PPath="";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //PPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            DataAccess.TestDatabaseConnection();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var currentUser = GetUserCredentials();
            if (currentUser != null)
            {
                if (currentUser.Value.admin != null)
                {
                    Application.Run(new AdminForm(currentUser.Value.admin));
                }
                else
                {
                    Application.Run(new UserForm(currentUser.Value.regular));
                }
            }
        }

        private static (AdminUser admin, RegularUser regular)? GetUserCredentials()
        {
            LogInForm loginForm = new LogInForm();
            UserRepository userRepository = new UserRepository();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                return (loginForm.admUser, loginForm.regUser);
            }

            return null;
        }
    }
}
