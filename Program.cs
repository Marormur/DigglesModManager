﻿using DigglesModManager.Properties;
using System;
using System.Windows.Forms;

namespace DigglesModManager
{
    public static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) 
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new FormMain());
            }
            catch (System.IO.FileNotFoundException e)
            {
                Helpers.ShowErrorMessage(Resources.FormMain_CouldNotFindFile.Replace("FILENAME", e.FileName));
            }

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
