using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frmLogin = new FrmLogin();
            
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                string ipF = frmLogin.ip;
                int portF = frmLogin.port;
                string userF = frmLogin.user;
                frmLogin.Dispose();
                Application.Run(new FrmKlijent(ipF, portF, userF));
            }
            
        }
    }
}
