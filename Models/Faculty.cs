using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Models
{
    public class Faculty
    {
        public int SrNo {  get; set; }
        public int Id { get; set; }
        public int User_id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public Role Role { get; set; }
        public Designation Designation { get; set; }
        public string ResearchArea { get; set; }
        public int TeachingHours { get; set; }

        public Faculty() { }

        public Faculty(string Username, string Password, string Email, Role Role) { 
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
        }

        public Faculty(int User_id, string Name, string Email, string Contact, Designation Designation, string ResearchArea, int TeachingHours) { 
            this.User_id = User_id;
            this.Name = Name;
            this.Email = Email;
            this.Contact = Contact;
            this.Designation = Designation;
            this.ResearchArea = ResearchArea;
            this.TeachingHours = TeachingHours;
        }
    }

    public class Role {
        public int Id { get; set; }
        public int LookUp_Id { get; set; }
        public string Value { get; set; }

        public override string ToString() {
            return Value;
        }
    }

    public class Designation {
        public int Id { get; set; }
        public int LookUp_Id { get; set; }
        public string Value { get; set; }

        public override string ToString() {
            return Value;
        }
    }
}
