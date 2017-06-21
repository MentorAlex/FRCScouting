using Scouting.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;

namespace Scouting.DAL
{
    public class ScoutingContext : DbContext
    {

        public ScoutingContext() : base("ScoutingContext")
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public object Articles { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        internal void Refresh(object clientWins, object articles)
        {
            throw new NotImplementedException();
        }
    }
}