using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
