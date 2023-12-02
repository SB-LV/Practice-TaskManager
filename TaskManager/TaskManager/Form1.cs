using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private Tasks tasks;
        public Form1()
        {
            InitializeComponent();
            tasks = new Tasks();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Task newTask = new Task(txtBoxTaskName.Text, dateTimePckTaskDatetime.Value, false, txtBoxTaskDescription.Text);
            tasks.AddTask(newTask);
            listBoxTaskList.DataSource = tasks.GetStringRepresentationsOfTasks();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            if (listBoxTaskList.SelectedIndex < 0) { return; }
            tasks.RemoveTaskAt(listBoxTaskList.SelectedIndex);
            listBoxTaskList.DataSource = tasks.GetStringRepresentationsOfTasks();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (listBoxTaskList.SelectedIndex < 0) { return; }
            tasks.ToggleTaskAt(listBoxTaskList.SelectedIndex);
            listBoxTaskList.DataSource = tasks.GetStringRepresentationsOfTasks();
        }
    }
}
