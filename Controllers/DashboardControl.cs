using DBS25P023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Controllers {
    public class DashboardControl {
        private static DashboardControl _instance;

        private DashboardControl() { }

        public static DashboardControl Instance {
            get {
                if (_instance == null) {
                    _instance = new DashboardControl();
                }
                return _instance;
            }
        }

        public int TotalFacultyMembers() {
            string query = "SELECT COUNT(*) FROM users";
            return DB.Instance.Scalar(query);
        }

        public int TotalApprovedFaculty() {
            string query = "SELECT COUNT(*) FROM faculty";
            return DB.Instance.Scalar(query);
        }

        public int TotalCourses() {
            string query = "SELECT COUNT(*) FROM courses";
            return DB.Instance.Scalar(query);
        }

        public int TotalCoursesWithoutAssignedFaculty() {
            string query = "SELECT COUNT(*) FROM faculty_courses LEFT JOIN faculty using (faculty_id) WHERE faculty_id is null";
            return DB.Instance.Scalar(query);
        }

        public int TotalCoursesWithAssignedFaculty() {
            string query = "SELECT COUNT(*) FROM faculty_courses JOIN faculty using (faculty_id)";
            return DB.Instance.Scalar(query);
        }

        public int TotalAssignedSupervisors() {
            string query = "SELECT COUNT(*) FROM faculty_projects JOIN faculty using (faculty_id)";
            return DB.Instance.Scalar(query);
        }

        public int TotalNotAssignedSupervisors() {
            string query = "SELECT COUNT(*) FROM faculty_projects LEFT JOIN faculty using (faculty_id) WHERE faculty_id is NULL";
            return DB.Instance.Scalar(query);
        }

        public int TotalAdminRolesAssigned() {
            string query = "SELECT COUNT(*) FROM faculty_admin_roles JOIN faculty using (faculty_id)";
            return DB.Instance.Scalar(query);
        }

        public int TotalPendingRequests() {
            string query = "SELECT COUNT(*) FROM faculty_requests JOIN lookup ON status_id = lookup_id WHERE value = 'Pending'";
            return DB.Instance.Scalar(query);
        }

        public int TotalApprovedRequests() {
            string query = "SELECT COUNT(*) FROM faculty_requests JOIN lookup ON status_id = lookup_id WHERE value = 'Approved'";
            return DB.Instance.Scalar(query);
        }

        public int TotalRejectedRequests() {
            string query = "SELECT COUNT(*) FROM faculty_requests JOIN lookup ON status_id = lookup_id WHERE value = 'Rejected'";
            return DB.Instance.Scalar(query);
        }

        public int TotalFulfilledRequests() {
            string query = "SELECT COUNT(*) FROM faculty_requests JOIN lookup ON status_id = lookup_id WHERE value = 'Fulfilled'";
            return DB.Instance.Scalar(query);
        }
    }
}
