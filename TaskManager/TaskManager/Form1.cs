using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class TaskForm : Form
    {
        public TaskForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            // Get task details from TextBoxes
            string taskName = textBoxTaskName.Text;
            string dueDate = textBoxDueDate.Text;
            string description = textBoxDescription.Text;

            // Validate input (you can add more validation)
            if (string.IsNullOrEmpty(taskName) || string.IsNullOrEmpty(dueDate))
            {
                MessageBox.Show("Task name and due date are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a Task object (you'll need to define a Task class)
            Task newTask = new Task(taskName, dueDate, description);

            // Add the task to the ListBox or your data structure
            listBoxTasks.Items.Add(newTask);

            // Clear TextBoxes after adding a task
            textBoxTaskName.Clear();
            textBoxDueDate.Clear();
            textBoxDescription.Clear();
        }

 
    }
}
