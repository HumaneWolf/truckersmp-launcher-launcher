using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace tmp_l_l
{
    static class LLR
    {
        //
        // REGISTRY HELPER METHODS
        //

        //Load value from TruckersMP registry
        public static string ReadTmpRegistry(string name)
        {
            try
            {
                string regVal = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\TruckersMP", name, null);
                if (regVal == null)
                {
                    return null;
                }
                else
                {
                    return regVal;
                }
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }
        }

        //Save value to the Launcher Launcher registry
        public static void SetRegistry(string name, string value)
        {
            try
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\TruckersMP-LL", name, value, RegistryValueKind.ExpandString);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Error: Failed to save data (R).");
                MessageBox.Show("Failed to save data: " + name + "=" + value,
                    "Failed to save data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Load value from the Launcher Launcher registry
        public static string GetRegistry(string name)
        {
            try
            {
                string regVal = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\TruckersMP-LL", name, null);
                if (regVal == null)
                {
                    return null;
                }
                else
                {
                    return regVal;
                }
            }
            catch (UnauthorizedAccessException)
            {
                return null;
            }
        }
    }
}
