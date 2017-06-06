using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scouting.Models
{
    public class Stats
    {
        public int StatsID { get; set; }
        public string Shooter { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}