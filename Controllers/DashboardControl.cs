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
    }
}
