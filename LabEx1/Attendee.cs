using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx1
{
    public class Attendee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public AttendeeCategory Category { get; set; }
        public Attendee(string name, string email, string sex, AttendeeCategory category)
        {
            this.Name = name;
            this.Email = email;
            this.Sex = sex;
            this.Category = category;
        }
    }
}
