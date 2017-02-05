using Microsoft.Win32;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace tmp_l_l
{
    static class Program
    {
        /// <summary>
        /// A program using an overlay to add some features to the official TruckersMP launcher.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Load the TMP directory.
            string tmpDir = LLR.ReadTmpRegistry("InstallDir");

            //Check if the TMP directory is set.
            if (tmpDir == null)
            {
                //Show error.
                MessageBox.Show("Could not find the TruckersMP install directory.",
                    "TruckersMP Not Installed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                //And quit
                return;
            }
            //If it is set, continue with the program.

            //Load up parameters
            string gameparams = ""; //defaults to blank

            //nointro
            string r = LLR.GetRegistry("nointro");
            if (r != null)
            {
                if (r.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    gameparams = gameparams + "-nointro ";
                }
            }

            //graphics
            r = LLR.GetRegistry("graphics");
            if (r != null)
            {
                if (r.Equals("directx", StringComparison.OrdinalIgnoreCase))
                {
                    gameparams = gameparams + "-rdevice dx9 ";
                }
                else if (r.Equals("opengl", StringComparison.OrdinalIgnoreCase))
                {
                    gameparams = gameparams + "-rdevice gl ";
                }
            }

            r = LLR.GetRegistry("otherparams");
            //other
            if (r != null)
            {
                gameparams = gameparams + r;
            }

            //Load up the official launcher.
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = tmpDir + "\\Launcher.exe";
            startInfo.Arguments = gameparams;
            process.StartInfo = startInfo;
            process.Start();
            
            //Load up the window form thingy
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain(gameparams));
        }
    }
}
