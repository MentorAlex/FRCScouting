﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Scouting.Models
{
    public class Match
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Match Number")]
        public int MatchID { get; set; }
        public int TeamID { get; set; }
       // public int StatsID { get; set; }
        public int Score { get; set; }
        public string Result { get; set; }

        public string Shooter { get; set; }

        public virtual Team Team { get; set; }
        public virtual Stats Stats { get; set; }
    }
}