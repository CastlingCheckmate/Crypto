using System;
using System.Windows.Forms;

using HomeWork1.Forms;

namespace HomeWork1
{

    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeWork1MainForm());
        }

    }

}