using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Test.api.Models;

namespace Test.api.Models
{
    public class AthleteContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=athletes.db");
        }
    }
}