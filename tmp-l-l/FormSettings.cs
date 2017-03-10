using System;
using System.Drawing;
using System.Windows.Forms;

namespace tmp_l_l
{
    public partial class FormSettings : Form
    {
        int X;
        int Y;

        public FormSettings(int x, int y)
        {
            InitializeComponent();

            X = x;
            Y = y;
        }

        //On load
        private void FormSettings_onLoad(object sender, EventArgs e)
        {
            this.Location = new Point(X, Y);

            //Nointro
            string r = LLR.GetRegistry("nointro");
            if (r != null)
            {
                if (r.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    skipIntro.Checked = true;
                }
            }

            //Graphics dropdown
            graphics.Items.Add("Auto (recommended)");
            graphics.Items.Add("DirectX");
            graphics.Items.Add("OpenGL");

            r = LLR.GetRegistry("graphics");
            if (r != null)
            {
                if (r.Equals("directx", StringComparison.OrdinalIgnoreCase))
                {
                    graphics.SelectedIndex = 1;
                }
                else if (r.Equals("opengl", StringComparison.OrdinalIgnoreCase))
                {
                    graphics.SelectedIndex = 2;
                }
                else
                {
                    graphics.SelectedIndex = 0;
                }
            }
            else
            {
                graphics.SelectedIndex = 0;
            }

            //Other parameters
            r = LLR.GetRegistry("otherparams");
            if (r != null)
            {
                parameters.Text = r;
            }

            //Server list
            r = LLR.GetRegistry("servers");
            if (r != null)
            {
                if (r.Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    displayServers.Checked = true;
                }
            }
            else
            {
                displayServers.Checked = true;
            }
        }

        //Close button
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Save button
        private void save_Click(object sender, EventArgs e)
        {
            //Saving shit

            //nointro
            if (skipIntro.Checked == true)
            {
                LLR.SetRegistry("nointro", "true");
            }
            else
            {
                LLR.SetRegistry("nointro", "false");
            }

            //graphics
            if (graphics.SelectedIndex == 1)
            {
                LLR.SetRegistry("graphics", "directx");
            }
            else if (graphics.SelectedIndex == 2)
            {
                LLR.SetRegistry("graphics", "opengl");
            }
            else
            {
                LLR.SetRegistry("graphics", "auto");
            }

            //other
            LLR.SetRegistry("otherparams", parameters.Text);

            //server list
            if (displayServers.Checked == true)
            {
                LLR.SetRegistry("servers", "true");
            }
            else
            {
                LLR.SetRegistry("servers", "false");
            }

            //Then tell the user we've saved shit.
            MessageBox.Show("The settings have been saved.\nYou will need to restart the launcher for the changes to apply.",
                    "Saved",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
