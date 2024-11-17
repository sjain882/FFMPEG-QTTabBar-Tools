using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace QTTB_Trimmer
{
    class QTTBTrimmer
    {

        public GUI form;
        List<string> inputFilePaths;
        List<string> outputFilePaths;

        public QTTBTrimmer(string[] filePaths)
        {
            this.form = new GUI();
            this.inputFilePaths = new List<string>(filePaths);
            this.outputFilePaths = new List<string>(filePaths);

            for (int i = 0; i < outputFilePaths.Count; i++)
            {
                outputFilePaths[i] = AddSuffix(outputFilePaths[i], "_Opt");
            }

            form.button1.Click += new System.EventHandler(button1_Click);
            //MessageBox.Show(form.dateTimePicker1.Value.TimeOfDay.ToString());
            //MessageBox.Show(outputPath);
        }

        // https://stackoverflow.com/a/24367618
        string AddSuffix(string filename, string suffix)
        {
            string fDir = Path.GetDirectoryName(filename);
            string fName = Path.GetFileNameWithoutExtension(filename);
            string fExt = Path.GetExtension(filename);
            return Path.Combine(fDir, String.Concat(fName, suffix, fExt));
        }

        // https://superuser.com/a/377407 BEST TRIM DOCUMENTATION
        void button1_Click(object sender, EventArgs e)
        {

            int allResults = 0;

            for (int i = 0; i < inputFilePaths.Count; i++)
            {
                // Switch /C to /K to keep cmd open
                string args =
                   "/C ffmpeg -i \""
                   + inputFilePaths[i]
                   + "\" "
                   + " -vcodec libx264 -crf "
                   + form.numericUpDown1.Value
                   + " \""
                   + outputFilePaths[i]
                   + "\"";

                //MessageBox.Show(args);

                System.Diagnostics.Process P = System.Diagnostics.Process.Start(@"cmd.exe", args);

                P.WaitForExit();
                allResults += P.ExitCode;


            }

            //MessageBox.Show(args);
            //MessageBox.Show(result.ToString());

            /*
            if (allResults == 0)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Errors found!");
            }
            */
            Application.Exit();
        }
    }
}
