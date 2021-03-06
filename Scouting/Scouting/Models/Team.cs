﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Scouting.Models
{
    public class Team
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Team Number")]
        public int TeamID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}