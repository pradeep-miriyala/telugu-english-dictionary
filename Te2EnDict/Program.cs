using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Te2EnDict
{    
    static class Program
    {        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrame());
        }*/
        static void Main(string[] args)
        {
            MainFrame frmMain;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length  == 0)
            {
                frmMain = new MainFrame();                
                // Application.Run(new MainFrame());
            }
            else
            if (args.GetUpperBound(0) > 2 )
                frmMain=new MainFrame();
                // Application.Run(new MainFrame());
            else
            {
                if (args[0].ToUpper() == "HIDE")
                    frmMain = new MainFrame(true);
                // Application.Run(new MainFrame(true));
                else
                    frmMain = new MainFrame();
                    // Application.Run(new MainFrame());
            }
            Application.Run(frmMain);
        }
    }
}
