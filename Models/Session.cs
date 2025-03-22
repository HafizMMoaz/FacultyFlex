using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Models {
    public class Session {
        public static Faculty LoggedInFaculty { get; private set; } = null;

        public static void StartSession(Faculty faculty) {
            LoggedInFaculty = faculty;
        }

        public static void CloseSession() {
            LoggedInFaculty = null;
        }
    }
}
