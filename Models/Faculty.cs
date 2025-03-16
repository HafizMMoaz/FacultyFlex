using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public int User_id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Role { get; set; }
        public string RoleVal {  get; set; }

        public Faculty() { }

        public Faculty(string Username, string Password, string Email, int Role) { 
            this.Username = Username;
            this.Password = Password;
            this.Email = Email;
            this.Role = Role;
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
}
