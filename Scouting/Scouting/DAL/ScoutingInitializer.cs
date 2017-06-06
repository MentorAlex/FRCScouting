using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Scouting.Models;

namespace Scouting.DAL
{
    public class ScoutingInitializer : DropCreateDatabaseIfModelChanges<ScoutingContext>
    {
        //protected override void Seed(ScoutingContext context)
        //{
        //    var teams = new List<Team>
        //    {
        //        new Team {TeamID=1, Number=4085, Name="Cats", Location="Columbus"}
        //    };

        //    teams.ForEach(s => context.Teams.Add(s));
        //    context.SaveChanges();

        //    var matches = new List<Match>
        //    {
        //        new Match {TeamID=1, StatsID=12, Score=100, Result="W" }
        //    };

        //    matches.ForEach(s => context.Matches.Add(s));
        //    context.SaveChanges();


        //    var stats = new List<Stats>
        //    {
        //        new Stats {StatsID=12, Shooter=true }
        //    };

        //    stats.ForEach(s => context.Stats.Add(s));
        //    context.SaveChanges();
        //}
    }
}