using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEx1
{
    public abstract class User
    {
        private int Id { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private string Email { get; set; }

        public List<Event> Events { get; set; }

        public User(int id, string username, string password, string email)
        {
            this.Id = id;
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Events = new List<Event>();
        }

        public bool Login(string username, string password)
        {
            if (this.Username == username && this.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Logout()
        {
            
        }

        public int GetId()
        {
            return Id;
        }

        public string GetUsername()
        {
            return Username;
        }

        public string GetEmail()
        {
            return Email;
        }
    }
}
