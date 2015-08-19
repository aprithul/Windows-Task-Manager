using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace WindowsTaskManager
{
    class ProcessManager
    {

        public static Process[] getProcesses()
        {
            Process[] processes = Process.GetProcesses();
            return processes;
        }

        public static Process[] getApplications()
        {
           Process[] processes = Process.GetProcesses();
           List<Process> processesList = new List<Process>();

            foreach (Process proc in processes)
            {
                if (!String.IsNullOrEmpty(proc.MainWindowTitle))
                    processesList.Add(proc);
            }

            return processesList.ToArray();
        }






    }
}
