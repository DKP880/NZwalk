using Microsoft.EntityFrameworkCore;
using NZwalkAPI.Models.Doman;

namespace NZwalkAPI.Data
{
    public class NZWalkDbContext : DbContext
    {
        public NZWalkDbContext(DbContextOptions dbContextOption) :base(dbContextOption)   
        {

        }

        public DbSet<Difficulty> MyDifficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> walks { get; set; }
    }
}
