using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    internal static class Program
    {
        public static string strConn = "";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //this need to exist first, before everything else, or else it doesn't work
            //strConn = ConfigurationManager.ConnectionStrings["MyConnOleDb"].ConnectionString;
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2_2());

        }
    }
}
