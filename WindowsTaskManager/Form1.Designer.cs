namespace WindowsTaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processes = new System.Windows.Forms.TabPage();
            this.endprocess_button = new System.Windows.Forms.Button();
            this.processes_listview = new System.Windows.Forms.ListView();
            this.processname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.applications = new System.Windows.Forms.TabPage();
            this.endtask_button = new System.Windows.Forms.Button();
            this.newtask_button = new System.Windows.Forms.Button();
            this.applications_listview = new System.Windows.Forms.ListView();
            this.task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskmanager_tabcontrol = new System.Windows.Forms.TabControl();
            this.services = new System.Windows.Forms.TabPage();
            this.services_listview = new System.Windows.Forms.ListView();
            this.servicename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serviedescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.servicestatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.process_toolstriplabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cpu_toolstriplabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.memory_toolstriplabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.alwaysOnTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWhenMinimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.processes.SuspendLayout();
            this.applications.SuspendLayout();
            this.taskmanager_tabcontrol.SuspendLayout();
            this.services.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.newTaskToolStripMenuItem.Text = "New Task";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTToolStripMenuItem,
            this.minimizeToolStripMenuItem,
            this.hideWhenMinimizedToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // processes
            // 
            this.processes.Controls.Add(this.endprocess_button);
            this.processes.Controls.Add(this.processes_listview);
            this.processes.Location = new System.Drawing.Point(4, 25);
            this.processes.Name = "processes";
            this.processes.Padding = new System.Windows.Forms.Padding(3);
            this.processes.Size = new System.Drawing.Size(458, 463);
            this.processes.TabIndex = 1;
            this.processes.Text = "Processes";
            this.processes.UseVisualStyleBackColor = true;
            // 
            // endprocess_button
            // 
            this.endprocess_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endprocess_button.Location = new System.Drawing.Point(319, 418);
            this.endprocess_button.Name = "endprocess_button";
            this.endprocess_button.Size = new System.Drawing.Size(121, 33);
            this.endprocess_button.TabIndex = 1;
            this.endprocess_button.Text = "End Process";
            this.endprocess_button.UseVisualStyleBackColor = true;
            // 
            // processes_listview
            // 
            this.processes_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processes_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.processname,
            this.cpu,
            this.memory,
            this.description});
            this.processes_listview.Location = new System.Drawing.Point(20, 20);
            this.processes_listview.Name = "processes_listview";
            this.processes_listview.Size = new System.Drawing.Size(420, 386);
            this.processes_listview.TabIndex = 0;
            this.processes_listview.UseCompatibleStateImageBehavior = false;
            this.processes_listview.View = System.Windows.Forms.View.Details;
            // 
            // processname
            // 
            this.processname.Text = "Process Name";
            this.processname.Width = 120;
            // 
            // cpu
            // 
            this.cpu.Text = "CPU";
            // 
            // memory
            // 
            this.memory.Text = "Memory";
            this.memory.Width = 80;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 200;
            // 
            // applications
            // 
            this.applications.Controls.Add(this.endtask_button);
            this.applications.Controls.Add(this.newtask_button);
            this.applications.Controls.Add(this.applications_listview);
            this.applications.Location = new System.Drawing.Point(4, 25);
            this.applications.Name = "applications";
            this.applications.Padding = new System.Windows.Forms.Padding(3);
            this.applications.Size = new System.Drawing.Size(458, 463);
            this.applications.TabIndex = 0;
            this.applications.Text = "Applications";
            this.applications.UseVisualStyleBackColor = true;
            // 
            // endtask_button
            // 
            this.endtask_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endtask_button.Location = new System.Drawing.Point(184, 420);
            this.endtask_button.Name = "endtask_button";
            this.endtask_button.Size = new System.Drawing.Size(125, 30);
            this.endtask_button.TabIndex = 2;
            this.endtask_button.Text = "End Task";
            this.endtask_button.UseVisualStyleBackColor = true;
            // 
            // newtask_button
            // 
            this.newtask_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.newtask_button.Location = new System.Drawing.Point(315, 420);
            this.newtask_button.Name = "newtask_button";
            this.newtask_button.Size = new System.Drawing.Size(125, 30);
            this.newtask_button.TabIndex = 1;
            this.newtask_button.Text = "New Task...";
            this.newtask_button.UseVisualStyleBackColor = true;
            this.newtask_button.Click += new System.EventHandler(this.newtask_button_Click);
            // 
            // applications_listview
            // 
            this.applications_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applications_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.task,
            this.status});
            this.applications_listview.Location = new System.Drawing.Point(20, 20);
            this.applications_listview.Name = "applications_listview";
            this.applications_listview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.applications_listview.Size = new System.Drawing.Size(420, 386);
            this.applications_listview.TabIndex = 0;
            this.applications_listview.UseCompatibleStateImageBehavior = false;
            this.applications_listview.View = System.Windows.Forms.View.Details;
            // 
            // task
            // 
            this.task.Text = "Task";
            this.task.Width = 320;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 100;
            // 
            // taskmanager_tabcontrol
            // 
            this.taskmanager_tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskmanager_tabcontrol.Controls.Add(this.applications);
            this.taskmanager_tabcontrol.Controls.Add(this.processes);
            this.taskmanager_tabcontrol.Controls.Add(this.services);
            this.taskmanager_tabcontrol.ItemSize = new System.Drawing.Size(86, 21);
            this.taskmanager_tabcontrol.Location = new System.Drawing.Point(0, 25);
            this.taskmanager_tabcontrol.Name = "taskmanager_tabcontrol";
            this.taskmanager_tabcontrol.SelectedIndex = 0;
            this.taskmanager_tabcontrol.Size = new System.Drawing.Size(466, 492);
            this.taskmanager_tabcontrol.TabIndex = 1;
            // 
            // services
            // 
            this.services.Controls.Add(this.services_listview);
            this.services.Location = new System.Drawing.Point(4, 25);
            this.services.Name = "services";
            this.services.Padding = new System.Windows.Forms.Padding(3);
            this.services.Size = new System.Drawing.Size(458, 463);
            this.services.TabIndex = 2;
            this.services.Text = "Services";
            this.services.UseVisualStyleBackColor = true;
            // 
            // services_listview
            // 
            this.services_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.services_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.servicename,
            this.serviedescription,
            this.servicestatus});
            this.services_listview.Location = new System.Drawing.Point(20, 20);
            this.services_listview.Name = "services_listview";
            this.services_listview.Size = new System.Drawing.Size(420, 386);
            this.services_listview.TabIndex = 1;
            this.services_listview.UseCompatibleStateImageBehavior = false;
            this.services_listview.View = System.Windows.Forms.View.Details;
            // 
            // servicename
            // 
            this.servicename.Text = "Services";
            this.servicename.Width = 200;
            // 
            // serviedescription
            // 
            this.serviedescription.Text = "Description";
            this.serviedescription.Width = 120;
            // 
            // servicestatus
            // 
            this.servicestatus.Text = "Status";
            this.servicestatus.Width = 100;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.process_toolstriplabel,
            this.cpu_toolstriplabel,
            this.memory_toolstriplabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(466, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "systemstatus_statusstrip";
            // 
            // process_toolstriplabel
            // 
            this.process_toolstriplabel.Name = "process_toolstriplabel";
            this.process_toolstriplabel.Size = new System.Drawing.Size(92, 20);
            this.process_toolstriplabel.Text = "Processes 10";
            // 
            // cpu_toolstriplabel
            // 
            this.cpu_toolstriplabel.Name = "cpu_toolstriplabel";
            this.cpu_toolstriplabel.Size = new System.Drawing.Size(113, 20);
            this.cpu_toolstriplabel.Text = "CPU Usage 10%";
            // 
            // memory_toolstriplabel
            // 
            this.memory_toolstriplabel.Name = "memory_toolstriplabel";
            this.memory_toolstriplabel.Size = new System.Drawing.Size(152, 20);
            this.memory_toolstriplabel.Text = "Physical Memory 40%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // alwaysOnTToolStripMenuItem
            // 
            this.alwaysOnTToolStripMenuItem.Name = "alwaysOnTToolStripMenuItem";
            this.alwaysOnTToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.alwaysOnTToolStripMenuItem.Text = "Always On Top";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.minimizeToolStripMenuItem.Text = "Minimize On Use";
            // 
            // hideWhenMinimizedToolStripMenuItem
            // 
            this.hideWhenMinimizedToolStripMenuItem.Name = "hideWhenMinimizedToolStripMenuItem";
            this.hideWhenMinimizedToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.hideWhenMinimizedToolStripMenuItem.Text = "Hide When Minimized";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.taskmanager_tabcontrol);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Windows Task Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.processes.ResumeLayout(false);
            this.applications.ResumeLayout(false);
            this.taskmanager_tabcontrol.ResumeLayout(false);
            this.services.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage processes;
        private System.Windows.Forms.ListView processes_listview;
        private System.Windows.Forms.TabPage applications;
        private System.Windows.Forms.Button endtask_button;
        private System.Windows.Forms.Button newtask_button;
        private System.Windows.Forms.ListView applications_listview;
        private System.Windows.Forms.ColumnHeader task;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.TabControl taskmanager_tabcontrol;
        private System.Windows.Forms.Button endprocess_button;
        private System.Windows.Forms.ColumnHeader processname;
        private System.Windows.Forms.ColumnHeader cpu;
        private System.Windows.Forms.ColumnHeader memory;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabPage services;
        private System.Windows.Forms.ListView services_listview;
        private System.Windows.Forms.ColumnHeader servicename;
        private System.Windows.Forms.ColumnHeader serviedescription;
        private System.Windows.Forms.ColumnHeader servicestatus;
        private System.Windows.Forms.ToolStripStatusLabel process_toolstriplabel;
        private System.Windows.Forms.ToolStripStatusLabel cpu_toolstriplabel;
        private System.Windows.Forms.ToolStripStatusLabel memory_toolstriplabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizedToolStripMenuItem;
    }
}

