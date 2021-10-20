using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PerfectWardChallenge.Utilities
{
    public static class Browser
    {
        public static void KillProcess(string processName)
        {
            try
            {
                Process[] runingProcesses = Process.GetProcesses();
                foreach (var process in runingProcesses)
                {
                    if (process.ProcessName.Contains(processName))
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
