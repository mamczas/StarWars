using Microsoft.EntityFrameworkCore;
using StarWars.Context.Models;
using StarWars.Data;
using StarWars.Services.Dto;

namespace StarWars.Context
{
    public class StarWarsDbContext : DbContext 
    {
        public StarWarsDbContext(DbContextOptions<StarWarsDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<StarsShip>()
            //    .HasData(DataProvider.GetStarsStips());

            //modelBuilder.Entity<People>()
            //    .HasData(DataProvider.GetPeople());
        }

        //entities
        public DbSet<StarsShip> StarShips { get; set; }
        public DbSet<People> People { get; set; }
    }
}
