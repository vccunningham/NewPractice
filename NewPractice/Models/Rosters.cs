using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPractice.Models {
    public class Rosters {

        public int Id { get; set; }
        public string HeadCoach { get; set; }
        public int JerseyNbr { get; set; }
        public string PositionId { get; set; }
        public bool IsStarter { get; set; }

        public virtual Coaches Coach { get; set; }
        public virtual Players Player { get; set; }

        public Rosters() { }

    }
}
