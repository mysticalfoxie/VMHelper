using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace AudioProcessHelper.Services
{
    class ProcessService
    {
        public static Process[] GetProcesses(string[] names)
        {
            var list = new List<Process>();

            foreach (var name in names)
            {
                var processes = Process.GetProcessesByName(name.Replace(".exe", ""));
                if (processes.Length == 0)
                    MessageBox.Show(
                        $"Could not find a process that goes by name '{name}'.\n\nMaybe it has been closed or the input is invalid.",
                        "Cannot find Process",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                list.AddRange(processes);
            }

            return list.ToArray();
        }

        public static void IncreasePriority(Process[] processes)
        {
            foreach (var process in processes)
                process.PriorityClass = ProcessPriorityClass.High;
        }

        public static void SetAffinity(Process[] processes)
        {
            foreach (var process in processes)
                process.ProcessorAffinity = (IntPtr)1;
        }
    }
}
