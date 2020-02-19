using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using HomeWork4.Forms;

using Cryptography.HomeWork4;

namespace HomeWork4
{

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeWork4MainForm());
        }

    }

}