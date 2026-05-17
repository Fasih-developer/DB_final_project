using System;
using System.Windows.Forms;

namespace CampusConnect
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Form1());
        }
    }
}
