using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        //public Faculty(string Username, string Password, string Email, Role Role) { 
        //    this.Username = Username;
        //    this.Password = Password;
        //    this.Email = Email;
        //    this.Role = Role;
        //}

        //public Faculty(int User_id, string Name, string Email, string Contact, Designation Designation, string ResearchArea, int TeachingHours) { 
        //    this.User_id = User_id;
        //    this.Name = Name;
        //    this.Email = Email;
        //    this.Contact = Contact;
        //    this.Designation = Designation;
        //    this.ResearchArea = ResearchArea;
        //    this.TeachingHours = TeachingHours;
        //}

        public override string ToString() {
            return Name;
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

    public class Course {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CreditHours { get; set; }
        public int ContactHours { get; set; }

        public override string ToString() {
            return $"{Name} - {Type}";
        }
    }

    public class FacultyCourse {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public Faculty Faculty { get; set; }
        public Course Course { get; set; }
        public Semester Semester { get; set; }
    }

    public class Semester {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string Term { get; set; }
        public int Year { get; set; }

        public override string ToString() {
            return $"{Term} - {Year}";
        }
    }

    public class Project {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString() {
            return Title;
        }
    }

    public class AdminRole {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public Faculty Faculty { get; set; }
        public string Name { get; set; }
        public Semester Semester { get; set; }
    }

    public class FacultyProject {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public Faculty Faculty{ get; set; }
        public Project Project { get; set; }
        public Semester Semester{ get; set; }
        public int SuperVisionHours { get; set; }
    }

    public class Room {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
    }

    public class FacultyRoom {
        public int SrNo { get; set;}
        public int Id { get; set; }
        public Faculty Faculty { get; set;}
        public Room Room { get; set; }
        public Semester Semester { get; set;}
        public int ReservedHours { get; set; }
    }

    public class Consumable {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString() {
            return Name;
        }
    }

    public class RequestStatus {
        public int Id { get; set; }
        public int LookUp_Id { get; set; }
        public string Value { get; set; }

        public override string ToString() {
            return Value;
        }
    }

    public class FacultyRequest {
        public int SrNo { get; set; }
        public int Id { get; set; }
        public Faculty Faculty{ get; set; }
        public Consumable Item { get; set; }
        public int Quantity { get; set; }
        public RequestStatus Status { get; set; }
        public string TimeStamp { get; set; }
    }

}
