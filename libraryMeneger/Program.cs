using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryMeneger.Data;
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
            Application.Run(new LogInForm());
            
        }
    }
}
