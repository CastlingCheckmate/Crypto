using System;
using System.Windows.Forms;

using HomeWork3.Forms;

namespace HomeWork3
{

    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeWork3MainForm());
        }

    }

}