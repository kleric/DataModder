
using System;
using System.Windows.Forms;

namespace DataModder
{
	static class Program
	{
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0].Equals("-d"))
                {
                    FrmMain frmMain = new FrmMain();
                    frmMain.LoadAndApplyMods();
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmMain());
            }
        }
	}
}
