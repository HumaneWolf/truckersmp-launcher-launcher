using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;
using System.ComponentModel;

namespace tmp_l_l
{
    public partial class FormMain : Form
    {
        //Variables
        bool displayServers = true;
        Boolean opened = false; //Has the launcher opened yet?
        string atsPath = null; //ATS path   
        string etsPath = null; //ETS2 path   
        int x;
        int y;
        string gameparams;

        public FormMain(string gp)
        {
            InitializeComponent();

            gameparams = gp;

            //Load the ETS and ATS directories.
            atsPath = LLR.ReadTmpRegistry("InstallLocationATS");
            etsPath = LLR.ReadTmpRegistry("InstallLocationETS2");

            //Hide buttons if they don't have the games (according to the tmp launcher)
            if (atsPath == null)
            {
                buttonAtsSP.Visible = false;
            }

            if (etsPath == null)
            {
                buttonEtsSP.Visible = false;
            }

            //Load server list settings
            string tempServers = LLR.GetRegistry("servers");
            if (tempServers != null)
            {
                if (tempServers.Equals("false", StringComparison.OrdinalIgnoreCase))
                {
                    displayServers = false;
                }
            }
        }

        //On load
        private void FormMain_onLoad(object sender, EventArgs e)
        {
            //Hide the UI until the launcher is up
            this.Opacity = 0;

            //Force to be topmost.
            this.TopMost = true;

            //Deal with server list stuff if it's enabled.
            if (displayServers)
            {
                //Update server list
                ServerList.updateServerList();

                //Add data to the server list.
                dataGridViewServers.AutoGenerateColumns = false;
                dataGridViewServers.AutoSize = true;
                dataGridViewServers.DataSource = ServerList.list;
                //Column: name
                DataGridViewColumn col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = "colName";
                col.Name = "Name";
                dataGridViewServers.Columns.Add(col);
                //Column: Players
                col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = "colPlayers";
                col.Name = "Players";
                dataGridViewServers.Columns.Add(col);
                //Column: Queue
                col = new DataGridViewTextBoxColumn();
                col.DataPropertyName = "colQueue";
                col.Name = "Queue";
                dataGridViewServers.Columns.Add(col);

                //Automaticly resize the height of the rows when necessary
                dataGridViewServers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            else
            {
                //hide shit
                dataGridViewServers.Visible = false;
                labelToggleServers.Visible = false;
            }
        }

        //Define the things necessary for window position
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int X;
            public int Y;
            public int Width;
            public int Height;
        }

        //Importing some functions from a dll
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);


        //Timer: Quick timer, 0.2 sec
        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr hWnd = FindWindow(null, "TruckersMP Launcher");

            RECT rect;
            Boolean result = GetWindowRect(hWnd, out rect);

            //If the launcher is not open.
            if (result == false)
            {
                //If the launcher has been open.
                if (opened == true)
                {
                    //Close this software.
                    Application.Exit();
                }
                else
                {
                    //If it hasn't been open yet. Just end function.
                    return;
                }
            }
            else
            {
                //If it is open, make sure that the opened var is updated.
                opened = true;
                this.Opacity = 100;
            }

            //If the window (launcher) is minimized or not in focus.
            if (rect.X == -32000
                || !(GetActiveWindowTitle().Equals("TruckersMP Launcher", StringComparison.OrdinalIgnoreCase)
                || GetActiveWindowTitle().Equals("TruckersMP Launcher Launcher", StringComparison.OrdinalIgnoreCase)))
            {
                //No longer force the launcher launcher to be at the top
                this.TopMost = false;
            }
            else
            {
                //Force the launcher launcher to be at the top above hte launcher again.
                this.TopMost = true;

                this.Location = new Point(rect.X, rect.Y);

                x = rect.X;
                y = rect.Y;
            }
        }

        //Timer: Long timer, 30 sec
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (displayServers)
            {
                //Update server data
                ServerList.updateServerList();
            }
        }

        //
        // On Click Methods
        //

        //Start ATS SP
        private void buttonAtsSP_Click(object sender, EventArgs e)
        {
            //Kill official launcher
            KillLauncher();
            //Start the game
            StartProgram(atsPath + @"\bin\win_x64\amtrucks.exe", gameparams);
            //Quit launcher addon
            Application.Exit();
        }

        //Start ETS2 SP
        private void buttonEtsSP_Click(object sender, EventArgs e)
        {
            KillLauncher();
            StartProgram(etsPath + @"\bin\win_x64\eurotrucks2.exe", gameparams);
            Application.Exit();
        }

        //Open settings UI.
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings(x, y);

            settings.Show();
        }

        //Toggle the server list.
        private void labelToggleServers_Click(object sender, EventArgs e)
        {
            if (dataGridViewServers.Visible == true)
            {
                dataGridViewServers.Visible = false;
            }
            else
            {
                dataGridViewServers.Visible = true;
            }
        }


        //
        // Helping methods
        //

        //Start a program, with optional arguments.
        private void StartProgram(string path, string args = "")
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = path;
            startInfo.Arguments = args;
            process.StartInfo = startInfo;
            process.Start();
        }

        //Function to kill the official launcher
        private void KillLauncher()
        {
            foreach (var process in Process.GetProcessesByName("Launcher"))
            {
                process.Kill();
            }
        }

        //Find the title of the active window.
        private string GetActiveWindowTitle()
        {
            StringBuilder Buff = new StringBuilder(256);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, 256) > 0)
            {
                return Buff.ToString();
            }
            else
            {
                return " ";
            }
        }
    }
}
