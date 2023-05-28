using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountManager
{
    static class AppController
    {
        internal static string PasswordGeneratorPath = "PassGen\\PassGen.exe";
        internal static MainForm mainForm;
        internal static LoginForm loginForm;
        internal static AccountDataBase accountDataBase;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (!File.Exists(PasswordGeneratorPath))
            {
                MessageBox.Show("Password Generator Application not found!", "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                var openedDataBase = AccountDataBase.OpenAccounts();
                accountDataBase = openedDataBase == null ? new AccountDataBase() : (AccountDataBase)openedDataBase;
                loginForm = new LoginForm();
                Application.Run(loginForm);
            }
            
        }
        
        
    }
}