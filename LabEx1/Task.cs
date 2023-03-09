using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx1
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string AssignedTo { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string name, string description, DateTime deadline, string assignedTo)
        {
            this.Name = name;
            this.Description = description;
            this.Deadline = deadline;
            this.AssignedTo = assignedTo;
            this.IsCompleted = false;
        }

        public void MarkAsCompleted()
        {
            this.IsCompleted = true;
        }
    }
}
