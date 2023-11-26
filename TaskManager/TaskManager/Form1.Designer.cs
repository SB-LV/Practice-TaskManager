namespace TaskManager
{
    partial class TaskForm
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
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.textBoxDueDate = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(71, 50);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(228, 276);
            this.listBoxTasks.TabIndex = 0;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(339, 87);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(87, 29);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click_1);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Location = new System.Drawing.Point(339, 50);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(87, 22);
            this.textBoxTaskName.TabIndex = 2;
            // 
            // textBoxDueDate
            // 
            this.textBoxDueDate.Location = new System.Drawing.Point(448, 50);
            this.textBoxDueDate.Name = "textBoxDueDate";
            this.textBoxDueDate.Size = new System.Drawing.Size(87, 22);
            this.textBoxDueDate.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(568, 50);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(87, 22);
            this.textBoxDescription.TabIndex = 2;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(68, 31);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(45, 16);
            this.lblTasks.TabIndex = 3;
            this.lblTasks.Text = "Tasks";
            this.lblTasks.Click += new System.EventHandler(this.lblTasks_Click);
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(336, 31);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(38, 16);
            this.lblTask.TabIndex = 3;
            this.lblTask.Text = "Task";
            this.lblTask.Click += new System.EventHandler(this.lblTasks_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(445, 31);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(62, 16);
            this.lblDueDate.TabIndex = 3;
            this.lblDueDate.Text = "Due date";
            this.lblDueDate.Click += new System.EventHandler(this.lblTasks_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(565, 31);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(75, 16);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblTasks_Click);
            // 
            // TaskForm
            // 
            this.ClientSize = new System.Drawing.Size(701, 385);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.lblTask);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxDueDate);
            this.Controls.Add(this.textBoxTaskName);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.listBoxTasks);
            this.Name = "TaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.TextBox textBoxDueDate;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDescription;
    }
}

