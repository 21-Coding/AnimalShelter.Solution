﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    partial class AnimalShelterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 4,
                            Name = "Leonitus",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 21,
                            Name = "Rudy",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 6,
                            Name = "Ethan",
                            Type = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 1,
                            Name = "Samantha",
                            Type = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 8,
                            Name = "Stevent",
                            Type = "Cat"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
