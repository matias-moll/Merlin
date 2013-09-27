using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TNGS.NetRoutines;

namespace TestBLL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBConn.DatConn = "MSSql;(local);TNGS_Rivn;";
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
