using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS25P023.Models {
    public class Course {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CreditHours { get; set; }
        public int ContactHours { get; set; }
    }
}
