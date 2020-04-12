using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public DbSet<Animal> Animals {get; set;}
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options){ }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal
            )
        }
    }
}