using AudioProcessHelper.Services;
using AudioProcessHelper.UI;
using System;
using System.Windows.Forms;

namespace AudioProcessHelper
{
    static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            if (new LaunchArguments(args).NoGUI) { 
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.Run(new MainForm());
            }
            else
                QuickLaunchService.Start();
        }
    }
}
