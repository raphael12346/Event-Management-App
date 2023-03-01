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

        public Event(string name, DateTime date, string location, string description)
        {
            this.Name = name;
            this.Date = date;
            this.Location = location;
            this.Description = description;
            this.Attendees = new List<Attendee>();
        }

        public void AddAttendee(Attendee attendee)
        {
            Attendees.Add(attendee);
        }

        public void RemoveAttendee(Attendee attendee) 
        {
            Attendees.Remove(attendee);
        }
    }
}
