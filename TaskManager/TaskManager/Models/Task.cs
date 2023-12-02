using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskManager
{
    public class Task
    {
        // Fields
        private string name;
        private DateTime dateTime;
        private bool isCompleted;
        private string description;

        // Properties
        public string TaskName
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime TaskDateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        public string TaskDescription
        {
            get { return description; }
            set { description = value; }
        }

        // Constructor
        public Task(string tName, DateTime timestamp, bool completed, string desc)
        {
            name = tName;
            dateTime = timestamp;
            isCompleted = completed;
            description = desc;
        }
    }
}