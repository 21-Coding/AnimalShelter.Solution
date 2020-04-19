using Microsoft.EntityFrameworkCore;


namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {   
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animals { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Leonitus", Age = 4, Type = "Cat" },
                new Animal { AnimalId = 2, Name = "Rudy", Age = 21, Type = "Dog" },
                new Animal { AnimalId = 3, Name = "Ethan", Age = 6, Type = "Cat" },
                new Animal { AnimalId = 4, Name = "Samantha", Age = 1, Type = "Dog" },
                new Animal { AnimalId = 5, Name = "Stevent", Age = 8, Type = "Cat" }
            );
        }
    }
}