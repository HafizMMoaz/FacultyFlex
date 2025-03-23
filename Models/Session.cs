using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Models {
    public class Session {
        public static Faculty LoggedInFaculty { get; set; }
        public static DBCred DBCred { get; set; }

        public static void StartSession(Faculty faculty) {
            LoggedInFaculty = faculty;
        }

        public static void CloseSession() {
            LoggedInFaculty = null;
        }

        public static void SetDbCred(DBCred dBCred) {
            DBCred = dBCred;
        }
    }
}
