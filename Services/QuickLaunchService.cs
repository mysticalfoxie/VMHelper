using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioProcessHelper.Services
{
    internal static class QuickLaunchService
    {
        public static void Start()
        {
            try
            {
                var processes = GetProcessesByConfig();
                if (processes.Length == 0)
                    return;

                ProcessService.IncreasePriority(processes);
                ProcessService.SetAffinity(processes);

                new ToastContentBuilder()
                    .AddText("Successfully prioritized the process(es):")
                    .AddText(GetProcessListString(processes))
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
        }

        private static string GetProcessListString(Process[] processes)
        {
            if (processes.Length > 3)
            {
                var names = processes[..3].Select(x => x.ProcessName);
                var joined = string.Join(", ", names);
                var count = processes.Length - 3;
                return joined + $" (and {count} more)";
            }
            else
            {
                var names = processes.Select(x => x.ProcessName);
                var joined = string.Join(", ", names);
                return joined;
            }
        }

        private static Process[] GetProcessesByConfig()
        {
            var recentProcesses = ConfigService
                .Load()
                .Processes
                .Where(x => x.Checked)
                .Select(x => x.Name)
                .ToArray();

            return ProcessService.GetProcesses(recentProcesses);
        }
    }
}
