using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.WinForms.Forms;
using ITToolbelt.WinForms.Forms.DBAForms;
using ITToolbelt.WinForms.Forms.MainAppForms;

namespace ITToolbelt.WinForms
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

            bool system = ChechSystem();
            if (!system)
            {
                MessageBox.Show("Database connection failed.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Control.CheckForIllegalCrossThreadCalls = false;

            Application.Run(new FormMain());
        }

        private static bool ChechSystem()
        {
            SystemManager systemManager = new SystemManager(GlobalVariables.ConnectInfo);
            bool checkDb = systemManager.CheckDb();
            return checkDb;
        }
    }
}
