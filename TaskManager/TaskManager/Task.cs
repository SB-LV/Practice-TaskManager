using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        public string Name { get; set; }
        public string DueDate { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }

        // Constructor
        public Task(string name, string dueDate, string description)
        {
            Name = name;
            DueDate = dueDate;
            Description = description;
            Completed = false; // Default to not completed
        }

        // You can add more methods or properties as needed
        public override string ToString()
        {
            return $"{Name} - Due: {DueDate} - Status: {(Completed ? "Completed" : "Not Completed")}";
        }
    }
}
