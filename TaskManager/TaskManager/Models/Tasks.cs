using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{

    public class Tasks
    {
        // Fields
        private List<Task> tasks;

        // Constructor
        public Tasks()
        {
            tasks = new List<Task>();
        }

        // Methods

        // Add a task to the task list
        void AddTask(Task task)
        {
            tasks.Add(task);
        }

        // Remove the task at the specified list index from the task list
        void RemoveTaskAt(Int32 idx)
        {
            tasks.RemoveAt(idx);
        }

        // Return a string representation of the task list
        public List<string> GetStringRepresentationsOfTasks()
        {
            List<string> stringList = new List<string>();

            foreach (Task task in tasks)
            {
                stringList.Add(task.ToString());
            }
            return stringList;
        }

    }

}
