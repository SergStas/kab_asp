using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KABLibrary.Models.DBModels;
using Microsoft.EntityFrameworkCore;

namespace KABLibrary.DBContext
{
    public class KABDBContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<BetEntry> BetEntries { get; set; }
        public DbSet<MatchResultBetModel> MatchResultBetModels { get; set; }

        public KABDBContext(DbContextOptions<KABDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
