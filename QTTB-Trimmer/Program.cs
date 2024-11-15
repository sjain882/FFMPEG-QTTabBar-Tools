using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTTB_Trimmer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                MessageBox.Show("No file!");
            }

            QTTBTrimmer qtbt = new QTTBTrimmer(args[0]);

            Application.EnableVisualStyles();

            //Application.SetCompatibleTextRenderingDefault(false);
            //string[] arguments = Environment.GetCommandLineArgs();

            Application.Run(qtbt.form);
        }
    }
}
