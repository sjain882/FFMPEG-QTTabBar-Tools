using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace QTTB_MKV_To_MP4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputFilePaths;
            List<string> outputFilePaths;

            inputFilePaths = new List<string>(args);
            outputFilePaths = new List<string>(args);

            for (int i = 0; i < outputFilePaths.Count; i++)
            {
                outputFilePaths[i] = Path.ChangeExtension(outputFilePaths[i], ".mp4");
            }

            for (int i = 0; i < inputFilePaths.Count; i++)
            {
                // Switch /C to /K to keep cmd open
                string args2 =
                   "/C ffmpeg -i \""
                   + inputFilePaths[i]
                   + "\" -codec copy "
                   + " \""
                   + outputFilePaths[i]
                   + "\" -movflags +faststart -strict experimental";

                //MessageBox.Show(args2);

                System.Diagnostics.Process P = System.Diagnostics.Process.Start(@"cmd.exe", args2);

                P.WaitForExit();
            }
        }
    }
}
