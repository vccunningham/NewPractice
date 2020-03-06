using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPractice.Models {
    public class Players {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public string SchoolAttended { get; set; }
        public bool IsVeteran { get; set; }

        public Players() { }

    }
}
