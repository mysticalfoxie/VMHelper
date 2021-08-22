using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
using AudioProcessHelper.Services;
using AudioProcessHelper.UI;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Data.Xml.Dom;
using Windows.System;
using Windows.UI.Notifications;

namespace AudioProcessHelper
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] launchArguments)
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();

            if (launchArguments.Select(x => x.ToLower(CultureInfo.InvariantCulture)).Contains("--silent"))
            {
                JustGo();
            }
            else
            {
                Application.Run(new MainForm());
            }
        }

        private static void JustGo()
        {
            try
            {
                string[] processes = GetProcesses();
                ManipulateProcesses(processes);
                new ToastContentBuilder()
                    .AddText("Successfully manipulated the process(es):")
                    .AddText(string.Join(", ", processes.Select(x => $"\"{x}.exe\"").ToArray()))
                    .SetToastDuration(ToastDuration.Short)
                    .Show();
            }
            catch (Exception ex)
            {
                new ToastContentBuilder()
                    .AddText("An error occured!")
                    .AddText($"{ex.Message}")
                    .Show();
            }
            finally
            {
                Application.Exit();
            }
        }

        private static void ManipulateProcesses(string[] names)
        {
            Process[] processes = ProcessService.GetProcesses(names);
            ProcessService.IncreasePriority(processes);
            ProcessService.SetAffinity(processes);
        }

        private static string[] GetProcesses()
        {
            return ConfigService
                .Load()
                .Processes
                .Where(x => x.Checked)
                .Select(x => x.Name)
                .ToArray();
        }
    }
}
