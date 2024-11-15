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
        string inputPath;
        string outputPath;

        public QTTBTrimmer(string inputPath)
        {
            this.form = new GUI();
            this.inputPath = inputPath;
            form.button1.Click += new System.EventHandler(button1_Click);
            //MessageBox.Show(form.dateTimePicker1.Value.TimeOfDay.ToString());

            outputPath = AddSuffix(inputPath, "_Trim");
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

        void button1_Click(object sender, EventArgs e)
        {
            string args =
               "/K ffmpeg -ss "
               + form.dateTimePicker1.Value.TimeOfDay.ToString()
               + " -to "
               + form.dateTimePicker2.Value.TimeOfDay.ToString()
               + " "
               + "-i \""
               + inputPath
               + "\" \""
               + this.outputPath
               + "\"";

            //MessageBox.Show(args);

            System.Diagnostics.Process.Start(@"cmd.exe", args);
        }
    }
}
