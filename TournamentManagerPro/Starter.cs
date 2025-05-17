/**
 * Tournament Manager Pro
 * 
 * Starter - The entry point of the application
 */

using System.Windows.Forms;
using System;

namespace TournamentManagerPro

{
    internal class Starter
    {

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new ManagerGUI());

        }

    }

}
