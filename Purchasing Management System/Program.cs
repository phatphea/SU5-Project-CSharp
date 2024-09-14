using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchasing_Management_System
{
    internal static class Program
    {
        public static string[] controlButton;
        public static string vendor_phoneNumber;
        
        public static MainForm mainFrm;
        public static string userLogin = "";
        public static OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=PurchasingManagementSystem_DB.mdb;Persist Security Info=False");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //connection to db
            con.Open();
            mainFrm = new MainForm();
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainFrm);
        }
    }
}
