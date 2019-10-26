using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Fuel.Data
{
    public class FuelDbContext : DbContext
    {
        public DbSet<FuelStop> Stops {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=refueling.db");
        }
    }
}