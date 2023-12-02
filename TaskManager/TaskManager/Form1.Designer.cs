namespace TaskManager
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
            this.listBoxTaskList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblDateTimePck = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtBoxTaskName = new System.Windows.Forms.TextBox();
            this.dateTimePckTaskDatetime = new System.Windows.Forms.DateTimePicker();
            this.txtBoxTaskDescription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxTaskList
            // 
            this.listBoxTaskList.FormattingEnabled = true;
            this.listBoxTaskList.ItemHeight = 16;
            this.listBoxTaskList.Location = new System.Drawing.Point(37, 55);
            this.listBoxTaskList.Name = "listBoxTaskList";
            this.listBoxTaskList.Size = new System.Drawing.Size(695, 308);
            this.listBoxTaskList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(793, 36);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(75, 16);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "Task name";
            // 
            // lblDateTimePck
            // 
            this.lblDateTimePck.AutoSize = true;
            this.lblDateTimePck.Location = new System.Drawing.Point(926, 36);
            this.lblDateTimePck.Name = "lblDateTimePck";
            this.lblDateTimePck.Size = new System.Drawing.Size(64, 16);
            this.lblDateTimePck.TabIndex = 4;
            this.lblDateTimePck.Text = "Task due";
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Location = new System.Drawing.Point(793, 92);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(75, 16);
            this.lblTaskDescription.TabIndex = 5;
            this.lblTaskDescription.Text = "Description";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(796, 237);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(105, 48);
            this.btnRemoveTask.TabIndex = 6;
            this.btnRemoveTask.Text = "Remove task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(796, 315);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(105, 48);
            this.btnComplete.TabIndex = 6;
            this.btnComplete.Text = "Toggle complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(796, 151);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(105, 48);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtBoxTaskName
            // 
            this.txtBoxTaskName.Location = new System.Drawing.Point(796, 55);
            this.txtBoxTaskName.Name = "txtBoxTaskName";
            this.txtBoxTaskName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTaskName.TabIndex = 7;
            // 
            // dateTimePckTaskDatetime
            // 
            this.dateTimePckTaskDatetime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimePckTaskDatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePckTaskDatetime.Location = new System.Drawing.Point(929, 55);
            this.dateTimePckTaskDatetime.Name = "dateTimePckTaskDatetime";
            this.dateTimePckTaskDatetime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePckTaskDatetime.TabIndex = 8;
            // 
            // txtBoxTaskDescription
            // 
            this.txtBoxTaskDescription.Location = new System.Drawing.Point(796, 111);
            this.txtBoxTaskDescription.Name = "txtBoxTaskDescription";
            this.txtBoxTaskDescription.Size = new System.Drawing.Size(100, 22);
            this.txtBoxTaskDescription.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 450);
            this.Controls.Add(this.txtBoxTaskDescription);
            this.Controls.Add(this.dateTimePckTaskDatetime);
            this.Controls.Add(this.txtBoxTaskName);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.lblDateTimePck);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTaskList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTaskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.Label lblDateTimePck;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtBoxTaskName;
        private System.Windows.Forms.DateTimePicker dateTimePckTaskDatetime;
        private System.Windows.Forms.TextBox txtBoxTaskDescription;
    }
}

