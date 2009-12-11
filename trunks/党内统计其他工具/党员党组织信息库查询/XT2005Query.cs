using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace com.echo.XT2007
{
    static class XT2005Query
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
