using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx1
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public List<Attendee> Attendees { get; set; }
        public Budget Budget { get; set; }
        public List<Task> Tasks { get; set; }
        public int MaxAttendees { get; set; }
        public Event(string name, DateTime date, string location, string description, int maxAttendees, Budget budget)
        {
            this.Name = name;
            this.Date = date;
            this.Location = location;
            this.Description = description;
            this.MaxAttendees = maxAttendees;
            this.Attendees = new List<Attendee>();
            this.Budget = budget;
            this.Tasks = new List<Task>();
        }

        public void AddAttendee(Attendee attendee)
        {
            this.Attendees.Add(attendee);
        }

        public void RemoveAttendee(Attendee attendee) 
        {
            this.Attendees.Remove(attendee);
        }

        public void AddTask(Task task)
        {
            this.Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            this.Tasks.Remove(task);
        }
    }
}
