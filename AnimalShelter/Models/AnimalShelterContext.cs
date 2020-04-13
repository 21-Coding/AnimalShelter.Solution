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
                new Animal { AnimalId = 1, Name = "Leonitus", Age = 4, Type = "Kangaroo" },
                new Animal { AnimalId = 2, Name = "Rudy", Age = 21, Type = "Monitor Lizard" },
                new Animal { AnimalId = 3, Name = "Ethan", Age = 6, Type = "Billy Goat" },
                new Animal { AnimalId = 4, Name = "Samantha", Age = 1, Type = "Manatee" },
                new Animal { AnimalId = 5, Name = "Stevent", Age = 8, Type = "Starfish" }
            );
        }
    }
}