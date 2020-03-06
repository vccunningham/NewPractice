using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPractice.Models {
    public class Coaches {

        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int YearsExperienced { get; set; }
        public bool IsTenured { get; set; }

        public Coaches() { }


    }
}
