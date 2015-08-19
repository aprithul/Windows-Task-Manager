using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsTaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void newTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTask();
        }

        private void newtask_button_Click(object sender, EventArgs e)
        {
            newTask();
        }

        private void newTask()
        {
            new NewTaskForm().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            RefreshApplications();
            RefreshProcesses();
        }


        private void RefreshApplications()
        {
            Process[] applications = ProcessManager.getApplications();

            if (applications_listview.Items.Count != applications.Length)
            {
                applications_listview.Items.Clear();
                foreach (Process app in applications)
                {
                    applications_listview.Items.Add(app.MainWindowTitle).SubItems.Add( app.Responding?"Running":"Not Responding") ;
                    
                    

                }
            }
        }

        private void RefreshProcesses()
        {
           
            Process[] processes = ProcessManager.getProcesses();

            if (processes_listview.Items.Count != processes.Length)
            {
                processes_listview.Items.Clear();
                foreach (Process proc in processes)
                {
                    processes_listview.Items.Add(proc.ProcessName);
                }
            }
        }
    }
}
